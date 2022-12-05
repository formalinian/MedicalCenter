using MaterialSkin;
using MaterialSkin.Controls;
using System;
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
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Grey800, Primary.Green700, Accent.Green700, TextShade.WHITE);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void registrButton_Click(object sender, EventArgs e)
        {
            Hide();
            using (Registr form = new Registr())
            {
                form.ShowDialog();
            }
            Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Patient user = new DBClass().GetPatient(loginTextBox.Text);
                if (user != null)
                {
                    if (user.Pass==passwordlTextBox.Text)
                    {
                        Hide();
                        using (PatientForm form = new PatientForm(user))
                        {
                            form.ShowDialog();
                        }
                        Show();
                    }
                    else
                    {
                        MaterialMessageBox.Show("Введен неверный пароль");
                    }
                }
                else
                {
                    MaterialMessageBox.Show("Пользователя с такими паспортными данными не существует");
                }
            }
            catch (Exception)
            {
                MaterialMessageBox.Show("Проверьте подключение к базе данных!");
            }
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
