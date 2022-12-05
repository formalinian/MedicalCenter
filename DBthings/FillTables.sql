use Hospital_945
go

INSERT INTO [Position](Position_code, Job_title, Rights, [Description])
VALUES (1, 'Главврач', 'Полные права',NULL),
	   (2, 'Врач','Полные права',NULL),
	   (3, 'Работник регистратуры','Отсутствие прав',NULL)

INSERT INTO [Speciality](Speciality_code, Speciality_type, [Description])
VALUES (1, 'Врач общей практики', NULL),
	   (2, 'Врач-гастроэнтеролог', NULL),
	   (3, 'Врач-дерматовенеролог', NULL),
	   (4, 'Врач-инфекционист', NULL),
	   (5, 'Врач-кардиолог', NULL),
	   (6, 'Врач-колопроктолог', NULL),
	   (7, 'Врач-невролог', NULL),
	   (8, 'Врач-нефролог', NULL),
	   (9, 'Врач-онколог', NULL),
	   (10, 'Врач-ревматолог', NULL),
	   (11, 'Врач-офтальмолог', NULL),
	   (12, 'Врач-рентгенолог', NULL),
	   (13, 'Врач-терапевт', NULL),
	   (14, 'Врач-уролог', NULL),
	   (15, 'Врач-хирург', NULL),
	   (16, 'Врач-эндокринолог', NULL)

INSERT INTO [Employee](Number, Passport, Surname, Firstname, Patronymic, Birthday, Gender, Employee_status, Diploma, Labor, Pass, Position_code, Speciality_code)
VALUES (1, '6121987654', 'Абрамов', 'Сергей', 'Алексеевич', '1987-05-05', 'Мужской', 'Активный', 1938475647382, 7867891, '123', 2, 1),
		(2, '6234567812', 'Александрова', 'Валерия', 'Александровна', '1987-05-05', 'Женский', 'Активный', 9504983627819, 5378493, '123', 2, 5),
		(3, '6753425616', 'Андреева', 'Виктория', 'Данииловна', '1987-05-05', 'Женский', 'Активный', 1847363829065, 1264987, '123', 2, 3)

INSERT INTO [Patient](Number, Passport, Surname, Firstname, Patronymic, Birthday, Pass, [Status], Gender, Patient_address, Phone_number)
VALUES (1, 1234123456, 'Макаров','Олег','Александрович','2001-06-05','123', 'Активный','Мужской',NULL,'+79000000000')

INSERT INTO [Service]([Name],Speciality_code,Service_type,Cost)
VALUES ('Прием врача кардиолога', 5, 'Консультативный', 1000),
		('УЗИ сердца', 5, 'Диагностический', 1500),
		('Прием врача общей практики', 1, 'Консультативный', 1000),
		('Прием врача дерматовенеролога', 3, 'Консультативный', 1000)

INSERT INTO Sickness_record(Employee_number, Patient_number, Sickness_type, [Date], Diagnosis)
VALUES (2, 1, 'Болезни системы кровообращения', '2020-05-12', 'ВСД')

INSERT INTO Prescription(Prescriber, Checking, Patient_number, [Date], Duration, [Type], Medicine)
VALUES (1, 2, 1, '2022-06-09', 30, 'Обычный', 'Атаракс')