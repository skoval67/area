using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace getarea
{
  public partial class Form1
  { 
    public double Triangle3side(double side_a, double side_b, double side_c)
    {
      if ( side_a + side_b < side_c || side_a + side_c < side_b || side_b + side_c < side_a )
        throw new ArgumentException("Сумма любых двух сторон треугольника должна быть не меньше третьей");
      double p = (side_a + side_b + side_c) / 2;
      return Math.Sqrt(p * (p - side_a) * (p - side_b) * (p - side_c));
    }

    public double Circle(double r)
    {
      return Math.PI * Math.Pow(r, 2);
    }
  }
}
