import { Input } from '@angular/core';
import { Component } from '@angular/core';
import { Hotel } from '../../../../models/hotel';
import { OnInit } from '@angular/core';
import { Output } from '@angular/core';
import { EventEmitter } from '@angular/core';

@Component({
  selector: 'app-rooms',
  standalone : true,
  imports: [],
  templateUrl: './rooms.component.html',
  styleUrl: './rooms.component.scss'
})
export class RoomsComponent implements OnInit {

  room = {
    Id: 1,
    RoomNumber: "A101",
    HotelId: 1,
    RoomTypeId: 1,
    Status: "Available",      
    PricePerNight: 180.50,
    Image: "https://images.unsplash.com/photo-1600585154340-be6161a56a0c"
  }

  @Input({required : true}) hotel? : Hotel | null 
  @Output() roomSelected = new EventEmitter()
  
  ngOnInit(): void{
    console.log(this.hotel)
  }

  onRoomSelection(id : number){
    this.roomSelected.emit(id)
  }

}
