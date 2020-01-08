using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using CLRPrj;

namespace ManagedApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Start();
        }

        private ClassCLR clr = new ClassCLR();

        private int num = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            textBox1.Text = clr.getNumber(num).ToString();

            //            Debug.WriteLine(num);

            num++;
            if(num > 100)
            {
                num = 0;
            }
        }
    }
}
