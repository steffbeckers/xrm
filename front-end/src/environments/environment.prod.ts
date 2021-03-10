import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'XRM',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44379',
    redirectUri: baseUrl,
    clientId: 'XRM_App',
    responseType: 'code',
    scope: 'offline_access XRM',
  },
  apis: {
    default: {
      url: 'https://localhost:44379',
      rootNamespace: 'XRM',
    },
  },
} as Environment;
