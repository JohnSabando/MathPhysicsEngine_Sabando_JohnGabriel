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
    public class Lab1Vector2Tester
    {
        // Part 2 - 2D Vectors
        //4.a - Test 2.a - Magnitude of a 2D vector.
        [Test,
            // 1st = vector x component
            // 2nd = vector y component
            // 3rd = expected magnitude
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(4, 5, 6.4031),
            // Student Data - MUST CHANGE
            TestCase(4, 5, 6.4031)
        ]

        public void TestMagnitude(double x, double y, double expected)
        {
            // Create Object(s) for the test
           
            // Perform the test
            
            // Assert
           
        }//end of TestMagnitude

        //4.b - Test 2.b - The Dot Product of two 2D vectors.
        [Test,
            // 1st - 2nd = vector a
            // 3rd - 4th = vector b
            // 5th = expected dot product
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(3, 4, 6, -9, -18),
            // Student Data - MUST CHANGE
            TestCase(3, 4, 6, -9, -18)
        ]

        public void TestDotProduct(double ax, double ay, double bx, double by, double expected)
        {
            // Create Object(s) for the test
           
            // Perform the test
            
            // Assert
            
        }//end of TestDotProduct

        //4.c - Test 2.c - The angle between two 2D vectors.
        [Test,
            // 1st - 2nd = vector a
            // 3rd - 4th = vector b
            // 5th = expected angle between a and b in degrees
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(3, 4, -6, 9, 70.5600),
            // Student Data - MUST CHANGE
            TestCase(3, 4, -6, 9, 70.5600)
        ]

        public void TestAngleBetweenVectors(double ax, double ay, double bx, double by, double expected)
        {
            // Create Object(s) for the test
            
            // Perform the test
            
            // Assert - did we get back the correct answer
            
        }//end of TestAngleBetweenVectors

        //4.d - Test 2.d - To Normalize a 2D vector.
        [Test, 
        // 1st = vector x component
        // 2nd = vector y component
        // 3rd = expected x component
        // 4th = expected y component
        // Instructor Data - MUST NOT DELETE OR MODIFY
        TestCase(3, -5, 0.5145, -0.8575),
        // Student Data - MUST CHANGE
        TestCase(3, -5, 0.5145, -0.8575)
        ]
        public void TestNormalize(double aX, double aY, double expectedX, double expectedY)
        {
            // Create Object(s) for the test
            
            // Call the class method

            // Assert
           
        }//end of TestNormalize

        //4.e - Test 3.a - Adding two 2D vectors.
	//    - Test 3.b - Subtracting two 2D vectors.
        [Test,
            // 1st = vector a x component
            // 2nd = vector b y component
            // 3rd = vector b x component
            // 4th = vector b y component
            // 5th = expected a+b x component
            // 6th = expected a+b y component
            // 7th = expected a-b x component
            // 8th = expected a-b y component
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(-3, 4, 6, -9, 3, -5, -9, 13),
            // Student Data - MUST CHANGE
            TestCase(-3, 4, 6, -9, 3, -5, -9, 13)
        ]
        public void TestAddSubtract(
            double aX, double aY, double bX, double bY, 
            double expectedAddX, double expectedAddY, double expectedSubX, double expectedSubY)
        {
            // Create Object(s) for the test

            // Call the methods
            
            // Assert
            
        }//end of TestAddSubtract

        //4.f - Test 3.c.1 & 3.c.2 - Multiplying a 2D vector by a scalar.
        [Test,
            // 1st - 2nd = vector
            // 3rd = scale factor
            // 4th - 5th = expected scaled vector
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(-3, 7, 0.4, -1.2, 2.8),
            // Student Data - MUST CHANGE
            TestCase(-3, 7, 0.4, -1.2, 2.8)
        ]

        public void TestScale(double x, double y, double s, double expectedX, double expectedY)
        {
            // Create Object(s) for the test
            
            // Perform the test; test both (s * v) and (v * s)
            
            // Assert
           
        }//end of TestScale

        //4.g - Test 3.d - Equality of two 2D vectors.
	    //    - Test 3.e - Inequality of two 2D vectors.
        [Test,
            // 1st - 2nd = vector a
            // 3rd - 4th = vector b
            // 5th - 6th = vector c
            // last = expected for both == and !=
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(3, 7, 3, 7, -3, 7, true),
            // Student Data - MUST CHANGE
            TestCase(3, 7, 3, 7, -3, 7, true)
        ]

        public void TestEquality(double ax, double ay, double bx, double by, double cx, double cy, bool expected)
        {
            // Create Object(s) for the test
            
            // Perform test
            
            // Assert
            
        }//end of TestEquality
    }//eoc
}//eon
