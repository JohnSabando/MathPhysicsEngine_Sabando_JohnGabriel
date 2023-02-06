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
    public class Eng_Vector2D
    {
        //1.a - Properties (component form of a vector).
        public double X { get; set; }
        public double Y { get; set; }
         //1.b - Empty Constructor.
         public Eng_Vector2D()
        {
            X = 0;
            Y = 0;
        }

        //1.c - Non-empty constructor.
        public Eng_Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }
        #region Class Methods
        // 2.a - Magnitude of a 2D vector; DO NOT use Math.Pow()
        public static double Magnitude(double value1,double value2)
        {
            double magnitude;
            magnitude = Math.Sqrt((value1*value1)+(value2*value2));
            return magnitude;
        }//end of Magnitude

        //2.b - The Dot Product of two 2D vectors.
        public static double DotProduct(Eng_Vector2D b, Eng_Vector2D a)
        {
            double product = 0;
            product = (a.X * b.X) + (a.Y * b.Y);
            return product;
        }//end of DotProduct

        //2.c – The angle between two 2D vectors.
        //      [MUST use the Functions.ToDegrees() method to return the angle in degrees]
        public static double AngleBetweenVectors(Eng_Vector2D b, Eng_Vector2D a)
        {
            double angle,product,magnitude;
            product = (a.X * b.X) + (a.Y * b.Y);
            magnitude = Math.Sqrt((a.X * a.X) + (a.Y * a.Y)) * Math.Sqrt((b.X * b.X)+(b.Y * b.Y));
            angle = Math.Acos(product / magnitude);
            return Functions.ToDegrees(angle);
        }//end of AngleBetweenVectors

        //2.d – To Normalize a 2D vector.
        public static Eng_Vector2D Normalize(Eng_Vector2D a)
        {
            double length = 0;
            length = Math.Sqrt((a.X * a.X)+(a.Y * a.Y));
            Eng_Vector2D normalize = new Eng_Vector2D();
            normalize.X = (a.X / length);
            normalize.Y = (a.Y / length);
            return normalize;
	    }//end of Normalize
        #endregion

        #region Overload Operators
        #region Complier Warning Fix
        // the following two methods are to remove the CS0660 and CS0661 compiler warnings
        #pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override bool Equals(object obj)
        {
            return true;
        }//eom
	#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override int GetHashCode()
        {
            return 0;
        }//eom
        #endregion
        //Complete the following overload operators
        //3.a - Adding two 2D vectors.
	public static Eng_Vector2D operator +(Eng_Vector2D a, Eng_Vector2D b)
        {
            Eng_Vector2D result = new Eng_Vector2D();
            result.X = a.X + b.X;
            result.Y = a.Y + b.Y;
            return result;
        }//eom

	//3.b - Subtracting two 2D vectors.
        public static Eng_Vector2D operator -(Eng_Vector2D a, Eng_Vector2D b)
        {
            Eng_Vector2D result= new Eng_Vector2D();
            result.X = a.X- b.X;
            result.Y = a.Y - b.Y;
            return result;
        }//eom

        //3.c.1 - Multiplying a 2D vector by a scalar (s * v)
        public static Eng_Vector2D operator *(double s, Eng_Vector2D v)
        {
            Eng_Vector2D result = new Eng_Vector2D();
            result.X = s * v.X;
            result.Y = s * v.Y;
            return result;
        }//eom

        //3.c.2 - Multiplying a 2D vector by a scalar (v * s)
        public static Eng_Vector2D operator *(Eng_Vector2D v, double s)
        {
            Eng_Vector2D result = new Eng_Vector2D();
            result.X = v.X * s;
            result.Y = v.Y * s;
            return result;
        }//eom
        
	//3.d - Equality of two 2D vectors.
	public static bool operator ==(Eng_Vector2D a, Eng_Vector2D b)
        {
            if (a.X != b.X && a.Y == b.Y || a.X == b.X && a.Y != b.Y || a.X != b.X && a.Y != b.Y)
                return false;
            return true;
        }//eom	 

        //3.e - Inequality of two 2D vectors
        public static bool operator !=(Eng_Vector2D a, Eng_Vector2D b)
        {
            if (a.X == b.X && a.Y == b.Y)
                return false;
            return true;
        }//eom
        #endregion
    }//eoc
}//eom
