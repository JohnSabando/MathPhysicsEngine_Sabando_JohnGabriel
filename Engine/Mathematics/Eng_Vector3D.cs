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
       
        //1.b - Empty Constructor.
		
	//1.c - Non-empty Constructor.
        
        #region Class Methods
        //2.a - Magnitude of a 3D vector; DO NOT use Math.Pow()
        public double Magnitude()
        {
            return 0;
        }//end of Magnitude
		
        //2.b - Calculate the Dot Product of two 3D vectors.
        public double DotProduct(Eng_Vector3D b)
        {
            return 0;
        }//end of DotProduct
		
        //2.c – Calculate the angle between two 3D vectors.
        //      [MUST use the Functions.ToDegrees() method to return the angle in degrees]
        public double AngleBetweenVectors(Eng_Vector3D b)
        {
            return 0;
        }//end of AngleBetweenVectors
		
        //2.d – Normalize a 3D vector.
        public void Normalize()
        {
			
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
            return null;
        }//eom

	//3.b - Subtracting two 3D Vectors.
        public static Eng_Vector3D operator -(Eng_Vector3D a, Eng_Vector3D b)
        {
            return null;
        }//eom

        //3.c.1 - Multiplying a 3D vector by a scalar (s * v)
	public static Eng_Vector3D operator *(double s, Eng_Vector3D v)
        {
            return null;
        }//eom

        //3.c.2 - Multiplying a 3D vector by a scalar (v * s)
	public static Eng_Vector3D operator *(Eng_Vector3D v, double s)
        {
            return null;
        }//eom
	
	//3.d - Equality of two 3D vectors
	public static bool operator ==(Eng_Vector3D a, Eng_Vector3D b)
        {
            return true;
        }//eom

	//3.e - Inequality of two 3D vectors
        public static bool operator !=(Eng_Vector3D a, Eng_Vector3D b)
        {
            return true;
        }//eom

	//3.f - Calculate the Cross Product of two 3D vectors.
        public static Eng_Vector3D operator *(Eng_Vector3D a, Eng_Vector3D b)
        {
            return null;
        }//eom
        #endregion
    }//eoc
}//eon
