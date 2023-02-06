/*
Add this file to your Lab1 folder of the Engine.Tests project!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using NUnit.Framework;
using Engine.Mathematics;
#endregion

namespace Engine.Tests.Lab1
{
    [TestFixture]
    public class Lab1Vector3Tester
    {
        // Part 3 - 3D Vectors
        //4.a - Test 2.a - Magnitude of a 3D vector.
        [Test,
            // 1st - 3rd = vector
            // 4th = expected magnitude
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(3, -4, 8, 9.4340),
            // Student Data - MUST CHANGE
            TestCase(5, 6, 7, 10.4881)
        ]

        public void TestMagnitude(double x, double y, double z, double expected)
        {
            // Create Object(s) for the test
            Eng_Vector3D a = new Eng_Vector3D(x, y, z);
            // Perform the test
            double actual = a.Magnitude();
            // Assert
            Assert.AreEqual(expected, Math.Round(actual, 4));
        }//end of TestMagnitude

        //4.b - Test 2.b - Calculate the Dot Product of two 3D vectors.
        [Test,
            // 1st - 3rd = vector a
            // 4th - 6th = vector b
            // 7th = expected dot product
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(3, -4, 8, -2, 5, 4, 6),
            // Student Data - MUST CHANGE
            TestCase(4, 5, 6, 7, 5, 4, 77)
        ]

        public void TestDotProduct(double ax, double ay, double az, double bx, double by, double bz, double expected)
        {
            // Create Object(s) for the test
            Eng_Vector3D a = new Eng_Vector3D(ax, ay, az);
            Eng_Vector3D b = new Eng_Vector3D(bx, by, bz);
            // Perform the test
            double actual = a.DotProduct(b);
            // Assert
            Assert.AreEqual(expected, actual);
        }//end of TestDotProduct

        //4.c - Test 2.c - Calculate the angle between two 3D vectors.
        [Test,
            // 1st - 3rd = vector a
            // 4th - 6th = vector b
            // 7th = expected angle between in degrees
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(-3, 4, 7, -5, 3, 4, 25.2850),
            // Student Data - MUST CHANGE
            TestCase(8, 5, 9, -2, -3, -8, 154.1921)
        ]

        public void TestAngleBetweenVectors(double ax, double ay, double az, double bx, double by, double bz, double expected)
        {
            // Create Object(s) for the test
            Eng_Vector3D a = new Eng_Vector3D(ax, ay, az);
            Eng_Vector3D b = new Eng_Vector3D(bx, by, bz);
            // Perform the test
            double actual = a.AngleBetweenVectors(b);
            // Assert
            Assert.AreEqual(expected, Math.Round(actual, 4));
        }//end of TestAngleBetweenVectors

        //4.d - Test 2.d - Normalize a 3D vector.
        [Test,
            // 1st = vector x component
            // 2nd = vector y component
            // 3rd = vector z component
            // 4th = expected x component
            // 5th = expected y component
            // 6th = expected z component
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(2, 5, -6, 0.2481, 0.6202, -0.7442),
            // Student Data - MUST CHANGE
            TestCase(6, 1, -3, 0.8847, 0.1474, -0.4423)
        ]
        public void TestNormalize(double vX, double vY, double vZ, double expectedX, double expectedY, double expectedZ)
        {
            // Create object(s) for the test
            Eng_Vector3D actual = new Eng_Vector3D(vX, vY, vZ);
            // Perform the test
            Eng_Vector3D expected = new Eng_Vector3D(expectedX, expectedY, expectedZ);
            actual.Normalize();
            // Assert
            Assert.AreEqual(expectedX, Math.Round(actual.X, 4));
            Assert.AreEqual(expectedY, Math.Round(actual.Y, 4));
            Assert.AreEqual(expectedZ, Math.Round(actual.Z, 4));
        }//end of TestNormalize

        //4.e - Test 3.a - Adding two 3D vectors.
        //    - Test 3.b - Subtracting two 3D vectors.
        [Test,
             //  1st = vector a x component
             //  2nd = vector a y component
             //  3rd = vector a z component
             //  4th = vector b x component
             //  5th = vector b y component
             //  6th = vector b z component
             //  7th = expected a+b x component
             //  8th = expected a+b y component
             //  9th = expected a+b z component
             // 10th = expected a-b x component
             // 11th = expected a-b y component
             // 12th = expected a-b z component
             // Instructor Data - MUST NOT DELETE OR MODIFY
             TestCase(3, 4, -6, 6, -9, 4, 9, -5, -2, -3, 13, -10),
             // Student Data - MUST CHANGE
             TestCase(4, 5, 7, 8, -4, -6, 12, 1, 1, -4, 9, 13)
         ]
        public void TestAddsubtract(
             double aX, double aY, double aZ, double bX, double bY, double bZ,
             double expectedAddX, double expectedAddY, double expectedAddZ,
             double expectedSubX, double expectedSubY, double expectedSubZ
             )
        {
            // Create Object(s) for the the test
            Eng_Vector3D a = new Eng_Vector3D(aX, aY, aZ);
            Eng_Vector3D b = new Eng_Vector3D(bX, bY, bZ);
            // Perform the test
            Eng_Vector3D actual = a + b;
            Eng_Vector3D actual2 = a - b;
            // Assert
            Assert.AreEqual(expectedAddX, Math.Round(actual.X, 4));
            Assert.AreEqual(expectedAddY, Math.Round(actual.Y, 4));
            Assert.AreEqual(expectedAddZ, Math.Round(actual.Z, 4));
            Assert.AreEqual(expectedSubX, Math.Round(actual2.X, 4));
            Assert.AreEqual(expectedSubY, Math.Round(actual2.Y, 4));
            Assert.AreEqual(expectedSubZ, Math.Round(actual2.Z, 4));
        }//end of TestAddsubtract

        //4.f - Test 3.c.1 & 3.c.2 - Multiplying a 3D vector by a scalar.
        [Test,
            // 1st - 3rd = vector a
            // 4th = scale factor
            // 5th - 7th = expected scaled vector
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(3, 7, 5, 0.3, 0.9, 2.1, 1.5),
            // Student Data - MUST CHANGE
            TestCase(6, 9, 4, 2, 12, 18, 8)
        ]

        public void TestScale(double x, double y, double z, double s, double expectedX, double expectedY, double expectedZ)
        {
            // Create Object(s) for the test
            Eng_Vector3D a = new Eng_Vector3D(x, y, z);
            // Perform the test; test both (s * v) and (v * s)
            Eng_Vector3D actual = a * s;
            // Assert
            Assert.AreEqual(expectedX, Math.Round(actual.X, 4));
            Assert.AreEqual(expectedY, Math.Round(actual.Y, 4));
            Assert.AreEqual(expectedZ, Math.Round(actual.Z, 4));
        }//end of TestScale

        //4.g - Test 3.d - Equality of two 3D vectors.
        //    - Test 3.e - Inequality of two 3D vectors.
        [Test,
             // 1st - 3rd = vector a
             // 4th - 6th = vector b
             // 7th - 9th = vector c
             // last = expected for both == and !=
             // Instructor Data - MUST NOT DELETE OR MODIFY
             TestCase(3, -4, 5, 3, -4, 5, 3, 4, 5, true),
             // Student Data - MUST CHANGE
             TestCase(69, 4, 20, 69, 4, 20, 2, 4, 5, true)
        ]

        public void TestEquality(double aX, double aY, double aZ, double bX, double bY, double bZ, double cX, double cY, double cZ, bool expected)
        {
            // Create Object(s) for the test
            Eng_Vector3D a = new Eng_Vector3D(aX, aY, aZ);
            Eng_Vector3D b = new Eng_Vector3D(bX, bY, bZ);
            Eng_Vector3D c = new Eng_Vector3D(cX, cY, cZ);
            // Perform test
            bool actual = a == b;
            bool actual2 = b != c;
            bool actual3 = a != c;
            // Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual2);
            Assert.AreEqual(expected, actual3);

        }//end of TestEquality

        //4.h - Test 3.f - Calculate the Cross Product of two 3D vectors.
        [Test,
            // 1st = vector a x component
            // 2nd = vector a y component
            // 3rd = vector a z component
            // 4th = vector b x component
            // 5th = vector b y component
            // 6th = vector b z component
            // 7th = expected aXb x component
            // 8th = expected aXb y component
            // 9th = expected aXb z component
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(3, -5, 7, 4, 5, -3, -20, 37, 35),
            // Student Data - MUST CHANGE
            TestCase(2, -5, 4, 6, 7, -2, -18, 28, 44)
        ]
        public void TestCrossProduct(
            double aX, double aY, double aZ, double bX, double bY, double bZ,
            double expectedX, double expectedY, double expectedZ)
        {
            // Create Object(s) for the test
            Eng_Vector3D a = new Eng_Vector3D(aX, aY, aZ);
            Eng_Vector3D b = new Eng_Vector3D(bX, bY, bZ);
            // Perform the test
            Eng_Vector3D actual = a * b;
            // Assert
            Assert.AreEqual(expectedX, actual.X);
            Assert.AreEqual(expectedY, actual.Y);
            Assert.AreEqual(expectedZ, actual.Z);
        }//end of TestCrossProduct
    }//eoc
}//eon
