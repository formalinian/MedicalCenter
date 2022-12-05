USE Hospital_945
GO

CREATE TYPE T_Rights FROM varchar(25) NOT NULL
GO
CREATE RULE R_Rights as @Right in ('Отсутствие прав','Права на запись','Права на изменение','Права на подтверждение','Полные права')
GO
EXEC sp_bindrule R_Rights, T_Rights
GO
CREATE DEFAULT NonRule as 'Отсутсвие прав'
GO
EXEC sp_bindefault NonRule, T_Rights
GO

CREATE TYPE T_SpecialityType FROM varchar(30) NOT NULL
GO
CREATE RULE R_SpecialityType as @SpecialityType in ('Врач общей практики','Врач-гастроэнтеролог',
'Врач-дерматовенеролог','Врач-инфекционист',
'Врач-кардиолог', 'Врач-колопроктолог', 'Врач-невролог', 'Врач-нефролог', 'Врач-онколог', 
'Врач-ревматолог', 'Врач-офтальмолог', 'Врач-рентгенолог', 'Врач-терапевт', 'Врач-уролог', 
'Врач-хирург', 'Врач-эндокринолог')
GO
EXEC sp_bindrule R_SpecialityType, T_SpecialityType
GO

CREATE TYPE T_Passport FROM varchar(11) NOT NULL
GO
CREATE RULE R_Passport as @Passport like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
GO
EXEC sp_bindrule R_Passport, T_Passport
GO

CREATE TYPE T_Gender FROM varchar(7) NOT NULL
GO
CREATE RULE R_Gender as @Gender in ('Мужской','Женский')
GO
EXEC sp_bindrule R_Gender, T_Gender
GO
CREATE DEFAULT DefGender as 'Мужской'
GO
EXEC sp_bindefault DefGender, T_Gender
GO

CREATE TYPE T_Status FROM varchar(10) NOT NULL
GO
CREATE RULE R_Status as @Status in ('Активный','Неактивный')
GO
EXEC sp_bindrule R_Status, T_Status
GO
CREATE DEFAULT DefStatus as 'Активный'
GO
EXEC sp_bindefault DefStatus, T_Status
GO

CREATE TYPE T_PhoneNumber FROM varchar(12) NOT NULL
GO
CREATE RULE R_PhoneNumber as @PhoneNumber like '[+][7][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
GO
EXEC sp_bindrule R_PhoneNumber, T_PhoneNumber
GO

CREATE TYPE T_IllnessType FROM varchar(30) NOT NULL
GO
CREATE RULE R_IllnessType as @IllnessType in ('Инфекционные и паразитарные болезни','Новообразования','Болезни крови','Болезни эндокринной системы','Психические растройства',
											  'Болезни нервной системы','Болезни глаза','Болезни уха','Болезни системы кровообращения','Болезни органов дыхания','Болезни органов пищеварения',
											  'Болезни кожи','Болезни костно-мышечной системы','Болезни мочеполовой системы',' Беременность, роды и послеродовой период','Врожденные аномалии')
GO
EXEC sp_bindrule R_IllnessType, T_IllnessType
GO
CREATE DEFAULT DefIllnessType as 'Неинфекционный'
GO
EXEC sp_bindefault DefIllnessType, T_IllnessType
GO

CREATE TYPE T_ServiceType FROM varchar(20) NOT NULL
GO
CREATE RULE R_ServiceType as @ServicesType in ('Профилактический','Диагностический','Консультативный', 'Лечебный', 'Реабилитационный')
GO
EXEC sp_bindrule R_ServiceType, T_ServiceType
GO

CREATE TYPE T_RecipeType FROM varchar(8) NOT NULL
GO
CREATE RULE R_RecipeType as @RecipeType in ('Обычный','Льготный')
GO
EXEC sp_bindrule R_RecipeType, T_RecipeType
GO
CREATE DEFAULT DefRecipeType as 'Обычный'
GO
EXEC sp_bindefault DefRecipeType, T_RecipeType
GO

CREATE TYPE T_RecipeDuration FROM int NOT NULL
GO
CREATE RULE R_RecipeDuration as @RecipeDuration in (30,60,180)
GO
EXEC sp_bindrule R_RecipeDuration, T_RecipeDuration
GO
CREATE DEFAULT DefRecipeDuration as 30
GO
EXEC sp_bindefault DefRecipeDuration, T_RecipeDuration
GO


CREATE TABLE Position
	(Position_code int PRIMARY KEY CHECK (Position_code > 0),
	 Job_title varchar(50) NOT NULL CHECK (Job_title not like '%[A-Z]%' and Job_title not like '%[a-z]%' and Job_title not like '%[0-9]%' and Job_title not like '%[,/.!@#$&*()]%'),
	 Rights T_Rights,
	 [Description] varchar(100))
GO

CREATE TABLE Speciality
	(Speciality_code int PRIMARY KEY CHECK (Speciality_code > 0),
	 Speciality_type T_SpecialityType,
	 [Description] varchar(100))
GO

CREATE TABLE Employee
	(Number int PRIMARY KEY,
	 Passport T_Passport UNIQUE,
	 Surname varchar(20) NOT NULL CHECK (Surname not like '%[A-Z]%' and Surname not like '%[a-z]%' and Surname not like '%[0-9]%' and Surname not like '%[,/.!@#$&*()-]%'),
	 Firstname varchar(20) NOT NULL CHECK (Firstname not like '%[A-Z]%' and Firstname not like '%[a-z]%' and Firstname not like '%[0-9]%' and Firstname not like '%[,/.!@#$&*()-]%'),
	 Patronymic varchar(20) NOT NULL CHECK (Patronymic not like '%[A-Z]%' and Patronymic not like '%[a-z]%' and Patronymic not like '%[0-9]%' and Patronymic not like '%[,/.!@#$&*()-]%'),
	 Birthday date  NOT NULL CHECK (year(Birthday)<2003),
	 Gender T_Gender,
	 Employee_address nvarchar(35),
	 Employee_status T_Status,
	 Diploma bigint UNIQUE NOT NULL CHECK (Diploma like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	 Labor bigint UNIQUE NOT NULL CHECK (Labor like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	 Pass varchar(20) NOT NULL,
	 Position_code int NOT NULL CHECK (Position_code > 0),
	 Speciality_code int CHECK (Speciality_code > 0),
	 CONSTRAINT ВК_Работник_Должность
	 FOREIGN KEY (Position_code) REFERENCES Position(Position_code) ON DELETE NO ACTION,
	 CONSTRAINT ВК_Работник_Специальность
	 FOREIGN KEY (Speciality_code) REFERENCES Speciality(Speciality_code) ON DELETE NO ACTION)
GO

CREATE TABLE Patient
	(Number int PRIMARY KEY,
	 Passport T_Passport UNIQUE,
	 Surname varchar(20) NOT NULL CHECK (Surname not like '%[A-Z]%' and Surname not like '%[a-z]%' and Surname not like '%[0-9]%' and Surname not like '%[,/.!@#$&*()-]%'),
	 Firstname varchar(20) NOT NULL CHECK (Firstname not like '%[A-Z]%' and Firstname not like '%[a-z]%' and Firstname not like '%[0-9]%' and Firstname not like '%[,/.!@#$&*()-]%'),
	 Patronymic varchar(20) CHECK (Patronymic not like '%[A-Z]%' and Patronymic not like '%[a-z]%' and Patronymic not like '%[0-9]%' and Patronymic not like '%[,/.!@#$&*()-]%'),
	 Birthday date  NOT NULL CHECK (year(Birthday)<year(GETDATE())),
	 Pass varchar(20) NOT NULL,
	 [Status] T_Status,
	 Gender T_Gender,
	 Patient_address nvarchar(35),
	 Phone_number T_PhoneNumber)
GO

CREATE TABLE Sickness_record
	(Record_number int PRIMARY KEY IDENTITY(1,1),
	 Employee_number int NOT NULL CHECK (Employee_number > 0),
	 Patient_number int NOT NULL CHECK (Patient_number > 0),
	 Sickness_type T_IllnessType,
	 [Date] date NOT NULL,
	 Diagnosis varchar(50) NOT NULL CHECK (Diagnosis not like '%[A-Z]%' and Diagnosis not like '%[a-z]%' and Diagnosis not like '%[0-9]%' and Diagnosis not like '%[,/.!@#$&*()-]%'),
	 CONSTRAINT ВК_Запись_Работник
	 FOREIGN KEY (Employee_number) REFERENCES Employee(Number) ON DELETE NO ACTION,
	 CONSTRAINT ВК_Запись_Пациет
	 FOREIGN KEY (Patient_number) REFERENCES Patient(Number) ON DELETE NO ACTION)
GO

CREATE TABLE [Service]
	(Service_code int PRIMARY KEY IDENTITY(1,1),
	 [Name] varchar(50) NOT NULL CHECK ([Name] not like '%[A-Z]%' and [Name] not like '%[a-z]%' and [Name] not like '%[0-9]%' and [Name] not like '%[,/.!@#$&*()-]%'),
	 Speciality_code int NOT NULL CHECK (Speciality_code > 0),
	 Service_type T_ServiceType,
	 Cost money,
	 CONSTRAINT ВК_Услуга_Специальность
	 FOREIGN KEY (Speciality_code) REFERENCES Speciality(Speciality_code) ON DELETE NO ACTION)
GO

CREATE TABLE Equipment_type
	(Equipment_code int CHECK (Equipment_code > 0) PRIMARY KEY,
	 [Name] varchar(50) NOT NULL CHECK ([Name] not like '%[A-Z]%' and [Name] not like '%[a-z]%' and [Name] not like '%[0-9]%' and [Name] not like '%[,/.!@#$&*()-]%'),
	 Note varchar(50))
GO

CREATE TABLE Requirement
	(Service_code int NOT NULL CHECK (Service_code > 0),
	 Equipment_code int NOT NULL CHECK (Equipment_code > 0),
	 CONSTRAINT ПК_НАЛИЧИЕ PRIMARY KEY (Service_code,Equipment_code),
	 CONSTRAINT ВК_Наличие_Услуга
	 FOREIGN KEY (Service_code) REFERENCES [Service](Service_code) ON DELETE NO ACTION,
	 CONSTRAINT ВК_Наличие_ТипОборудования
	 FOREIGN KEY (Equipment_code) REFERENCES Equipment_type(Equipment_code) ON DELETE NO ACTION)
GO

CREATE TABLE Equipment
	(Device_number int PRIMARY KEY IDENTITY(1,1),
	 Equipment_code int NOT NULL CHECK (Equipment_code > 0),
	 [Name] varchar(50) NOT NULL,
	 CONSTRAINT ВК_Оборудование_ТипОборудования
	 FOREIGN KEY (Equipment_code) REFERENCES Equipment_type(Equipment_code) ON DELETE NO ACTION)
GO

CREATE TABLE Appointment
	(Appointment_code int PRIMARY KEY IDENTITY(1,1),
	 Employee_number int NOT NULL CHECK (Employee_number > 0),
	 Patient_number int NOT NULL CHECK (Patient_number > 0),
	 Service_code int NOT NULL CHECK (Service_code > 0),
	 [Date] date NOT NULL,
	 [Time] time(0) NOT NULL,
	 Office int NOT NULL,
	 Note varchar(50),
	 CONSTRAINT ВК_Прием_Работник
	 FOREIGN KEY (Employee_number) REFERENCES Employee(Number) ON DELETE NO ACTION,
	 CONSTRAINT ВК_Прием_Пациет
	 FOREIGN KEY (Patient_number) REFERENCES Patient(Number) ON DELETE NO ACTION,
	 CONSTRAINT ВК_Прием_Услуга
	 FOREIGN KEY (Service_code) REFERENCES [Service](Service_code) ON DELETE NO ACTION)
GO

CREATE TABLE Prescription
	(Prescription_number int PRIMARY KEY IDENTITY(1,1),
	 Prescriber int NOT NULL CHECK (Prescriber > 0),
	 Checking int NOT NULL CHECK (Checking > 0),
	 Patient_number int NOT NULL CHECK (Patient_number > 0),
	 [Date] date NOT NULL,
	 Duration T_RecipeDuration,
	 [Type] T_RecipeType,
	 Medicine varchar(50) NOT NULL,
	 CONSTRAINT ВК_Рецепт_Выписывающий
	 FOREIGN KEY (Prescriber) REFERENCES Employee(Number) ON DELETE NO ACTION,
	 CONSTRAINT ВК_Рецепт_Проверяющего
	 FOREIGN KEY (Checking) REFERENCES Employee(Number) ON DELETE NO ACTION,
	 CONSTRAINT ВК_Рецепт_Пациет
	 FOREIGN KEY (Patient_number) REFERENCES Patient(Number) ON DELETE NO ACTION)
GO
