/*1----------------------------------------------------*/

CREATE PROC FindEmployee (@num int)
	AS
	DECLARE @passport T_Passport, @surname varchar(20), @firstname varchar(20), @patronymic varchar(20), @status T_Status, @position varchar(50)
		SELECT @passport=Passport, @surname=Surname, @firstname=Firstname, @patronymic=Patronymic, @status=Employee_status, @position=Job_title
		FROM Employee JOIN Position on Employee.Position_code=Position.Position_code
		WHERE Number=@num

	IF EXISTS (SELECT * FROM Employee WHERE Number=@num)
		PRINT 'Серия и номер паспорта: ' + @passport + char(13) +
		'ФИО: ' + @surname + ' ' + @firstname + ' ' + @patronymic + char(13) +
		'Должность: ' + @position + char(13) +
		'Статус: ' + @status
	ELSE PRINT 'Такого работника нет!'
GO

drop proc FindEmployee
exec FindEmployee 1

/*2----------------------------------------------------*/
CREATE PROC CountActiveEmployee 
	AS 
	DECLARE @count int
		SELECT @count=COUNT(Number)
		FROM Employee
		Where Employee_status = 'Активный'
	RETURN @count
GO

DECLARE @countEmployee int
EXEC @countEmployee = CountActiveEmployee
PRINT 'Активных работников: ' + CONVERT(VARCHAR, @countEmployee)

DROP PROC CountActiveEmployee

/*3----------------------------------------------------*/
CREATE PROC CountAppointment (@num int)
	AS 
	DECLARE @count int
		SELECT @count=COUNT([Appointment_code])
		FROM Appointment
		WHERE Employee_number=@num and Appointment.[Date] = (convert(date,GETDATE()+1))
	RETURN @count
GO

DECLARE @countAppointment int
EXEC @countAppointment = CountAppointment 1
PRINT 'Записей на завтра: ' + CONVERT(VARCHAR, @countAppointment)

DROP PROC CountAppointment

/*4----------------------------------------------------*/
CREATE PROC AddEmployee (@passport T_Passport, @surname varchar(20), @firstname varchar(20), @patronymic varchar(20), @birthday date, @gender T_Gender, @diplom bigint, @labor bigint, @pass varchar(20), @position int)
	AS
	DECLARE @number int
		SELECT @number=COUNT(Number)+1
		FROM Employee

		INSERT INTO Employee 
		VALUES (@number, @passport, @surname, @firstname, @patronymic, @birthday, @gender, NULL, 'Активный', @diplom, @labor, @pass, @position, NULL)
GO

DROP PROC AddEmployee
EXEC AddEmployee 1234561234, 'Макаров', 'Михаил', 'Олегович', '2000-06-09', 'Мужской', 9813849328129, 7654567, '123', 1

/*5----------------------------------------------------*/
CREATE PROC FindPatient (@num int)
	AS
	DECLARE @passport T_Passport, @surname varchar(20), @firstname varchar(20), @patronymic varchar(20), @address nvarchar(35), @phone T_PhoneNumber
	SET @patronymic = ' '
		SELECT @passport=Patient.Passport, @surname=Patient.Surname, @firstname=Patient.Firstname, @patronymic=Patient.Patronymic, @address=Patient.Patient_address, @phone=Patient.Phone_number
		FROM Patient
		WHERE Number=@num

	SET @patronymic = ISNUll(@patronymic, ' ') 
	SET @address = ISNUll(@address, 'Не указан')

	IF EXISTS (SELECT * FROM Patient WHERE Number=@num)
		PRINT 'Серия и номер паспорта: ' + @passport + char(13) +
		'ФИО: ' + @surname + ' ' + @firstname + ' ' + @patronymic + char(13) +
		'Адрес: ' + @address +  char(13) +
		'Телефон: ' + @phone
	ELSE PRINT 'Такого пациента нет!'
GO

drop proc FindPatient
exec FindPatient 1

/*6----------------------------------------------------*/
CREATE PROC CheckAppointments (@num int)
AS
	SELECT Appointment.Appointment_code, Employee.Surname,Employee.Firstname, Employee.Patronymic, Appointment.[Date], Appointment.[Time], Appointment.Office, [Service].[Name], [Service].Cost
	FROM Appointment JOIN [Service] on Appointment.Service_code=[Service].Service_code JOIN Employee on Appointment.Employee_number=Employee.Number
	WHERE Appointment.Patient_number=@num
GO

drop proc CheckAppointments
exec CheckAppointments 1

/*7----------------------------------------------------*/
CREATE PROC CheckSicknessRecords (@num int)
AS
	SELECT Record_number, Employee.Surname, Employee.Firstname, Employee.Patronymic, Sickness_type, [Date], Diagnosis
	FROM Sickness_record JOIN Employee on Sickness_record.Employee_number=Employee.Number
	WHERE Patient_number=@num
GO

DROP PROC CheckSicknessRecords
exec CheckSicknessRecords 1

/*8----------------------------------------------------*/
CREATE PROC AddPatient (@passport T_Passport, @surname varchar(20), @firstname varchar(20), @patronymic varchar(20), @birthday date, @pass varchar(20), @gender T_Gender,@phone T_PhoneNumber)
AS
	DECLARE @number int
		SELECT @number=COUNT(Number)+1
		FROM Patient

		INSERT INTO Patient 
		VALUES (@number, @passport, @surname, @firstname, @patronymic, @birthday, @pass, 'Активный', @gender, NULL, @phone)
GO

DROP PROC AddPatient
exec AddPatient '6111111111', 'Леонов', 'Михаил', NULL, '2002-05-05', '123', 'Женский', '+79109990909'

/*9----------------------------------------------------*/
CREATE PROC ActivePatients
AS
	SELECT Passport, Surname, Firstname, Patronymic, Phone_number
	FROM Patient
	WHERE Status = 'Активный'
GO

EXEC ActivePatients