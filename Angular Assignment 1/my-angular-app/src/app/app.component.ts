import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TableComponent } from './table/table.component';
import { NewLinkComponent } from './new-link/new-link.component';
import { CreateListComponent } from './create-list/create-list.component';
import { NestedListComponent } from './nested-list/nested-list.component';
import { AlertButtonComponent } from './alert-button/alert-button.component';
import { LeapYearComponent } from "./leap-year/leap-year.component";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, TableComponent, NewLinkComponent, CreateListComponent, NestedListComponent, AlertButtonComponent, LeapYearComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css' 
})
export class AppComponent {
  title = 'my-angular-app';
}
