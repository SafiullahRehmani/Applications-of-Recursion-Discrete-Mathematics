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
    public partial class GCD : Form
    {
        public GCD()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = "";
                textBox4.Text = "";
                Program.tt = "";
                Program.itrhc = 0;
                GCD f = new GCD();
                Program pg = new Program();
                int gcd = pg.Hcf(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                textBox4.Text = Program.tt;
                textBox3.Text = Convert.ToString(gcd);
            }
            catch (Exception et)
            {
                MessageBox.Show(et.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
