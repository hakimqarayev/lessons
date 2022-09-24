using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPart3
{
    public partial class FormControls : Form
    {
        public FormControls()
        {
            InitializeComponent();
        }



        private void clearFormBtn_Click(object sender, EventArgs e)
        {
            DialogResult resultEnum = MessageBox.Show(
                                                        "Form dəyərlərini sıfırlamaq istədiyinizdən əminsiniz?",
                                                        "Sıfırlamaq",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

            if (resultEnum == DialogResult.Yes)
            {
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox textBox = (TextBox)item;
                        textBox.Text = string.Empty;
                    }
                }

            }
            else
            {

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text) && !string.IsNullOrWhiteSpace(surnameTextBox.Text)&& !string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                Customer customer = new Customer()
                {
                    Name = nameTextBox.Text,
                    Surname = surnameTextBox.Text,
                    Email = emailTextBox.Text,
                    PhoneNumber = phoneTextBox.Text
                };
                VirtualDatabase.Customers.Add(customer);
            }
            else
                MessageBox.Show("Məlumatlar xanaları boş qala bilməz","Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            

            if (VirtualDatabase.Customers.Count > 0)
            {

                DialogResult answer = MessageBox.Show(
                                                        "Yeni müştəri əlavə olundu! Başqa müştəri əlavə etmək istəyirsiniz?",
                                                        "Məlumat",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    winNotification = new NotifyIcon();
                    winNotification.BalloonTipText = "Toplam müştəri sayısı: " + VirtualDatabase.Customers.Count();
                    winNotification.BalloonTipTitle = "Müştəri ədəd məlumatı";
                    winNotification.Visible = true;
                    winNotification.ShowBalloonTip(4000);

                    winNotification.Icon = SystemIcons.Information;
                }
                else
                {

                }
            }

        }


        private void CustomerView(object sender, EventArgs e)
        {
            UsersInfo users = new UsersInfo();
            users.ShowDialog();
        }
    }
}
