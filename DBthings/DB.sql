use master
go

CREATE DATABASE Hospital_945
	ON
		(NAME = 'Hospital_945_Data',
		 FILENAME = 'C:\MakarovDataBase\Hospital_945_Data.mdf',
		 SIZE = 2,
		 MAXSIZE = 32,
		 FILEGROWTH = 2)
	LOG ON
		(NAME = 'Hospital_945_Log',
		 FILENAME = 'C:\MakarovDataBase\Hospital_945_Data.ldf',
		 SIZE = 2,
		 MAXSIZE = 32,
		 FILEGROWTH = 2)
GO
