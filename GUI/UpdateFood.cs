using DATABASE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UpdateFood : Form
    {
        private EmpHome userHome;
        private bool flag = false;

        public UpdateFood(EmpHome userHome)
        {
            InitializeComponent();
            this.userHome = userHome;
        }

        private void BrowseClick(object sender, EventArgs e)
        {
            OpenFileDialog open_FD = new OpenFileDialog();
            open_FD.Filter = "image files |*.jpg;*.png;*.gif";
            DialogResult dialogue_result = open_FD.ShowDialog();
            if (dialogue_result == DialogResult.Cancel) return;
            PictureBX.Image = Image.FromFile(open_FD.FileName);
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(); // To convert the image to memory stream, for adding image in table
            try
            {
                PictureBX.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch
            {
                // HAHA
            }
            byte[] picture = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(picture, 0, picture.Length);

            FoodCrud CrudOps = new FoodCrud();
            bool x = CrudOps.Update(picture, FoodId.Text, FoodName.Text, FoodPrice.Text, FoodItem.Text);
            if (x)
            {
                MessageBox message = new MessageBox("DONE !");
                message.Show();
            }
            else
            {
                MessageBox message = new MessageBox("ERROR !");
                message.Show();
            }
        }

        private void BackClick(object sender, EventArgs e)
        {
            flag = false;
            userHome.Show();
            userHome.Opacity = 0.1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                if (this.Opacity <= .9)
                {
                    this.Opacity += .35;
                }
                else
                {
                    timer1.Stop();
                    userHome.Hide();
                }
            }
            else
            {
                if (userHome.Opacity <= 0.9)
                {
                    userHome.Opacity += .35;
                }
                else
                {
                    timer1.Stop();
                    this.Hide();
                }
            }
        }
    }
}
