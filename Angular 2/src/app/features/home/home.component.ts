import { Component } from '@angular/core';
import { NavbarComponent } from "../../shared/navbar/navbar.component";
import { RouterLink } from "@angular/router";
import { Router} from "@angular/router" 

@Component({
  selector: 'app-home',
  imports: [NavbarComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})

export class HomeComponent {

  constructor(private router : Router){

  }

  onClick(){
    this.router.navigate(['/hotels'])
  }
}
