import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HotelsService {
  // hotels = [
  //   {
  //     Id: 1,
  //     Name: "Grand Palace Hotel",
  //     Address: "123 Ocean Drive",
  //     City: "Miami",
  //     Country: "USA",
  //     PhoneNumber: "+1 305-555-1200",
  //     Image: "https://images.unsplash.com/photo-1566073771259-6a8506099945"
  //   },
  //   {
  //     Id: 2,
  //     Name: "The Royal Orchid",
  //     Address: "22 MG Road",
  //     City: "Bengaluru",
  //     Country: "India",
  //     PhoneNumber: "+91 80 2221 5678",
  //     Image: "https://images.unsplash.com/photo-1542314831-068cd1dbfeeb"
  //   },
  //   {
  //     Id: 3,
  //     Name: "Sunset Bay Resort",
  //     Address: "78 Beach Boulevard",
  //     City: "Sydney",
  //     Country: "Australia",
  //     PhoneNumber: "+61 2 9876 5432",
  //     Image: "https://images.unsplash.com/photo-1571896349842-33c89424de2d"
  //   },
  //   {
  //     Id: 4,
  //     Name: "The Emerald Stay",
  //     Address: "14 Orchard Road",
  //     City: "Singapore",
  //     Country: "Singapore",
  //     PhoneNumber: "+65 6123 9876",
  //     Image: "https://images.unsplash.com/photo-1582719478250-c89cae4dc85b"
  //   },
  //   {
  //     Id: 5,
  //     Name: "Hotel La Bella Vita",
  //     Address: "9 Via Roma",
  //     City: "Milan",
  //     Country: "Italy",
  //     PhoneNumber: "+39 02 4567 8910",
  //     Image: "https://images.unsplash.com/photo-1566073771259-6a8506099945"
  //   },
  //   {
  //     Id: 6,
  //     Name: "Mountain View Lodge",
  //     Address: "67 Alpine Road",
  //     City: "Zurich",
  //     Country: "Switzerland",
  //     PhoneNumber: "+41 44 123 4567",
  //     Image: "https://images.unsplash.com/photo-1505691723518-36a5ac3be353"
  //   },
  //   {
  //     Id: 7,
  //     Name: "The Imperial Plaza",
  //     Address: "56 King’s Avenue",
  //     City: "London",
  //     Country: "UK",
  //     PhoneNumber: "+44 20 7456 7890",
  //     Image: "https://images.unsplash.com/photo-1600585154340-be6161a56a0c"
  //   },
  //   {
  //     Id: 8,
  //     Name: "Desert Pearl Hotel",
  //     Address: "8 Palm Boulevard",
  //     City: "Dubai",
  //     Country: "UAE",
  //     PhoneNumber: "+971 4 432 9876",
  //     Image: "https://images.unsplash.com/photo-1582719508461-905c673771fd"
  //   },
  //   {
  //     Id: 9,
  //     Name: "Tokyo Grand Inn",
  //     Address: "3-2-1 Shinjuku",
  //     City: "Tokyo",
  //     Country: "Japan",
  //     PhoneNumber: "+81 3-1234-5678",
  //     Image: "https://images.unsplash.com/photo-1600585154340-be6161a56a0c"
  //   },
  //   {
  //     Id: 10,
  //     Name: "The Riviera Resort",
  //     Address: "25 Boulevard de la Mer",
  //     City: "Nice",
  //     Country: "France",
  //     PhoneNumber: "+33 4 93 123 456",
  //     Image: "https://images.unsplash.com/photo-1559599101-f09722fb4948"
  //   }
  // ];
  

  hotels = [
    {
      Id: 1,
      Name: "Grand Palace Hotel",
      Address: "123 Ocean Drive",
      City: "Miami",
      Country: "USA",
      PhoneNumber: "+1 305-555-1200",
      Image: "https://images.unsplash.com/photo-1566073771259-6a8506099945",
      Rooms: [
        {
          Id: 1,
          RoomNumber: "101",
          HotelId: 1,
          RoomTypeId: 1,
          Status: "Available",
          PricePerNight: 250,
          Image: "https://images.unsplash.com/photo-1505691723518-36a5ac3be353"
        },
        {
          Id: 2,
          RoomNumber: "102",
          HotelId: 1,
          RoomTypeId: 2,
          Status: "Booked",
          PricePerNight: 320,
          Image: "https://images.unsplash.com/photo-1600585154340-be6161a56a0c"
        }
      ],
      Employees: [
        {
          Id: 1,
          HotelId: 1,
          FullName: "John Smith",
          Role: "Manager",
          Email: "john.smith@grandpalace.com",
          Image: "https://randomuser.me/api/portraits/men/1.jpg"
        },
        {
          Id: 2,
          HotelId: 1,
          FullName: "Emily Davis",
          Role: "Receptionist",
          Email: "emily.davis@grandpalace.com",
          Image: "https://randomuser.me/api/portraits/women/2.jpg"
        }
      ]
    },
    {
      Id: 2,
      Name: "The Royal Orchid",
      Address: "22 MG Road",
      City: "Bengaluru",
      Country: "India",
      PhoneNumber: "+91 80 2221 5678",
      Image: "https://images.unsplash.com/photo-1542314831-068cd1dbfeeb",
      Rooms: [
        {
          Id: 3,
          RoomNumber: "201",
          HotelId: 2,
          RoomTypeId: 1,
          Status: "Available",
          PricePerNight: 180,
          Image: "https://images.unsplash.com/photo-1522708323590-d24dbb6b0267"
        },
        {
          Id: 4,
          RoomNumber: "202",
          HotelId: 2,
          RoomTypeId: 2,
          Status: "Maintenance",
          PricePerNight: 250,
          Image: "https://images.unsplash.com/photo-1600585154340-be6161a56a0c"
        }
      ],
      Employees: [
        {
          Id: 3,
          HotelId: 2,
          FullName: "Rajesh Kumar",
          Role: "Manager",
          Email: "rajesh.kumar@royalorchid.com",
          Image: "https://randomuser.me/api/portraits/men/3.jpg"
        },
        {
          Id: 4,
          HotelId: 2,
          FullName: "Priya Singh",
          Role: "Front Desk",
          Email: "priya.singh@royalorchid.com",
          Image: "https://randomuser.me/api/portraits/women/4.jpg"
        }
      ]
    },
    {
      Id: 3,
      Name: "Sunset Bay Resort",
      Address: "78 Beach Boulevard",
      City: "Sydney",
      Country: "Australia",
      PhoneNumber: "+61 2 9876 5432",
      Image: "https://images.unsplash.com/photo-1571896349842-33c89424de2d",
      Rooms: [
        {
          Id: 5,
          RoomNumber: "301",
          HotelId: 3,
          RoomTypeId: 1,
          Status: "Available",
          PricePerNight: 210,
          Image: "https://images.unsplash.com/photo-1505691938895-1758d7feb511"
        },
        {
          Id: 6,
          RoomNumber: "302",
          HotelId: 3,
          RoomTypeId: 3,
          Status: "Booked",
          PricePerNight: 350,
          Image: "https://images.unsplash.com/photo-1505691938895-1758d7feb511"
        }
      ],
      Employees: [
        {
          Id: 5,
          HotelId: 3,
          FullName: "James Brown",
          Role: "Manager",
          Email: "james.brown@sunsetbay.com",
          Image: "https://randomuser.me/api/portraits/men/5.jpg"
        },
        {
          Id: 6,
          HotelId: 3,
          FullName: "Sophie Lee",
          Role: "Housekeeping",
          Email: "sophie.lee@sunsetbay.com",
          Image: "https://randomuser.me/api/portraits/women/6.jpg"
        }
      ]
    },
    {
      Id: 4,
      Name: "The Emerald Stay",
      Address: "14 Orchard Road",
      City: "Singapore",
      Country: "Singapore",
      PhoneNumber: "+65 6123 9876",
      Image: "https://images.unsplash.com/photo-1582719478250-c89cae4dc85b",
      Rooms: [
        {
          Id: 7,
          RoomNumber: "401",
          HotelId: 4,
          RoomTypeId: 1,
          Status: "Available",
          PricePerNight: 300,
          Image: "https://images.unsplash.com/photo-1600607687939-ce8a6c25118c"
        },
        {
          Id: 8,
          RoomNumber: "402",
          HotelId: 4,
          RoomTypeId: 2,
          Status: "Booked",
          PricePerNight: 400,
          Image: "https://images.unsplash.com/photo-1505691723518-36a5ac3be353"
        }
      ],
      Employees: [
        {
          Id: 7,
          HotelId: 4,
          FullName: "Daniel Wong",
          Role: "Manager",
          Email: "daniel.wong@emeraldstay.com",
          Image: "https://randomuser.me/api/portraits/men/7.jpg"
        },
        {
          Id: 8,
          HotelId: 4,
          FullName: "Lena Tan",
          Role: "Concierge",
          Email: "lena.tan@emeraldstay.com",
          Image: "https://randomuser.me/api/portraits/women/8.jpg"
        }
      ]
    },
    {
      Id: 5,
      Name: "Hotel La Bella Vita",
      Address: "9 Via Roma",
      City: "Milan",
      Country: "Italy",
      PhoneNumber: "+39 02 4567 8910",
      Image: "https://images.unsplash.com/photo-1566073771259-6a8506099945",
      Rooms: [
        {
          Id: 9,
          RoomNumber: "501",
          HotelId: 5,
          RoomTypeId: 1,
          Status: "Available",
          PricePerNight: 270,
          Image: "https://images.unsplash.com/photo-1600585154340-be6161a56a0c"
        },
        {
          Id: 10,
          RoomNumber: "502",
          HotelId: 5,
          RoomTypeId: 2,
          Status: "Booked",
          PricePerNight: 360,
          Image: "https://images.unsplash.com/photo-1559599101-f09722fb4948"
        }
      ],
      Employees: [
        {
          Id: 9,
          HotelId: 5,
          FullName: "Marco Rossi",
          Role: "Manager",
          Email: "marco.rossi@labellavita.com",
          Image: "https://randomuser.me/api/portraits/men/9.jpg"
        },
        {
          Id: 10,
          HotelId: 5,
          FullName: "Giulia Bianchi",
          Role: "Chef",
          Email: "giulia.bianchi@labellavita.com",
          Image: "https://randomuser.me/api/portraits/women/10.jpg"
        }
      ]
    },
    {
      Id: 6,
      Name: "Mountain View Lodge",
      Address: "67 Alpine Road",
      City: "Zurich",
      Country: "Switzerland",
      PhoneNumber: "+41 44 123 4567",
      Image: "https://images.unsplash.com/photo-1505691723518-36a5ac3be353",
      Rooms: [
        {
          Id: 11,
          RoomNumber: "601",
          HotelId: 6,
          RoomTypeId: 1,
          Status: "Available",
          PricePerNight: 290,
          Image: "https://images.unsplash.com/photo-1522708323590-d24dbb6b0267"
        },
        {
          Id: 12,
          RoomNumber: "602",
          HotelId: 6,
          RoomTypeId: 2,
          Status: "Booked",
          PricePerNight: 370,
          Image: "https://images.unsplash.com/photo-1600585154340-be6161a56a0c"
        }
      ],
      Employees: [
        {
          Id: 11,
          HotelId: 6,
          FullName: "Lukas Meier",
          Role: "Manager",
          Email: "lukas.meier@mountainview.com",
          Image: "https://randomuser.me/api/portraits/men/11.jpg"
        },
        {
          Id: 12,
          HotelId: 6,
          FullName: "Sabrina Keller",
          Role: "Housekeeping",
          Email: "sabrina.keller@mountainview.com",
          Image: "https://randomuser.me/api/portraits/women/12.jpg"
        }
      ]
    },
    {
      Id: 7,
      Name: "The Imperial Plaza",
      Address: "56 King’s Avenue",
      City: "London",
      Country: "UK",
      PhoneNumber: "+44 20 7456 7890",
      Image: "https://images.unsplash.com/photo-1600585154340-be6161a56a0c",
      Rooms: [
        {
          Id: 13,
          RoomNumber: "701",
          HotelId: 7,
          RoomTypeId: 1,
          Status: "Available",
          PricePerNight: 280,
          Image: "https://images.unsplash.com/photo-1616594039964-ae9021a400a0"
        },
        {
          Id: 14,
          RoomNumber: "702",
          HotelId: 7,
          RoomTypeId: 3,
          Status: "Booked",
          PricePerNight: 400,
          Image: "https://images.unsplash.com/photo-1505691938895-1758d7feb511"
        }
      ],
      Employees: [
        {
          Id: 13,
          HotelId: 7,
          FullName: "Oliver Clark",
          Role: "Manager",
          Email: "oliver.clark@imperialplaza.com",
          Image: "https://randomuser.me/api/portraits/men/13.jpg"
        },
        {
          Id: 14,
          HotelId: 7,
          FullName: "Charlotte Green",
          Role: "Receptionist",
          Email: "charlotte.green@imperialplaza.com",
          Image: "https://randomuser.me/api/portraits/women/14.jpg"
        }
      ]
    },
    {
      Id: 8,
      Name: "Desert Pearl Hotel",
      Address: "8 Palm Boulevard",
      City: "Dubai",
      Country: "UAE",
      PhoneNumber: "+971 4 432 9876",
      Image: "https://images.unsplash.com/photo-1582719508461-905c673771fd",
      Rooms: [
        {
          Id: 15,
          RoomNumber: "801",
          HotelId: 8,
          RoomTypeId: 2,
          Status: "Available",
          PricePerNight: 310,
          Image: "https://images.unsplash.com/photo-1559599101-f09722fb4948"
        },
        {
          Id: 16,
          RoomNumber: "802",
          HotelId: 8,
          RoomTypeId: 3,
          Status: "Maintenance",
          PricePerNight: 380,
          Image: "https://images.unsplash.com/photo-1505691723518-36a5ac3be353"
        }
      ],
      Employees: [
        {
          Id: 15,
          HotelId: 8,
          FullName: "Omar Al-Farsi",
          Role: "Manager",
          Email: "omar.alfarsi@desertpearl.com",
          Image: "https://randomuser.me/api/portraits/men/15.jpg"
        },
        {
          Id: 16,
          HotelId: 8,
          FullName: "Layla Hassan",
          Role: "Front Desk",
          Email: "layla.hassan@desertpearl.com",
          Image: "https://randomuser.me/api/portraits/women/16.jpg"
        }
      ]
    },
    {
      Id: 9,
      Name: "Tokyo Grand Inn",
      Address: "3-2-1 Shinjuku",
      City: "Tokyo",
      Country: "Japan",
      PhoneNumber: "+81 3-1234-5678",
      Image: "https://images.unsplash.com/photo-1600585154340-be6161a56a0c",
      Rooms: [
        {
          Id: 17,
          RoomNumber: "901",
          HotelId: 9,
          RoomTypeId: 1,
          Status: "Available",
          PricePerNight: 200,
          Image: "https://images.unsplash.com/photo-1522708323590-d24dbb6b0267"
        },
        {
          Id: 18,
          RoomNumber: "902",
          HotelId: 9,
          RoomTypeId: 2,
          Status: "Booked",
          PricePerNight: 280,
          Image: "https://images.unsplash.com/photo-1600585154340-be6161a56a0c"
        }
      ],
      Employees: [
        {
          Id: 17,
          HotelId: 9,
          FullName: "Hiroshi Tanaka",
          Role: "Manager",
          Email: "hiroshi.tanaka@tokyograndin.com",
          Image: "https://randomuser.me/api/portraits/men/17.jpg"
        },
        {
          Id: 18,
          HotelId: 9,
          FullName: "Yuki Sato",
          Role: "Receptionist",
          Email: "yuki.sato@tokyograndin.com",
          Image: "https://randomuser.me/api/portraits/women/18.jpg"
        }
      ]
    },
    {
      Id: 10,
      Name: "The Riviera Resort",
      Address: "25 Boulevard de la Mer",
      City: "Nice",
      Country: "France",
      PhoneNumber: "+33 4 93 123 456",
      Image: "https://images.unsplash.com/photo-1559599101-f09722fb4948",
      Rooms: [
        {
          Id: 19,
          RoomNumber: "1001",
          HotelId: 10,
          RoomTypeId: 1,
          Status: "Available",
          PricePerNight: 240,
          Image: "https://images.unsplash.com/photo-1616594039964-ae9021a400a0"
        },
        {
          Id: 20,
          RoomNumber: "1002",
          HotelId: 10,
          RoomTypeId: 2,
          Status: "Booked",
          PricePerNight: 330,
          Image: "https://images.unsplash.com/photo-1505691938895-1758d7feb511"
        }
      ],
      Employees: [
        {
          Id: 19,
          HotelId: 10,
          FullName: "Pierre Dupont",
          Role: "Manager",
          Email: "pierre.dupont@rivieraresort.com",
          Image: "https://randomuser.me/api/portraits/men/19.jpg"
        },
        {
          Id: 20,
          HotelId: 10,
          FullName: "Camille Laurent",
          Role: "Chef",
          Email: "camille.laurent@rivieraresort.com",
          Image: "https://randomuser.me/api/portraits/women/20.jpg"
        }
      ]
    }
  ];
  
  constructor() { }

  getAllHotel(){
    return this.hotels
  }

  getById(id : number){
    return this.hotels.find((hotel)=>hotel.Id==id)
  }
}
