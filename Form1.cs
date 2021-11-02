using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using area;

namespace getarea
{
    public partial class Form1 : Form
    {
        area S;
        public Form1()
        {
            InitializeComponent();
            S = new area();
        }

        private void CalcTriangleArea_Click(object sender, EventArgs e)
        {
          string st = "";
          try {
            double ar = S.Triangle3side(double.Parse(txtSideA.Text), double.Parse(txtSideB.Text), double.Parse(txtSideC.Text));
            st = Convert.ToString(ar);
          }
          catch (ArgumentException ex)
          {
            st = ex.Message;
          }
          TriangleArea.Text = "Площадь треугольника: " + st;
        }
    }
}
