using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tricatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string st = "three";
            try
            {
                int it = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st + " is not an integer");
            }
            string s = "3";
            string pi = "3.1459265";
            int i = int.Parse(s);
            double d = double.Parse(pi);
        }
            

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
    }
}
