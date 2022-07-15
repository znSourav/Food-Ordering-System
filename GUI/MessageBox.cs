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
    public partial class MessageBox : Form
    {
        Timer timer;
        int count = 0;

        public MessageBox(string message)
        {
            InitializeComponent();
            this.Message.Text = message;

            if (message.Equals("ERROR !") || message.Equals("SELECT ITEM"))
            {
                PB1.Visible = false;
                PB2.Visible = true;
            }
            else
            {
                PB1.Visible = true;
                PB2.Visible = false;
            }

            timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 2)
            {
                timer.Enabled = false;
                this.Hide();
            }
        }
    }
}
