import { NgModule } from '@angular/core';

import { AccountsRoutingModule } from './accounts-routing.module';
import { AccountsComponent } from './accounts.component';
import { SharedModule } from '../shared/shared.module';
import { AccountsListComponent } from './accounts-list/accounts-list.component';

@NgModule({
  declarations: [AccountsComponent, AccountsListComponent],
  imports: [SharedModule, AccountsRoutingModule],
})
export class AccountsModule {}
