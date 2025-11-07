import { Component, OnInit, inject, signal } from '@angular/core';
import { HotelsService } from '../../../services/hotels.service';
import { Hotel } from '../../../models/hotel';
import { ActivatedRoute, Router, RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common'
import { NavbarComponent } from "../../../shared/navbar/navbar.component";
import { RoomsComponent } from './rooms/rooms.component';

@Component({
  selector: 'app-hotel-details',
  standalone : true,
  imports: [CommonModule, NavbarComponent, RouterLink, RouterLinkActive, RouterOutlet, RoomsComponent],
  templateUrl: './hotel-details.component.html',
  styleUrl: './hotel-details.component.scss',
})
export class HotelDetailsComponent implements OnInit {
  hotelService = inject(HotelsService);
  hotel = signal<Hotel | null>(null);
  route = inject(ActivatedRoute);
  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('hotelId'));
    const foundHotel = this.hotelService.getById(id);
    if (foundHotel) {
      this.hotel.set(foundHotel);
    }
  }

  onSelectedRoom(id : number){
    console.log(id)
  }
}
