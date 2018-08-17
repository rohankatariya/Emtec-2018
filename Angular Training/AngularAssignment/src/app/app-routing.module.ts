import { NgModule } from '@angular/core';
import { RouterModule, Route } from '@angular/router';
import { ShowComponent } from '../app/show/show.component';
import { UpdateComponent } from '../app/update/update.component';
import { AddComponent } from '../app/add/add.component';

const routes : Route[]=[
  { path : "", component : ShowComponent },
  { path : "Edit", component : UpdateComponent },
  { path : "AddEmployee", component : AddComponent },
]
@NgModule({
  exports: [
    RouterModule
  ],
  imports: [
    RouterModule.forRoot(routes)
  ],
  declarations: []
})
export class AppRoutingModule { }
