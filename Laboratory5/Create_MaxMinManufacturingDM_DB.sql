create database MaxMinManufacturingDM

use MaxMinManufacturingDM

go;

create or alter procedure AddDescriptionToTable @tableName nvarchar(100), @descrition nvarchar(1000)
as

	exec sys.sp_addextendedproperty 
		 @name = N'MS_Description',
		 @value = @descrition,
		 @level0type = N'SCHEMA',
		 @level0name = N'dbo',
		 @level1type = N'TABLE',
		 @level1name = @tableName

go;

use MaxMinManufacturingDM

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
	ProductTypeName varchar(50) not null
)

create table DimProductSubtype
(
	ProductSubtypeCode int not null primary key,
	ProductSubtypeName varchar(50) not null,
	ProductTypeCode int not null foreign key references DimProductType(ProductTypeCode)
)

execute AddDescriptionToTable @tableName = N'DimProductSubtype', 
							  @descrition = N'Виміри підтипів виробів з таблиці ProductSubtype системи бухгалтерського обліку'


create table DimProduct
(
	ProductCode int not null primary key,
	ProductName varchar(50) not null,
	ProductSubtypeCode int not null foreign key references DimProductSubtype(ProductSubtypeCode)
)

execute AddDescriptionToTable @tableName = N'DimProduct', 
							  @descrition = N'Виміри підтипів виробів з таблиці ProductSubtype системи бухгалтерського обліку'


create table ManufacturingFact
(
	ManufacturingFactNumber int not null,
	AcceptedProducts int not null,
	RejectedProducts int not null,
	ElapsedTimeForManufacture decimal(6, 2) not null,
	DateOfManufacture datetime2(7) not null,
	ProductCode int not null foreign key references DimProduct(ProductCode),
	BatchNumber int not null foreign key references DimBatch(BatchNumber),
	MachineNumber int not null foreign key references DimMachine(MachineNumber),

	primary key (ManufacturingFactNumber,
				 AcceptedProducts,
				 RejectedProducts,
				 ElapsedTimeForManufacture,
				 DateOfManufacture)
)

execute AddDescriptionToTable @tableName = N'ManufacturingFact', 
							  @descrition = N'Таблиця фактів, що заповнюється з файлу системи автоматизації виробництва, що експортується'


if object_id('AddDescriptionToTable', 'P') is not null
begin
	
	drop procedure AddDescriptionToTable

end