create database MaximumMiniatures

use MaximumMiniatures

create table DimBatch
(
	BatchNumber int not null primary key identity(1, 1),
	BatchName varchar(50) not null
);

create table DimCountry
(
	CountryCode char(2) not null primary key,
	CountryName varchar(50) not null unique
)

create table DimPlant
(
	PlantNumber int not null primary key identity(1, 1),
	PlantName varchar(30) not null,
	CountryCode char(2) not null foreign key references DimCountry(CountryCode) 
)

create table DimMaterial
(
	Material varchar(30) not null primary key
)

create table DimMachineType
(
	MachineType varchar(30) not null primary key,
	Material varchar(30) not null foreign key references DimMaterial(Material)
)

create table DimMachine
(
	MachineNumber int not null primary key identity(1, 1),
	MachineName varchar(50) not null,
	MachineType varchar(30) not null foreign key references DimMachineType(MachineType),
	PlantNumber int not null foreign key references DimPlant(PlantNumber),
	Manufacturer varchar(50) not null,
	DateOfPurchase datetime2(7) not null
)

create table DimProductType
(
	ProductTypeCode int not null primary key identity(1, 1),
	ProductTypeName varchar(50) not null unique
)

create table DimProductSubtype
(
	ProductSubtypeCode int not null primary key,
	ProductSubtypeName varchar(50) not null unique,
	ProductTypeCode int not null foreign key references DimProductType(ProductTypeCode)
)

create table DimProduct
(
	ProductCode int not null primary key,
	ProductName varchar(50) not null unique,
	ProductSubtypeCode int not null foreign key references DimProductSubtype(ProductSubtypeCode)
)

create table ManufacturingFact
(
	ManufacturingFactNumber int not null primary key identity(1, 1),
	AcceptedProducts int,
	RejectedProducts int,
	ElapsedTimeForManufacture decimal(6, 2),
	ProductCode int not null foreign key references DimProduct(ProductCode),
	BatchNumber int not null foreign key references DimBatch(BatchNumber),
	MachineNumber int not null foreign key references DimMachine(MachineNumber)
)