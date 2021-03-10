import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AccountsListComponent } from './accounts-list/accounts-list.component';

import { AccountsComponent } from './accounts.component';

const routes: Routes = [
  {
    path: '',
    component: AccountsComponent,
    children: [
      { path: '', component: AccountsListComponent },
      { path: '**', pathMatch: 'full', redirectTo: '' },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AccountsRoutingModule {}
