using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_2
{
    public partial class First_Custom_Control : UserControl
    {
        public First_Custom_Control()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void First_Custom_Control_Load(object sender, EventArgs e)
        {

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void confirmed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You For Using Service ");
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listitem_Click(object sender, EventArgs e)
        {
            
            OrderList.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
                OrderList.Items.Add(s);
            foreach (string s in checkedListBox2.CheckedItems)
                OrderList.Items.Add(s);
            foreach (string s in checkedListBox3.CheckedItems)
                OrderList.Items.Add(s);
            foreach (string s in checkedListBox4.CheckedItems)
                OrderList.Items.Add(s);
            foreach (string s in checkedListBox5.CheckedItems)
                OrderList.Items.Add(s);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
