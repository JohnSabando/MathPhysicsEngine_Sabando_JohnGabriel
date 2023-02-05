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
    public class Eng_Vector3D
    {
        //1.a - Properties.
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        //1.b - Empty Constructor.
        public Eng_Vector3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        //1.c - Non-empty Constructor.
        public Eng_Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        #region Class Methods
        //2.a - Magnitude of a 3D vector; DO NOT use Math.Pow()
        public double Magnitude(double value1, double value2, double value3)
        {
            double magnitude;
            magnitude = Math.Sqrt((value1 * value1) + (value2 * value2) + (value3 * value3));
            return magnitude;
        }//end of Magnitude

        //2.b - Calculate the Dot Product of two 3D vectors.
        public double DotProduct(Eng_Vector3D b, Eng_Vector3D a)
        {
            double product = 0;
            product = (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z);
            return product;
        }//end of DotProduct

        //2.c – Calculate the angle between two 3D vectors.
        //      [MUST use the Functions.ToDegrees() method to return the angle in degrees]
        public double AngleBetweenVectors(Eng_Vector3D b, Eng_Vector3D a)
        {
            double angle, product, magnitude;
            product = (a.X * b.X) + (a.Y * b.Y) + (a.Z * b.Z);
            magnitude = Math.Sqrt((a.X * a.X) + (a.Y * a.Y) + (a.Z * a.Z)) * Math.Sqrt((b.X * b.X) + (b.Y * b.Y) + (b.Z * b.Z));
            angle = Math.Acos(product / magnitude);
            return Functions.ToDegrees(angle);
        }//end of AngleBetweenVectors
		
        //2.d – Normalize a 3D vector.
        public void Normalize(Eng_Vector3D a)
        {
            double length = 0;
            length = Math.Sqrt((a.X * a.X) + (a.Y * a.Y) + (a.Z * a.Z));
            Eng_Vector3D normalize = new Eng_Vector3D();
            normalize.X = (a.X / length);
            normalize.Y = (a.Y / length);
            normalize.Z = (a.Z / length);
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
        //3.a - Adding two 3D Vectors.
	    public static Eng_Vector3D operator +(Eng_Vector3D a, Eng_Vector3D b)
        {
            Eng_Vector3D result = new Eng_Vector3D();
            result.X = a.X + b.X;
            result.Y = a.Y + b.Y;
            result.Z= a.Z + b.Z;
            return result;
        }//eom

	//3.b - Subtracting two 3D Vectors.
        public static Eng_Vector3D operator -(Eng_Vector3D a, Eng_Vector3D b)
        {
            Eng_Vector3D result = new Eng_Vector3D();
            result.X = a.X - b.X;
            result.Y = a.Y - b.Y;
            result.Z = a.Z - b.Z;
            return result;
        }//eom

        //3.c.1 - Multiplying a 3D vector by a scalar (s * v)
	public static Eng_Vector3D operator *(double s, Eng_Vector3D v)
        {
            Eng_Vector3D result = new Eng_Vector3D();
            result.X = s * v.X;
            result.Y = s * v.Y;
            result.Z = s * v.Z;
            return result;
        }//eom

        //3.c.2 - Multiplying a 3D vector by a scalar (v * s)
	public static Eng_Vector3D operator *(Eng_Vector3D v, double s)
        {
            Eng_Vector3D result = new Eng_Vector3D();
            result.X = v.X * s;
            result.Y = v.Y * s;
            result.Z = v.Z * s;
            return result;
        }//eom
	
	//3.d - Equality of two 3D vectors
	public static bool operator ==(Eng_Vector3D a, Eng_Vector3D b)
        {
            if (a != b)
                return false;
            else
                return true;
        }//eom

	//3.e - Inequality of two 3D vectors
        public static bool operator !=(Eng_Vector3D a, Eng_Vector3D b)
        {
            if (a == b)
                return false;
            else
                return true;
        }//eom

	//3.f - Calculate the Cross Product of two 3D vectors.
        public static Eng_Vector3D operator *(Eng_Vector3D a, Eng_Vector3D b)
        {
            Eng_Vector3D result = new Eng_Vector3D();
            result.X = (a.Y * b.Z) - (a.Z * b.Y);
            result.Y = (a.Z * b.X) - (a.X * b.Z);
            result.Z = (a.X * b.Y) - (a.Y * b.X);
            return result;
        }//eom
        #endregion
    }//eoc
}//eon
