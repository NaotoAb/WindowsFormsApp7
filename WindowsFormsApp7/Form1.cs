using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int a = -5;
            //if (a < 0) a = a * -1;
            int a = -5;
            a = 絶対値(a);
            MessageBox.Show(a.ToString());

            int b = -10;
            b = 絶対値(b);
            MessageBox.Show(b.ToString());  

        }
        private int 絶対値 (int value)
        {
            if(value < 0)
            {
                value = value * (-1);   //絶対値を求める
            }
                return value;
        }
      
     
    }
}
