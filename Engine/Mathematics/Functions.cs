/*
Add this file to your Mathematics folder of the Engine project!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Mathematics
{
    public class Functions
    {
        /*
            This class DOES NOT have any Properties or Constructors!
        */
        #region Class Variabbles
        private static double pi = Math.PI;
        #endregion

        #region Methods for later use (reserved for Lab 3)

        #endregion

        #region General Math
        // Complete the following methods
        //1.a - A method to convert degrees to radians
        public static double ToRadians(double degrees)
        {
            double radians = degrees * (pi / 180);
            return radians;
        }//eom

        //1.b - A method to convert radians to degrees
        public static double ToDegrees(double radians)
        {
            double degree = (180 / pi) * radians;
            return degree;
        }//eom
        #endregion

        #region Solve Right Triangles
        // Complete the following methods
        //1.c - A method to solve a right triangle given an angle in degrees and the hypotenuse;
	//      returns a Tuple<double, double> for the missing sides (adjacent, opposite).
        public static Tuple<double,double> CalculateAdjacentOpposite(double theta, double hypotenuse)
        {
            double adjacent, opposite;
            adjacent = Math.Cos(theta) * hypotenuse;
            opposite = Math.Sin(theta) * hypotenuse;
            return new Tuple<double, double>(adjacent, opposite);
        }//eom
        
        //1.d – A method to solve a right triangle given an angle in degrees and the side opposite;
	//      returns a Tuple<double, double> for the missing sides (adjacent, hypotenuse).
         public static Tuple<double, double> CalculateAdjacentHypotenuse(double theta, double opposite)
        {
            double hypotenuse,adjacent;
            hypotenuse = opposite / Math.Sin(theta);
            adjacent = opposite / Math.Tan(theta);
            return new Tuple<double, double>(adjacent, hypotenuse);
        }//eom

        //1.e – A method to solve a right triangle given an angle in degrees and the side adjacent;
	//      returns a Tuple<double, double> for the missing sides (opposite, hypotenuse).
        public static Tuple<double, double> CalculateOppositeHypotenuse(double theta, double adjacent)
        {
            double opposite, hypotenuse;
            opposite = Math.Tan(theta) * adjacent;
            hypotenuse = adjacent/ Math.Cos(theta);
            return new Tuple<double, double>(opposite, hypotenuse);
        }//eom

        //1.f – A method to solve a right triangle given side opposite and side adjacent;
	//      returns a Tuple<double, double> for the missing side and the angle in degrees.
        public static Tuple<double, double> CalculateHypotenuseTheta(double opposite, double adjacent)
        {
            double hypotenuse, degrees;
            hypotenuse = Math.Sqrt((opposite * opposite) + (adjacent * adjacent));
            degrees = Math.Atan(opposite / adjacent);
            return new Tuple<double, double>(hypotenuse, degrees);
        }//eom

        //1.g – A method to solve a right triangle given side opposite and hypotenuse;
	//      returns a Tuple<double, double> for the missing side and the angle in degrees.
        public static Tuple<double, double> CalculateAdjacentTheta(double opposite, double hypotenuse)
        {
            double adjacent, degrees;
            adjacent = Math.Sqrt((hypotenuse * hypotenuse) - (opposite * opposite));
            degrees = Math.Asin(opposite / hypotenuse);
            return new Tuple<double, double>(adjacent, degrees);
        }//eom

        //1.h – A method to solve a right triangle given side adjacent and hypotenuse;
	//      returns a Tuple<double, double> for the missing side and the angle in degrees.
        public static Tuple<double, double> CalculateOppositeTheta(double adjacent, double hypotenuse)
        {
            double opposite, degrees;
            opposite = Math.Sqrt((hypotenuse * hypotenuse) - (adjacent * adjacent));
            degrees = Math.Acos(adjacent / hypotenuse);
            return new Tuple<double, double>(opposite, degrees);
        }//eom
        #endregion

        #region More math functions (reserved for Lab 4)

        #endregion
    }//eoc
}//eon
