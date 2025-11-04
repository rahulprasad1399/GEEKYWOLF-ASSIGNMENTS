import { Component } from '@angular/core';

@Component({
  selector: 'app-leap-year',
  imports: [],
  templateUrl: './leap-year.component.html',
  styleUrl: './leap-year.component.css'
})
export class LeapYearComponent {
  leapyear = false

  isLeapYear(year : number){
    if((year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0)){
      this.leapyear = true
      console.log("leap year : ", this.leapyear)
  } else {
      this.leapyear = false
  }
  }

  constructor(){
    this.isLeapYear(2024)
  }

}
