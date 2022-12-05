using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalCenter
{
    public partial class Registr : MaterialForm
    {
        DBClass dbClass = new DBClass();

        public Registr()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Grey800, Primary.Green700, Accent.Green700, TextShade.WHITE);
        }

        private void Registr_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-1);
            dateTimePicker1.MinDate = DateTime.Now.AddYears(-100);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registrButton_Click(object sender, EventArgs e)
        {
            if ((passMaskedTextBox.Text.Length > 0) && (lastnameTextBox.Text.Length > 0) && (firstnameTextBox.Text.Length > 0)
                && (passwordlTextBox.Text.Length > 0) && (numberTextBox.Text.Length == 12))
            {
                try
                {
                        String patronymics;
                        String address;
                        string input = passMaskedTextBox.Text.Remove(4, 1);

                        if (patronymicsTextBox.Text == "")
                        {
                            patronymics = null;
                        } else
                        {
                            patronymics = patronymicsTextBox.Text;
                        }

                        if (addressTextBox.Text == "")
                        {
                            address = null;
                        }
                        else
                        {
                            address = patronymicsTextBox.Text;
                        }

                    dbClass.AddPatient(input, lastnameTextBox.Text, firstnameTextBox.Text, patronymics, dateTimePicker1.Value, passwordlTextBox.Text, genderComboBox.SelectedItem.ToString(), address, numberTextBox.Text);    
                    MaterialMessageBox.Show("Данные обновлены!");
                    Close();
                }
                catch (Exception)
                {
                    MaterialMessageBox.Show("Данные не обновлены, проверьте коректность данных и подключение к базе данных!");
                }
            }
        }

        private void lastnameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = lastnameTextBox.Text;
            if (Regex.IsMatch(input, @"^[А-я]+$") && input.Length >= 2)
            {
                errorProvider1.SetError(lastnameTextBox, String.Empty);
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(lastnameTextBox, "В данном поле доступны только русские буквы!");
                e.Cancel = true;
            }
        }

        private void firstnameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = firstnameTextBox.Text;
            if (Regex.IsMatch(input, @"^[А-я]+$") && input.Length >= 2)
            {
                errorProvider1.SetError(firstnameTextBox, String.Empty);
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(firstnameTextBox, "В данном поле доступны только русские буквы!");
                e.Cancel = true;
            }
        }

        private void patronymicsTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = patronymicsTextBox.Text;
            if (!Regex.IsMatch(input, @"^[А-я]+$") && patronymicsTextBox.Text.Length > 0)
            {
                patronymicsTextBox.Text = patronymicsTextBox.Text.Remove(patronymicsTextBox.Text.Length - 1);
            }
        }

        private void numberTextBox_Validating_1(object sender, CancelEventArgs e)
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

        private void passMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = passMaskedTextBox.Text.Remove(4,1);
            if (Regex.IsMatch(input, @"^[0-9]+$") && input.Length == 10)
            {
                errorProvider1.SetError(passMaskedTextBox, String.Empty);
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(passMaskedTextBox, "В данном поле доступны только цифры!");
                e.Cancel = true;
            }
        }
    }
}
