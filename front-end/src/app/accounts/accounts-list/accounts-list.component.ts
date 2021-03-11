import { ListResultDto, PagedAndSortedResultRequestDto } from '@abp/ng.core';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { AccountsService } from '@proxy/accounts';
import { AccountDto } from '@proxy/accounts/dto';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';

@Component({
  selector: 'app-accounts-list',
  templateUrl: './accounts-list.component.html',
  styleUrls: ['./accounts-list.component.scss'],
})
export class AccountsListComponent implements OnInit, OnDestroy {
  private unsubscribe: Subject<any> = new Subject<any>();

  accounts: AccountDto[] = [];

  constructor(private accountsService: AccountsService) {}

  ngOnInit(): void {
    this.accountsService
      .getList({} as PagedAndSortedResultRequestDto)
      .pipe(takeUntil(this.unsubscribe))
      .subscribe((result: ListResultDto<AccountDto>) => {
        this.accounts = result.items;
      });
  }

  ngOnDestroy(): void {
    this.unsubscribe.next();
    this.unsubscribe.complete();
  }
}
