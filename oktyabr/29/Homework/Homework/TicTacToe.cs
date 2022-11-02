using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class TicTacToe : Form
    {
        bool X;
        bool O;
        int clickCount = 0;

        public TicTacToe()
        {
            InitializeComponent();
        }

        public void XWin()
        {
            // ÜFÜQİ
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                MessageBox.Show("Təbriklər X qazandı!!!", "QAZANAN");
            }

            else if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                MessageBox.Show("Təbriklər X qazandı!!!", "QAZANAN");
            }

            else if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("Təbriklər X qazandı!!!", "QAZANAN");
            }

            //ŞAQULİ
            else if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                MessageBox.Show("Təbriklər X qazandı!!!", "QAZANAN");
            }

            else if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                MessageBox.Show("Təbriklər X qazandı!!!", "QAZANAN");
            }

            else if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("Təbriklər X qazandı!!!", "QAZANAN");
            }

            //ÇARPAZ
            else if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("Təbriklər X qazandı!!!", "QAZANAN");
            }

            else if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                MessageBox.Show("Təbriklər X qazandı!!!", "QAZANAN");
            }

        }

        public void OWin()
        {
            // ÜFÜQİ
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                MessageBox.Show("Təbriklər O qazandı!!!", "QAZANAN");
            }

            else if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                MessageBox.Show("Təbriklər O qazandı!!!", "QAZANAN");
            }

            else if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Təbriklər O qazandı!!!", "QAZANAN");
            }

            //ŞAQULİ
            else if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                MessageBox.Show("Təbriklər O qazandı!!!", "QAZANAN");
            }

            else if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                MessageBox.Show("Təbriklər O qazandı!!!", "QAZANAN");
            }

            else if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Təbriklər O qazandı!!!", "QAZANAN");
            }

            //ÇARPAZ
            else if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Təbriklər O qazandı!!!", "QAZANAN");
            }

            else if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                MessageBox.Show("Təbriklər O qazandı!!!", "QAZANAN");
            }

        }



        private void ClickButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;// click olunan her buttonu b deyiseni adi altinda saxlayacaq.
            clickCount++;

            if (X)
            {
                X = false;
                O = true;
                // Eger X'in sirasidirsa X false, O true olsun.
                b.Text = "X";
                b.BackColor = Color.RoyalBlue;
                b.Enabled = false;
                XWin();

                if (clickCount == 9 && X != true)
                {
                    MessageBox.Show("Bərabərlik", "Nəticə");
                }
            }
            else if (O)
            {
                O = false;
                X = true;
                b.Text = "Y";
                b.BackColor = Color.Firebrick;
                b.Enabled = false;
                OWin();
            }

        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            X = true;// ilk X'in sirasi olacaq, yeni ilk baslayan X olacaq
        }
    }
}
