import { Component } from '@angular/core';

const image1 = "banner.jpg"

@Component({
  selector: 'app-employees',
  imports: [],
  templateUrl: './employees.component.html',
  styleUrl: './employees.component.scss'
})
export class EmployeesComponent {  
  image = image1
}
