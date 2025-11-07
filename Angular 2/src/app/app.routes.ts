import { Routes } from '@angular/router';
import { HomeComponent } from './features/home/home.component';
import { HotelListComponent } from './features/hotels/hotel-list/hotel-list.component';
import { HotelDetailsComponent } from './features/hotels/hotel-details/hotel-details.component';
import { CustomersListComponent } from './features/customer/customers-list/customers-list.component';
import { CustomersDetailsComponent } from './features/customer/customers-details/customers-details.component';
import { RoomsComponent } from './features/hotels/hotel-details/rooms/rooms.component';
import { EmployeesComponent } from './features/hotels/hotel-details/employees/employees.component';
import { ReviewsComponent } from './features/hotels/hotel-details/reviews/reviews.component';

export const routes: Routes = [
    {path : '', redirectTo : 'home', pathMatch : 'full'},
    {path : 'home', component : HomeComponent},
    {path : 'hotels', component : HotelListComponent},
    {path : 'hotels/:hotelId', component : HotelDetailsComponent, children : [
        {path : 'rooms', component : RoomsComponent},
        {path : 'employees', component : EmployeesComponent},
        {path : 'reviews', component : ReviewsComponent}
    ]},
    {path : 'customers', component : CustomersListComponent},
    {path : 'customers/:customerId', component : CustomersDetailsComponent}
];
