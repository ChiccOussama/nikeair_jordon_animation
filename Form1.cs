using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nikeair_Jordan_Animation_c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            gunaTransition1.HideSync(gunaPictureBox_p);
            gunaPictureBox_p.Image = ((GunaPictureBox)sender).Image;
            gunaTransition1.ShowSync(gunaPictureBox_p);
        }
    }
}
