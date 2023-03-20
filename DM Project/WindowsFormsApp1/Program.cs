using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static string tt = "";
        public static int itrhc = -1;

        public int Hcf(int n1, int n2)
        {
            itrhc++;
            if (n2 != 0)
            {
                tt = tt + "Recursion #" + (itrhc) + ":  " + "(" + n1 + ", " + n2 + ")";
            }

            if(n1 != 0 && n2 != 0)
            {
                tt = tt + ":  " + n1 + " = " + n2 + " + " + n1 % n2 + "" + "\r\n";
            }

            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                Program pg = new Program();
                return pg.Hcf(n2, n1 % n2);
            }
        }

        public static string fab = "";
        public static int itrfab = -1;

        public void FbnciDis(int n1)
        {
            
            int num1 = 0;
            int num2 = 1;

            for(int i = 1; i < n1; i++)
            {
                itrfab++;
                int n3 = num2 + num1;
                fab = fab + "Recursion #" + (itrfab) + ":  (" + num1 + ", " + num2 + "):  " + num1 +" + "+ num2 + " = " + n3 + "\r\n";
                num1 = num2;
                num2 = n3;
            }
        }
        public int fbnci(int n1)
        {
            if (n1 <= 2)
            {
                return 1;
            }
            else
            {
                return fbnci(n1 - 1) + fbnci(n1 - 2);
            }
        }

        public static string fct = "";
        public static string iterfct = "";
        public static int itrf = 0;

        public long factdis(int num)
        {
            long num1 = 1;
            long res = 1;

            for(int i = 2; i <= num; i++)
            {
                itrf--;
                num1 = res;
                res = res * i;
                fct = fct + "Recursion #" + (itrf) + ":  (" + num1 + ", " + i + "):  " + num1 + " * " + i + " = " + res +"\r\n";
            }
            return num1;
        }

        public long Getfact(int num)
        {
            
            if (num == 0)
            {
                return 1;
            }
            Program pg = new Program();
            return num * pg.Getfact(num - 1);
        }

        public static string pw = "";

        public int PowerDis(int n1, int n2)
        {
            int res = 0;
            int n3 = n1;
            for (int i = 0; i < n2 - 1; i++)
            {
                res = n3 * n1;
                pw = pw + "\n"+ "Recursion #" + (i + 1) + ": (" + n3 + ", " + n1 + "):  " + n3 + " * " + n1 + " = " + res + "\r\n";
                n3 = res;
            }
            return res;
        }

        public int Power(int n1, int n2)
        {
            if (n2 != 0)
            {
                Program pg = new Program();
                return (n1 * pg.Power(n1, n2 - 1));
            }
            return 1;
        }

        public static string bsr = "";
        public static int itrbsr = 0;

        public int bsrch(int[] a, int min, int max, int t)
        {
            itrbsr++;
            Program pg = new Program();
            bsr = bsr + "Recursion #" + (itrbsr+1) + ": (" + min + ", " + max +")" + ": Min = " + min + " Max = " + max + "\r\n";
            int mid = (min + max) / 2;

            if (min > max)
            {
                return -2;
            }

            if(min < a[0])
            {
                return -1;
            }

            if(max >= a.Length)
            { 
                return -1;
            }

            if(a[mid] == t)
            {
                return mid;
            }
            else if(a[mid] > t)
            {   
                return pg.bsrch(a, min, mid - 1, t);
            }
            else if (a[mid] < t)
            {
                return pg.bsrch(a, mid + 1, max, t);
            }
            else
            {
                return -1;
            }

        }
    }
}
