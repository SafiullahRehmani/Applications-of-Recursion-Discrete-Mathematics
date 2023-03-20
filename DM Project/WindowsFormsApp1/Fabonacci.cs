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
    public partial class Fabonacci : Form
    {
        public Fabonacci()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = "";
                textBox2.Text = "";
                Program.fab = "";
                Program.itrfab = 0;
                Fabonacci f = new Fabonacci();
                Program pg = new Program();
                pg.FbnciDis(Convert.ToInt32(textBox1.Text));
                int fb = pg.fbnci(Convert.ToInt32(textBox1.Text));
                textBox3.Text = Program.fab;
                textBox2.Text = Convert.ToString(fb);
            }
            catch (Exception et)
            {
                MessageBox.Show(et.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
