create table Movies(
	name varchar(100),
	MovieId int identity(1,1) primary key,
	language varchar(100),
	runtime int,
	rating int,
	releasedDate datetime,
	censorRating varchar(100),
	posterUrl varchar(250),
	trailerUrl varchar(250)
);

create table Actors(
	ActorId int identity(1,1) primary key,
	name varchar(100),
	age int
)

create table Director(
	DirectorId int identity(1,1) primary key,
	name varchar(100),
	age int
)

create table Genres(
	GenereId int identity(1,1) primary key,
	name varchar(100)
);

create table DirectorMovieDetail(
	id int identity(1,1) primary key, 
	MovieId int,
	DirectorId int,
	foreign key (MovieId) references Movies(MovieId),
	foreign key (DirectorId) references Director(DirectorId)
);

create table ActorMovieDetail(
	id int identity(1,1) primary key,
	ActorId int,
	MovieId int,
	foreign key (ActorId) references Actors(ActorId),
	foreign key (MovieId) references Movies(MovieId)
);

create table MovieGenreDetail(
	id int identity(1,1) primary key,
	MovieId int,
	GenereId int,
	foreign key (MovieId) references Movies(MovieId),
	foreign key (GenereId) references Genres(GenereId)
);

create table Users(
	UserId int identity(1,1) primary key,
	fullName varchar(100),
	email varchar(100),
	phone varchar(100)
);

create table Country(
	CoutryId int identity(1,1) primary key,
	countryName varchar(100)
);

create table State(
	StateId int identity(1,1) primary key, 
	StateName varchar(100),
	CountryId int,
	foreign key (CoutryId) references Country(CoutryId)
);

create table City(
	cityId int identity(1,1) primary key,
	cityName varchar(100)
	StateId int,
	foreign key (StateId) references State(StateId)
);

create table Theaters(
	TheaterId int identity(1,1) primary key,
	name varchar(100),
	cityId int,
	foreign key (cityId) references City(cityId)
);

create table Screens(
	ScreenId int identity(1,1) primary key,
	TheaterId int,
  	screenName varchar(100),
	foreign key (TheaterId) references Theaters(TheaterId),
);

create table Shows(
	ShowId int identity(1,1) primary key,
	MovieId int,
	ScreenId int,
	showdate datetime,
	showtime datetime,
	foreign key (MovieId) references Movies(MovieId),
	foreign key (ScreenId) references Screens(ScreenId)
);

create table SeatType(
	seatTypeId int identity(1,1) primary key,
	seatTypeName varchar(100),
)

create table Seats(
	SeatId int identity(1,1) primary key,
	ScreenId int,
	seatTypeId int,
	seatNumber varchar(100),
	price int,
	foreign key (ScreenId) references Screens(ScreenId)
	foreign key (seatTypeId) references SeatType(seatTypeId)
);

create table Coupons(
	CouponId int identity(1,1) primary key,
	CouponCode varchar(100),
	discountPrice int,
	StartDate datetime,
	EndDate datetime,
)

create table Bookings(
	BookingId int identity(1,1) primary key,
	UserId int,
	ShowId int,
  	PaymentId int
	CouponId int,
	bookingDate datetime,
	totalAmount int,
	foreign key (UserId) references Users(UserId),
	foreign key (ShowId) references Shows(ShowId),
  	foreign key (PaymentId) references Payment(PaymentId),
	foreign key (CouponId) references Coupons(CouponId)
	
);

create table BookingDetails(
	BookingDetailId int identity(1,1) primary key,
	BookingId int,
	SeatId int,
	foreign key (BookingId) references Bookings(BookingId),
	foreign key (SeatId) references Seats(SeatId)
)

create table Payment(
	PaymentId int identity(1,1) primary key,
	paymentType varchar(100),
	paymentStatus varchar(100),
	paymentDate datetime,
	paymentTime datetime
)

create table Reviews(
	ReviewId int identity(1,1) primary key
	MovieId int,
	UserId int,
	rating int,
	reviewText varchar(100),
	foreign key (MovieId) references Movies(MovieId),
	foreign key (UserId) references Users(UserId),
)