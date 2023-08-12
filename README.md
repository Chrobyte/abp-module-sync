# abp-module-sync
Code on how to keep entities in sync using EntitySynchronizer.

For more information, take a look at our blog post [here](https://chrobyte.de/blogs/default/abp-module-development-and-cross-module-dependencies).

Initial code was generated using the [abp cli](https://docs.abp.io/en/abp/latest/CLI#options).

```sh
abp new Cb.Samples.ProjectManagement -t module -csf
```

```sh
abp new Cb.Samples.CustomerManagement -t module -csf
```

```sh
abp new Cb.Samples.ModulesEntitySync8 -t app -u blazor-server -dbms SqlServer
```
