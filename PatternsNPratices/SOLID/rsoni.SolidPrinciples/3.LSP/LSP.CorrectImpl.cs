using rsoni.SolidPrinciples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rsoni.SolidPrinciples.LSP.CorrectImpl
{
    public class LSPTest
    {
        public void SixFor2x3Rectangle()
        {
            var myRectangle = new OCP.CorrectImpl.Rectangle
            {
                Height = 2,
                Width = 3
            };
            var a = myRectangle.Area();
        }

        public void NineFor3x3Squre()
        {
            var squre = new OCP.CorrectImpl.Square
            {
                SideLength = 3
            };

            var a = squre.Area();
        }

        public void SquareAndRectangles()
        {
            var shapes = new List<OCP.CorrectImpl.Shape>
            {
                new OCP.CorrectImpl.Rectangle {
                    Height=4,
                    Width=5
                },
                new OCP.CorrectImpl.Square {
                    SideLength=3
                }
            };
            var Areas = new List<double>();
            #region 
            //both Polymorphism and OCP
            #endregion
            foreach (OCP.CorrectImpl.Shape shape in shapes)
            {
                Areas.Add(shape.Area());
            }
        }

    }
}
