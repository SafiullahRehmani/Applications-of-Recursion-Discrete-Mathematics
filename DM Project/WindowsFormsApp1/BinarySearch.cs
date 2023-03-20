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
    public partial class BinarySearch : Form
    {
        public BinarySearch()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arr = new int[Convert.ToInt32(textBox5.Text) + 1];
                for (int i = Convert.ToInt32(textBox4.Text); i <= Convert.ToInt32(textBox5.Text); i++)
                {
                    arr[i] = i;
                }
                textBox3.Text = "";
                textBox2.Text = "";
                Program.bsr = "";
                Program.itrbsr = -1;
                BinarySearch f = new BinarySearch();
                Program pg = new Program();
                int bt = pg.bsrch(arr, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox1.Text));
                if(bt == -1)
                {
                    string det = "Number not found";
                    textBox2.Text = det;
                }
                else if(bt == -2)
                {
                    string det = "Wrong Range Entered!";
                    textBox2.Text = det;
                }
                else
                    textBox2.Text = Convert.ToString(bt) + "  Value found!";
                textBox3.Text = Program.bsr;
            }
            catch(Exception et)
            {
                MessageBox.Show(et.Message);
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BinarySearch_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
