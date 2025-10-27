create table Movies(
	name varchar(100),
	MovieId int identity(1,1) primary key,
	language varchar(100),
	runtime int,
	rating int,
	releasedDate datetime
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

create table Theaters(
	TheaterId int identity(1,1) primary key,
	name varchar(100),
	Locality varchar(100)
);

create table Screens(
	ScreenId int identity(1,1) primary key,
	TheaterId int,
  screenName varchar(100),
	foreign key (TheaterId) references Theaters(TheaterId),
);

create table Show(
	ShowId int identity(1,1) primary key,
	MovieId int,
	ScreenId int,
	showdate datetime,
	showtime datetime,
	foreign key (MovieId) references Movies(MovieId),
	foreign key (ScreenId) references Screens(ScreenId)
);

create table Seats(
	SeatId int identity(1,1) primary key,
	ScreenId int,
	seatType varchar(100),
	seatNumber varchar(100),
	price int,
	foreign key (ScreenId) references Screens(ScreenId)
);

create table Bookings(
	BookingId int identity(1,1) primary key,
	UserId int,
	ShowId int,
  PaymentId int
	bookingDate datetime,
	totalAmount int,
	foreign key (UserId) references Users(UserId),
	foreign key (ShowId) references Show(ShowId),
  foreign key (PaymentId) references Payment(PaymentId)
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