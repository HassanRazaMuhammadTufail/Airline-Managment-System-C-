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
    public partial class four : UserControl
    {
        public four()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                MessageBox.Show("Thank You");
            }
            else
            {
                MessageBox.Show("Please Click Terms and Conditions ");
            }
        }
    }
}
