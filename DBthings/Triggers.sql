/*1----------------------------------------------------*/
CREATE TRIGGER NoDeletePrescription on Prescription
AFTER DELETE
AS	
	rollback tran
GO

DROP TRIGGER NoDeletePrescription

/*2----------------------------------------------------*/
CREATE TRIGGER UpdatePrescription on Prescription
AFTER UPDATE
AS	
	IF UPDATE(Prescriber) or UPDATE(Checking) or UPDATE(Patient_number)
	BEGIN
		rollback tran
	END
GO

UPDATE Prescription
SET Prescriber = 3
WHERE Prescription_number=1

DROP TRIGGER UpdatePrescription

/*3----------------------------------------------------*/
CREATE TRIGGER DeactivateEmployee on Employee
INSTEAD OF DELETE
AS
	DECLARE @num int
	DECLARE C1 cursor FOR SELECT Number FROM deleted
	OPEN C1
	FETCH NEXT FROM C1 INTO @num
	WHILE @@FETCH_STATUS=0
	BEGIN
		UPDATE Employee
		SET Employee_status = 'Неактивный'
		WHERE Employee.Number=@num

		FETCH NEXT FROM C1 INTO @num
	END
	CLOSE C1
	DEALLOCATE C1
GO

DROP TRIGGER DeactivateEmployee

DELETE FROM Employee WHERE Number=1 or Number=2

/*4----------------------------------------------------*/
CREATE TRIGGER AddEmployee on Employee
INSTEAD OF INSERT 
AS
	DECLARE @num int, @passport T_Passport, @surname varchar(20), @firstname varchar(20), @patronymic varchar(20), @birthday date, @gender T_Gender,@address nvarchar(35), @status T_Status, @diplom bigint, @labor bigint, @pass varchar(20), @position int, @spec int
	DECLARE C1 cursor FOR SELECT * FROM inserted
	OPEN C1
	FETCH NEXT FROM C1 INTO @num, @passport, @surname, @firstname, @patronymic, @birthday, @gender, @address, @status, @diplom, @labor, @pass, @position, @spec
	WHILE @@FETCH_STATUS=0
	BEGIN
		IF EXISTS (SELECT * FROM Position WHERE Position_code=@position)
		BEGIN
			IF EXISTS (SELECT * FROM Speciality WHERE Speciality_code=@spec) or @spec IS NULL
			BEGIN
				IF NOT EXISTS (SELECT * FROM Employee WHERE Passport=@passport)
				BEGIN
					INSERT INTO Employee
					VALUES (@num, @passport, @surname, @firstname, @patronymic, @birthday, @gender, @address, @status, @diplom, @labor, @pass, @position, @spec)
				END
				ELSE BEGIN PRINT 'Работник с такими паспортными данным уже существует' END
			END
			ElSE BEGIN PRINT 'Заданной специальности не существует' END
		END
		ELSE BEGIN PRINT 'Заданной должности не существует' END
	FETCH NEXT FROM C1 INTO @num, @passport, @surname, @firstname, @patronymic, @birthday, @gender, @address, @status, @diplom, @labor, @pass, @position, @spec
	END
	CLOSE C1
	DEALLOCATE C1
GO

DROP TRIGGER AddEmployee

INSERT INTO [Employee](Number, Passport, Surname, Firstname, Patronymic, Birthday, Gender, Employee_status, Diploma, Labor, Pass, Position_code, Speciality_code)
VALUES (5, '6121988644', 'Абрамова', 'Юлия', 'Алексеевна', '1987-05-05', 'Женский', 'Активный', 1938485647382, 7868894, '123', 1, NULL)

/*5----------------------------------------------------*/
CREATE VIEW SicknesstView 
AS
	SELECT Sickness_record.Employee_number as [Номер врача], Employee.Surname as [Фамилия врача], Sickness_record.Patient_number as [Номер пациента], Patient.Surname as [Фамилия пациента], Sickness_record.Sickness_type as [Тип заболевания], Sickness_record.[Date] as [Дата заболевания], Sickness_record.Diagnosis as [Диагноз]
	FROM Sickness_record JOIN Employee on Sickness_record.Employee_number=Employee.Number JOIN Patient on Sickness_record.Patient_number=Patient.Number
GO

CREATE VIEW AppointmentView 
AS
	SELECT Appointment.*, [Service].[Name]
	FROM Appointment INNER JOIN [Service] on Appointment.Service_code=[Service].Service_code
GO

SELECT *
FROM SicknesstView

SELECT *
FROM AppointmentView


CREATE TRIGGER AddSicknessOnView on SicknesstView
INSTEAD OF INSERT
AS
	DECLARE @employeeNum int, @employee varchar(20), @patientNum int, @patient varchar(20), @type T_IllnessType, @date date, @diagnos varchar(20)
	DECLARE C1 cursor FOR SELECT * FROM inserted
	OPEN C1
	FETCH NEXT FROM C1 INTO @employeeNum, @employee, @patientNum, @patient, @type, @date, @diagnos
	WHILE @@FETCH_STATUS=0
	BEGIN	
		IF EXISTS (SELECT * FROM Employee WHERE Number=@employeeNum and Surname=@employee)
			BEGIN
				DECLARE C2 cursor FOR SELECT * FROM inserted
				OPEN C2
				FETCH NEXT FROM C2 INTO @employeeNum, @employee, @patientNum, @patient, @type, @date, @diagnos
				WHILE @@FETCH_STATUS=0
				BEGIN
					IF EXISTS (SELECT * FROM Patient WHERE Number=@patientNum and Surname=@patient)
					BEGIN
						INSERT INTO Sickness_record(Employee_number, Patient_number, Sickness_type, [Date], Diagnosis)
						VALUES (@employeeNum, @patientNum, @type, @date, @diagnos)
					END
					ELSE BEGIN PRINT 'Заданного пациента несуществует' END
					FETCH NEXT FROM C2 INTO @employeeNum, @employee, @patientNum, @patient, @type, @date, @diagnos
				END
				CLOSE C2
				DEALLOCATE C2
			END
		ELSE BEGIN PRINT 'Заданного врача несуществует' END
		FETCH NEXT FROM C1 INTO @employeeNum, @employee, @patientNum, @patient, @type, @date, @diagnos
	END
	CLOSE C1
	DEALLOCATE C1
GO

INSERT INTO SicknesstView
VALUES (2, 'Александрова', 1,'Макаров','Болезни системы кровообращения','2022-05-05','Гипертония')

DROP TRIGGER AddSicknessOnView