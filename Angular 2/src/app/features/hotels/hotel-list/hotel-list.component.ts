import { Component, OnInit, inject, signal } from '@angular/core';
import { NavbarComponent } from "../../../shared/navbar/navbar.component";
import { Hotel } from '../../../models/hotel';
import { HotelsService } from '../../../services/hotels.service';
import { Router, RouterLink } from "@angular/router";

@Component({
  selector: 'app-hotel-list',
  imports: [NavbarComponent],
  templateUrl: './hotel-list.component.html',
  styleUrl: './hotel-list.component.scss'
})
export class HotelListComponent implements OnInit {
  hotelService = inject(HotelsService);

  hotels = signal<Array<Hotel>>([])
  router = inject(Router);

  ngOnInit(): void {
    this.hotels.set(this.hotelService.getAllHotel())
  }

  onViewDetail(id : number){
    this.router.navigate(['/hotels', id])
  }
}
