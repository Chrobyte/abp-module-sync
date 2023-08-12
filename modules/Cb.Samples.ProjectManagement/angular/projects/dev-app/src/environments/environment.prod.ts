import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'ProjectManagement',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44327/',
    redirectUri: baseUrl,
    clientId: 'ProjectManagement_App',
    responseType: 'code',
    scope: 'offline_access ProjectManagement',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44327',
      rootNamespace: 'Cb.Samples.ProjectManagement',
    },
    ProjectManagement: {
      url: 'https://localhost:44380',
      rootNamespace: 'Cb.Samples.ProjectManagement',
    },
  },
} as Environment;
