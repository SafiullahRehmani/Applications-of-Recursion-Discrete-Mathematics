using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Power : Form
    {
        public Power()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Program pt = new Program();
                textBox4.Text = "";
                textBox2.Text = "";
                Program.pw = "";
                pt.PowerDis(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox1.Text));
                int pr = pt.Power(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox1.Text));
                textBox4.Text = Program.pw;
                textBox2.Text = Convert.ToString(pr);
            }
            catch (Exception et)
            {
                MessageBox.Show(et.Message);
            }
        }
    }
}
