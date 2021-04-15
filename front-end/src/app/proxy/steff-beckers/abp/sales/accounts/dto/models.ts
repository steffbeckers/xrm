import type { AuditedEntityDto, EntityDto } from '@abp/ng.core';

export interface AccountDto extends AuditedEntityDto<string> {
  name?: string;
  email?: string;
  telephone?: string;
  website?: string;
}

export interface CreateAccountDto extends EntityDto<string> {
  name: string;
  email?: string;
  telephone?: string;
  website?: string;
}

export interface UpdateAccountDto extends EntityDto<string> {
  name: string;
  email?: string;
  telephone?: string;
  website?: string;
}
