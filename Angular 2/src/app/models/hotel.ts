// export interface Hotel {
//     Id : number,
//     Name : string,
//     Address : string,
//     City : string,
//     Country : string,
//     PhoneNumber : string,
//     Image : string,
// }   

export interface Hotel {
    Id : number,
    Name : string,
    Address : string,
    City : string,
    Country : string,
    PhoneNumber : string,
    Image : string,
    Rooms : Room[],
    Employees : Employee[]
}   

export interface Room {
    Id : number,
    RoomNumber : string,
    HotelId : number,
    RoomTypeId : number,
    Status : string,
    PricePerNight : number,
    Image : string
}       

export interface Employee{
    Id : number,
    HotelId : number,
    FullName : string,
    Role : string,
    Email : string,
    Image : string
}

  