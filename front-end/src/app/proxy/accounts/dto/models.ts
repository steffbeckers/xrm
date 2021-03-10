import type { AuditedEntityDto } from '@abp/ng.core';

export interface AccountDto extends AuditedEntityDto {
  name?: string;
  email?: string;
  telephone?: string;
  website?: string;
}
