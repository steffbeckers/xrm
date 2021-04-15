import type { AccountDto, CreateAccountDto, UpdateAccountDto } from './dto/models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class AccountsService {
  apiName = 'Default';

  create = (input: CreateAccountDto) =>
    this.restService.request<any, AccountDto>({
      method: 'POST',
      url: `/api/app/accounts`,
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/accounts/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, AccountDto>({
      method: 'GET',
      url: `/api/app/accounts/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<AccountDto>>({
      method: 'GET',
      url: `/api/app/accounts`,
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: UpdateAccountDto) =>
    this.restService.request<any, AccountDto>({
      method: 'PUT',
      url: `/api/app/accounts/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
