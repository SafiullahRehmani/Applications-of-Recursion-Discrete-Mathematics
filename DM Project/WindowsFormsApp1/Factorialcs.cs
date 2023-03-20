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
    public partial class Factorialcs : Form
    {
        public Factorialcs()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Program.fct = "";
                Program.itrf = Convert.ToInt32(textBox1.Text);
                textBox2.Text = "";
                textBox3.Text = "";
                Program pg = new Program();
                Program.fct = "Recursion #"+textBox1.Text+": (0, 0): 0! = 1\r\n";
                long ft = pg.Getfact(Convert.ToInt32(textBox1.Text));
                pg.factdis(Convert.ToInt32(textBox1.Text));
                textBox2.Text = Program.fct;
                textBox3.Text = Convert.ToString(ft);
            }
            catch (Exception et)
            {
                MessageBox.Show(et.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
