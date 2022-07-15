using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void CustomerClick(object sender, EventArgs e)
        {
            Eat eat = new Eat(this);
            eat.Show();
        }

        private void EmployeeButtonClick(object sender, EventArgs e)
        {
            EmpLogin emplog = new EmpLogin(this);
            emplog.Show();
        }
    }
}
