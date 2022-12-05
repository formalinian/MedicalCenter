use Hospital_945
go

INSERT INTO [Position](Position_code, Job_title, Rights, [Description])
VALUES (1, '��������', '������ �����',NULL),
	   (2, '����','������ �����',NULL),
	   (3, '�������� ������������','���������� ����',NULL)

INSERT INTO [Speciality](Speciality_code, Speciality_type, [Description])
VALUES (1, '���� ����� ��������', NULL),
	   (2, '����-���������������', NULL),
	   (3, '����-����������������', NULL),
	   (4, '����-������������', NULL),
	   (5, '����-���������', NULL),
	   (6, '����-�������������', NULL),
	   (7, '����-��������', NULL),
	   (8, '����-��������', NULL),
	   (9, '����-�������', NULL),
	   (10, '����-����������', NULL),
	   (11, '����-�����������', NULL),
	   (12, '����-�����������', NULL),
	   (13, '����-��������', NULL),
	   (14, '����-������', NULL),
	   (15, '����-������', NULL),
	   (16, '����-������������', NULL)

INSERT INTO [Employee](Number, Passport, Surname, Firstname, Patronymic, Birthday, Gender, Employee_status, Diploma, Labor, Pass, Position_code, Speciality_code)
VALUES (1, '6121987654', '�������', '������', '����������', '1987-05-05', '�������', '��������', 1938475647382, 7867891, '123', 2, 1),
		(2, '6234567812', '������������', '�������', '�������������', '1987-05-05', '�������', '��������', 9504983627819, 5378493, '123', 2, 5),
		(3, '6753425616', '��������', '��������', '����������', '1987-05-05', '�������', '��������', 1847363829065, 1264987, '123', 2, 3)

INSERT INTO [Patient](Number, Passport, Surname, Firstname, Patronymic, Birthday, Pass, [Status], Gender, Patient_address, Phone_number)
VALUES (1, 1234123456, '�������','����','�������������','2001-06-05','123', '��������','�������',NULL,'+79000000000')

INSERT INTO [Service]([Name],Speciality_code,Service_type,Cost)
VALUES ('����� ����� ����������', 5, '���������������', 1000),
		('��� ������', 5, '���������������', 1500),
		('����� ����� ����� ��������', 1, '���������������', 1000),
		('����� ����� �����������������', 3, '���������������', 1000)

INSERT INTO Sickness_record(Employee_number, Patient_number, Sickness_type, [Date], Diagnosis)
VALUES (2, 1, '������� ������� ��������������', '2020-05-12', '���')

INSERT INTO Prescription(Prescriber, Checking, Patient_number, [Date], Duration, [Type], Medicine)
VALUES (1, 2, 1, '2022-06-09', 30, '�������', '�������')