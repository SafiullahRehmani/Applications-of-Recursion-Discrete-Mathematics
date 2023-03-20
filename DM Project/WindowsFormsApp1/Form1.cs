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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factorialcs ff = new Factorialcs();
            ff.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fabonacci f = new Fabonacci();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Power pf = new Power();
            pf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GCD g = new GCD();
            g.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BinarySearch bin = new BinarySearch();
            bin.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
