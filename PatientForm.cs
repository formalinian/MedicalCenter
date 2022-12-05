using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalCenter
{
    public partial class PatientForm : MaterialForm
    {

        private Patient patient;
        private Speciality spec;
        private List<Service> services;
        private Service service;
        private List<Employee> workers;
        private Employee worker;
        private Appointment appointment;
        private DateTime dateTime;
        private TimeSpan timeSpan;
        private DBClass dbClass = new DBClass();
        private string fullNameString;

        public PatientForm(Patient user)
        {
            InitializeComponent();
            patient = user;
            fullNameString = user.Surname.ToString() + " " + user.Firstname.ToString();
            if (!(user.Patronymic == null))
            {
                fullNameString = fullNameString + " " + user.Patronymic.ToString();
            }
            string helloString = "Добро пожаловать: " + fullNameString + "!";
            helloLabel.Text = helloString;
            fillTicketsList();
            fillSicknessList();
            refreshPersonalData();
            checkActive();
        }

        private void checkActive()
        {
            if (patient.Status == "Активный")
            {
                deactivateButton.Enabled = true;
            } else deactivateButton.Enabled = false;
            if (patient.Status == "Неактивный")
            {
                activateButton.Enabled = true;
            } else activateButton.Enabled = false;
        }

        private void refreshPersonalData()
        {
            passportTextBox.Text = patient.Passport;
            fullnamelTextBox.Text = fullNameString;
            birthTextBox.Text = patient.Birthday.ToShortDateString();
            passTextBox.Text = patient.Pass;
            addressTextBox.Text = patient.Patient_address;
            numberTextBox.Text = patient.Phone_number;
        } 

        private void fillTicketsList()
        {
            ticketListView.Items.Clear();
            using (var db = new HospitalModel())
            {
                var tickets = from ticket in db.Appointment
                              select new
                              {
                                  ticket.Patient_number,
                                  ticket.Appointment_code,
                                  Worker = ticket.Employee.Surname + " " + ticket.Employee.Firstname + " " + ticket.Employee.Patronymic,
                                  ticket.Date,
                                  ticket.Time,
                                  ticket.Office,
                                  Service = ticket.Service.Name,
                                  Cost = ticket.Service.Cost
                              };

                foreach (var ticket in tickets)
                {
                    if (ticket.Patient_number == patient.Number)
                    {
                        ListViewItem item = new ListViewItem(ticket.Appointment_code.ToString());
                        item.SubItems.Add(ticket.Worker);
                        item.SubItems.Add(ticket.Date.ToShortDateString());
                        item.SubItems.Add(ticket.Time.ToString());
                        item.SubItems.Add(ticket.Office.ToString());
                        item.SubItems.Add(ticket.Service.ToString());
                        item.SubItems.Add(ticket.Cost.ToString());
                        ticketListView.Items.Add(item);
                    }
                }
            }
        }

        private void fillSicknessList()
        {
            sicknessListView.Items.Clear();
            using (var db = new HospitalModel())
            {
                var sickness = from sick in db.Sickness_record
                              select new
                              {
                                  sick.Patient_number,
                                  sick.Record_number,
                                  Worker = sick.Employee.Surname + " " + sick.Employee.Firstname + " " + sick.Employee.Patronymic,
                                  sick.Sickness_type,
                                  sick.Date,
                                  sick.Diagnosis
                              };

                foreach (var sick in sickness)
                {
                    if (sick.Patient_number == patient.Number)
                    {
                        ListViewItem item = new ListViewItem(sick.Record_number.ToString());
                        item.SubItems.Add(sick.Worker);
                        item.SubItems.Add(sick.Sickness_type);
                        item.SubItems.Add(sick.Date.ToShortDateString());
                        item.SubItems.Add(sick.Diagnosis);
                        sicknessListView.Items.Add(item);
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void appointmentButton_Click(object sender, EventArgs e)
        {
            menuTabControl.SelectedTab = menuTabControl.TabPages[1];
        }

        private void ticketButton_Click(object sender, EventArgs e)
        {
            menuTabControl.SelectedTab = menuTabControl.TabPages[2];
        }

        private void recordsButton_Click(object sender, EventArgs e)
        {
            menuTabControl.SelectedTab = menuTabControl.TabPages[3];
        }

        private void dataButton_Click(object sender, EventArgs e)
        {
            menuTabControl.SelectedTab = menuTabControl.TabPages[4];
        }

        private void specialityComboBox_Leave(object sender, EventArgs e)
        {
            spec = dbClass.GetSpeciality(specialityComboBox.Text);

            if (spec != null) {
                services = dbClass.GetServices(spec);

                foreach (Service service in services)
                {
                    typeServiceComboBox.Items.Add(service.Name);
                }
            }
        }

        private void specialityComboBox_Enter(object sender, EventArgs e)
        {
            typeServiceComboBox.Items.Clear();
            typeServiceComboBox.ResetText();
            docktorComboBox.Items.Clear();
            docktorComboBox.ResetText();
            timeComboBox.Items.Clear();
            timeComboBox.ResetText();
            timeComboBox.Enabled = false;
            costLabel.Text = "Цена: ";
            parlorLabel.Text = "Кабинет: ";
        }

        private void typeServiceComboBox_Leave(object sender, EventArgs e)
        {
            if (spec != null)
            {
                workers = dbClass.GetEmployees(spec);
                service = dbClass.GetService(typeServiceComboBox.Text);
                if (service != null)
                {
                    string cost = service.Cost.ToString();
                    for (int i = 0; i < 5; i++)
                    {
                        cost = cost.Remove(cost.Length - 1);
                    }
                    costLabel.Text = "Цена: " + cost + " рублей";
                }

                foreach (Employee worker in workers)
                {
                    string fullName =worker.Number + ") " + worker.Surname + " " + worker.Firstname + " " + worker.Patronymic;
                    docktorComboBox.Items.Add(fullName);
                }
            }
        }

        private void typeServiceComboBox_Enter(object sender, EventArgs e)
        {
            docktorComboBox.Items.Clear();
            docktorComboBox.ResetText();
            timeComboBox.Items.Clear();
            timeComboBox.ResetText();
            timeComboBox.Enabled = false;
            parlorLabel.Text = "Кабинет: ";
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            monthCalendar.MaxDate = DateTime.Parse(DateTime.Now.AddDays(14).ToShortDateString());
            monthCalendar.MinDate = DateTime.Parse(DateTime.Now.AddDays(1).ToShortDateString());
            if (monthCalendar.SelectionStart.DayOfWeek == DayOfWeek.Sunday)
            {
                monthCalendar.SelectionStart = monthCalendar.SelectionStart.AddDays(1);
            }
            if (monthCalendar.SelectionStart.DayOfWeek == DayOfWeek.Saturday)
            {
                monthCalendar.SelectionStart = monthCalendar.SelectionStart.AddDays(2);
            }
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar.SelectionStart == monthCalendar.MinDate)
            {
                if (monthCalendar.SelectionStart.DayOfWeek == DayOfWeek.Saturday)
                {
                    monthCalendar.SelectionStart = monthCalendar.SelectionStart.AddDays(2);
                }
                if (monthCalendar.SelectionStart.DayOfWeek == DayOfWeek.Sunday)
                {
                    monthCalendar.SelectionStart = monthCalendar.SelectionStart.AddDays(1);
                }
            }
            else
            {
                if (monthCalendar.SelectionStart.DayOfWeek == DayOfWeek.Sunday)
                {
                    if (monthCalendar.MinDate.DayOfWeek == DayOfWeek.Saturday)
                    {
                        monthCalendar.SelectionStart = monthCalendar.SelectionStart.AddDays(1);
                    }
                    else { monthCalendar.SelectionStart = monthCalendar.SelectionStart.AddDays(-1); }
                }
                if ((monthCalendar.SelectionStart.DayOfWeek == DayOfWeek.Saturday) && (monthCalendar.SelectionStart != monthCalendar.MinDate))
                {
                    if (monthCalendar.SelectionStart != monthCalendar.MinDate.AddDays(1))
                    {
                        monthCalendar.SelectionStart = monthCalendar.SelectionStart.AddDays(-1);
                    }
                    else { monthCalendar.SelectionStart = monthCalendar.SelectionStart.AddDays(2); }
                }
            }

            timeComboBox.Items.Clear();
            timeComboBox.ResetText();
        }

        private void docktorComboBox_Enter(object sender, EventArgs e)
        {
            timeComboBox.Items.Clear();
            timeComboBox.ResetText();
            timeComboBox.Enabled = false;
        }

        private void docktorComboBox_Leave(object sender, EventArgs e)
        {
            string fullName = docktorComboBox.Text;
            if (!String.IsNullOrEmpty(fullName))
            {
                string[] dividedFullName = fullName.Split(')');
                int number = Int32.Parse(dividedFullName[0]);
                worker = dbClass.GetEmployee(number);
                if (worker != null)
                {
                    parlorLabel.Text = "Кабинет: " + worker.Number.ToString();
                }
            }
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if ((spec != null) && (worker != null))
            {
                using (var db = new HospitalModel())
                {
                    for (int i = 9; i <= 16; i++)
                    {
                        for (int j = 0; j <= 30; j += 30)
                        {
                            dateTime = monthCalendar.SelectionStart;
                            timeSpan = new TimeSpan(i, j, 0);
                            if ((appointment = db.Appointment.Where(x =>
                                                                (x.Date == dateTime) &&
                                                                (x.Time == timeSpan) &&
                                                                (x.Employee_number == worker.Number)).FirstOrDefault()) == null)
                            {
                                timeComboBox.Items.Add(timeSpan.ToString());
                            }
                        }
                    }
                }
            }

            if ((!String.IsNullOrEmpty(specialityComboBox.Text)) && (!String.IsNullOrEmpty(typeServiceComboBox.Text)) && (!String.IsNullOrEmpty(docktorComboBox.Text)))
            {
                timeComboBox.Enabled = true;
            }
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            if (patient.Status != "Активный")
            {
                MaterialMessageBox.Show("Ваш аккаунт имеет статус: Неактивный!");
            }
            else
            {
                if (!String.IsNullOrEmpty(timeComboBox.Text))
                {
                    timeSpan = TimeSpan.Parse(timeComboBox.Text);
                    service = dbClass.GetService(typeServiceComboBox.Text);
                    try
                    {
                        dbClass.AddAppointment(worker.Number, patient.Number, service.Service_code, dateTime, timeSpan, worker.Number, noteMultiLineTextBox.Text.ToString());
                        MaterialMessageBox.Show("Вы записаны на прием!");
                        menuTabControl.SelectedTab = menuTabControl.TabPages[0];
                        fillTicketsList();
                    }
                    catch (Exception)
                    {
                        MaterialMessageBox.Show("Записаться на прием не удалось, попробуйте еще раз!");
                    }
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            menuTabControl.SelectedTab = menuTabControl.TabPages[0];
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            if (ticketListView.SelectedItems.Count > 0)
            {
                var i = ticketListView.SelectedItems[0].Index;
                var checkCode = Int32.Parse(ticketListView.Items[i].Text);
                
                DialogResult result = MaterialMessageBox.Show("Вы уверены, что хотите выписаться?",
                    "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dbClass.RemoveAppointment(checkCode);
                }
                fillTicketsList();
            }
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            fillTicketsList();
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            menuTabControl.SelectedTab = menuTabControl.TabPages[0];
        }

        private void backButton3_Click(object sender, EventArgs e)
        {
            menuTabControl.SelectedTab = menuTabControl.TabPages[0];
        }

        private void fillIncButton_Click(object sender, EventArgs e)
        {
            fillSicknessList();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MaterialMessageBox.Show("Вы уверены, что хотите изменить данные?",
                    "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dbClass.ChangePatient(patient, passTextBox.Text, addressTextBox.Text, numberTextBox.Text);
                    MessageBox.Show("Данные обновлены!", "Обновлено", MessageBoxButtons.OK);
                    patient = dbClass.GetPatient(patient.Number);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK);
                }
            }
            refreshPersonalData();
        }

        private void numberTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = numberTextBox.Text;
            if (input.Length == 12)
            {
                errorProvider1.SetError(numberTextBox, String.Empty);
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(numberTextBox, "Введите номер полностью!");
                e.Cancel = true;
            }
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MaterialMessageBox.Show("Вы уверены, что хотите активировать аккаунт?",
                    "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dbClass.activatePatient(patient);
                    MessageBox.Show("Аккаунт активирован!", "Обновлено", MessageBoxButtons.OK);
                    patient = dbClass.GetPatient(patient.Number);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в активации!", "Ошибка", MessageBoxButtons.OK);
                }
            }
            refreshPersonalData();
            checkActive();
        }

        private void deactivateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MaterialMessageBox.Show("Вы уверены, что хотите деактивировать аккаунт?",
                    "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dbClass.deactivatePatient(patient);
                    MessageBox.Show("Аккаунт деактивирован!", "Обновлено", MessageBoxButtons.OK);
                    patient = dbClass.GetPatient(patient.Number);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в деактивации!", "Ошибка", MessageBoxButtons.OK);
                }
            }
            refreshPersonalData();
            checkActive();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            fiveButton.Text = "СПАСИБО!";
        }
    }
}
