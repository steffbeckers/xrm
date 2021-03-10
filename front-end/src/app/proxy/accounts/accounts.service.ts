import type { AccountDto } from './dto/models';
import { RestService } from '@abp/ng.core';
import type { ListResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class AccountsService {
  apiName = 'Default';

  getList = () =>
    this.restService.request<any, ListResultDto<AccountDto>>({
      method: 'GET',
      url: `/api/app/accounts`,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
