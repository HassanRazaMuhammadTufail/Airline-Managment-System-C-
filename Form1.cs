using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

            firstCustomControl1.BringToFront();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {


        }
        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            first_Custom_Control1.BringToFront();
           
        }

        private void first_Custom_Control1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            
            thirdCustomControl1.BringToFront();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void first_Custom_Control1_Load_1(object sender, EventArgs e)
        {

        }

        private void thirdCustomControl1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;

            four1.BringToFront();

        }
    }
}
