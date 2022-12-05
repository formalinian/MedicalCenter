using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter
{
    public class DBClass
    {
        public Patient GetPatient(string login)
        {
            using (var db = new HospitalModel())
            {
                return db.Patient.Where(x => x.Passport == login).FirstOrDefault();
            }
        }

        public void AddPatient(string passport, string surname, string firstname, string patronymic, DateTime birthday, string pass, string gender, string address, string phone)
        {
            try
            {
                using (HospitalModel db = new HospitalModel())
                {
                    int id = db.Patient.OrderBy(x => x.Number).Count() + 1;
                    db.Patient.Add(new Patient
                    {
                        Number = id,
                        Passport = passport,
                        Surname = surname,
                        Firstname = firstname,
                        Patronymic = patronymic,
                        Birthday = birthday,
                        Pass = pass,
                        Status = "Активный",
                        Gender = gender,
                        Patient_address = address,
                        Phone_number = phone
                    });
                    db.SaveChanges();
                }
            } catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }

        public void AddAppointment(int employeeNumber, int patientNumber, int serviceCode, DateTime dateTime, TimeSpan timeSpan, int office, string note)
        {
            try
            {
                using (HospitalModel db = new HospitalModel())
                {
                    int code = db.Appointment.OrderBy(x => x.Appointment_code).Count() + 1;
                    db.Appointment.Add(new Appointment
                    {
                        Appointment_code = code,
                        Employee_number = employeeNumber,
                        Patient_number = patientNumber,
                        Service_code = serviceCode,
                        Date = dateTime,
                        Time = timeSpan,
                        Office = office,
                        Note = note
                    });
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }

        public void RemoveAppointment(int checkCode)
        {
            using (var db = new HospitalModel())
            {
                Appointment appointment = db.Appointment.Where(x => x.Appointment_code == checkCode).First();
                db.Appointment.Remove(appointment);
                db.SaveChanges();
            }
        }

        public Speciality GetSpeciality(string speciality)
        {
            using (HospitalModel db = new HospitalModel())
            {
                return db.Speciality.Where(x => x.Speciality_type == speciality).FirstOrDefault();
            }
        }

        public Patient GetPatient(int number)
        {
            using (HospitalModel db = new HospitalModel())
            {
                return db.Patient.Where(x => x.Number == number).FirstOrDefault();
            }
        }

        public void ChangePatient(Patient patient, string pass, string address, string phone)
        {
            if (address == "")
            {
                address = null;
            }
            try
            {
                using (var db = new HospitalModel())
                {
                    patient = db.Patient.Where(x => x.Number == patient.Number).FirstOrDefault();
                    patient.Pass = pass;
                    patient.Patient_address = address;
                    patient.Phone_number = phone;
                    db.SaveChanges();
                }
            } catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }

        public void activatePatient(Patient patient)
        {
            try
            {
                using (var db = new HospitalModel())
                {
                    patient = db.Patient.Where(x => x.Number == patient.Number).FirstOrDefault();
                    patient.Status = "Активный";
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }

        public void deactivatePatient(Patient patient)
        {
            try
            {
                using (var db = new HospitalModel())
                {
                    patient = db.Patient.Where(x => x.Number == patient.Number).FirstOrDefault();
                    patient.Status = "Неактивный";
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }

        public List<Service> GetServices(Speciality spec)
        {
            using (var db = new HospitalModel())
            {
                return db.Service.Where(x => x.Speciality_code == spec.Speciality_code).ToList();
            }
        }

        public List<Employee> GetEmployees(Speciality spec)
        {
            using (var db = new HospitalModel())
            {
                return db.Employee.Where(x => (x.Speciality_code == spec.Speciality_code) && (x.Employee_status == "Активный")).ToList();
            }
        }

        public Service GetService(string typeService)
        {
            using (var db = new HospitalModel())
            {
                return db.Service.Where(x => (x.Name == typeService)).FirstOrDefault();
            }
        }

        public Employee GetEmployee(int number)
        {
            using (var db = new HospitalModel())
            {
                return db.Employee.Where(x => (x.Number == number)).FirstOrDefault();
            }
        }


    }
}
