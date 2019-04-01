using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rsoni.SolidPrinciples.OCP.WrongImpl
{
 
    #region  1st senario
    public class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
    }
    public class AreaCalculator
    {
        public double TotalArea(Rectangle[] arrRectangles)
        {
            double area = 0;
            foreach (var objRectangle in arrRectangles)
            {
                area += objRectangle.Height * objRectangle.Width;
            }
            return area;
        }
    }
    #endregion

    #region  2nd senario
    public class Circle
    {
        public double Radius { get; set; }
    }
    public class AreaCalculator1
    {
        public double TotalArea(object[] arrObjects)
        {
            double area = 0;
            Rectangle objRectangle;
            Circle objCircle;
            foreach (var obj in arrObjects)
            {
                if (obj is Rectangle)
                {
                    objRectangle = (Rectangle)obj;
                    area += objRectangle.Height * objRectangle.Width;
                }
                else
                {
                    objCircle = (Circle)obj;
                    area += objCircle.Radius * objCircle.Radius * Math.PI;
                }
            }
            return area;
        }
    }
    #endregion

}
