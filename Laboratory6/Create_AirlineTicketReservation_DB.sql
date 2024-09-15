create database AirlineTicketReservation

use AirlineTicketReservation

create table Cashier
(
	Id bigint not null primary key identity(1, 1),
	Name nvarchar(100) not null,
	UserName nvarchar(100) not null unique,
	Email nvarchar(100) not null unique
)

create table Tickets
(
	Id bigint not null primary key identity(1, 1),
	Name nvarchar(100) not null
)

create table Passengers 
(
	Id bigint not null primary key identity(1, 1),
	Email nvarchar(100) not null unique,
	Password binary(100) not null
)

create table Payments
(
	Id bigint not null primary key identity(1, 1),
	Amount int not null,
	PaymentDate datetime2(7) not null,
	PassengersId bigint not null foreign key references Passengers(Id)
)

create table TicketReservations
(
	PassengersId bigint not null foreign key references Passengers(Id),
	TicketId bigint not null foreign key references Tickets(Id),
	CashierId bigint not null foreign key references Cashier(Id),
	BookingDate datetime2(7) not null,

	primary key (PassengersId, TicketId, CashierId)
)