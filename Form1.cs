using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace getarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcTriangleArea_Click(object sender, EventArgs e)
        {
          string st = "";
          
          try {
            double ar = Triangle3side(double.Parse(txtSideA.Text), double.Parse(txtSideB.Text), double.Parse(txtSideC.Text));
            st = Convert.ToString(ar);
          }
          catch (Exception ex) when (ex is ArgumentException || ex is FormatException)
          {
            st = ex.Message;
          }
          
          TriangleArea.Text = "Площадь треугольника: " + st;
        }

        private void txtSideA_KeyPress(object sender, KeyPressEventArgs e)
        {
          char number = e.KeyChar;
          if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
          {
             e.Handled = true;
          }
        }

        private void txtSideB_KeyPress(object sender, KeyPressEventArgs e)
        {
          char number = e.KeyChar;
          if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
          {
            e.Handled = true;
          }
        }

        private void txtSideC_KeyPress(object sender, KeyPressEventArgs e)
        {
          char number = e.KeyChar;
          if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
          {
            e.Handled = true;
          }
        }
    }
}
