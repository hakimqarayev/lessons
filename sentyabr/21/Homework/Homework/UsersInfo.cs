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
    public partial class UsersInfo : Form
    {
        public UsersInfo()
        {
            InitializeComponent();
        }

        private void UsersInfo_Load(object sender, EventArgs e)
        {
            customerslist.DataSource = VirtualDatabase.Customers;
        }
    }
}
