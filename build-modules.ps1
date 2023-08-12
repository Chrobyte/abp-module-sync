$ErrorActionPreference = "Stop";

$currentLocation = $PSScriptRoot;

$modulesDirectory = Join-Path -Path $currentLocation -ChildPath "modules";
$moduleFolders = Get-ChildItem -Path $modulesDirectory -Directory;

foreach ($moduleFolder in $moduleFolders) {
    $solutionPath = Join-Path -Path $moduleFolder.FullName -ChildPath "$($moduleFolder.Name).sln";

    Write-Host "Building solution: $solutionPath";
    dotnet build $solutionPath;

    $nupkgFiles = Get-ChildItem -Path $moduleFolder.FullName -Recurse -File -Filter "*.nupkg";

    $packagesPath = Join-Path -Path $currentLocation -ChildPath "packages";

    if (-not (Test-Path -Path $packagesPath)) {
        New-Item -Path $packagesPath -ItemType Directory;
    }

    foreach ($nupkgFile in $nupkgFiles) {

        if ($nupkgFile -notlike "*\src\*" -and $nupkgFile -notlike "*\bin\*") {
            continue;
        }

        $destinationPath = Join-Path -Path $packagesPath -ChildPath $nupkgFile.Name;
        Copy-Item -Path $nupkgFile.FullName -Destination $destinationPath -Force;
        Write-Host "Copied $nupkgFile to $destinationPath";
    }
}

Write-Host "Build and copy process completed.";

Set-Location $currentLocation;