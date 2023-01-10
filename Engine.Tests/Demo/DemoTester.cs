using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namesapces
using NUnit.Framework;
using Engine.Mathematics;
#endregion

namespace Engine.NunitTests.Demo
{
    [TestFixture]
    public class DemoTester
    {
        [Test,
        TestCase(0, 0, 3, 4, 5), // Instructor Data - MUST NOT DELETE OR MODIFY
        TestCase(0, 0, 6, 8, 10) // Student Data - MUST Change
    ]
        public void TestSegmentLengthPoint2D(double aX, double aY, double bX, double bY, double expected)
        {
            // Create Object(s) for the test
            Eng_Point2D a = new Eng_Point2D(aX, aY);
            Eng_Point2D b = new Eng_Point2D(bX, bY);
            // Perform the test
            double actual = a.SegmentLength(b);
            Assert.AreEqual(expected, Math.Round(actual, 4));
        }//eom

        public void TestMidpointPoint2D(double aX, double aY, double bX, double bY, double expectedX, double expectedY)
        {
            // Create Object(s) for the test
            Eng_Point2D a = new Eng_Point2D(aX, aY);
            Eng_Point2D b = new Eng_Point2D(bX, bY);
            Eng_Point2D actual = a.MidPoint(b);
            // Perform the test
            Assert.AreEqual(expectedX, Math.Round(actual.X, 4));
            Assert.AreEqual(expectedY, Math.Round(actual.Y, 4));
        }//eom

        public void TestScale(double s, double pX, double pY, double expectedX, double expectedY)
        {
            // Create Object(s) for the test
            Eng_Point2D p = new Eng_Point2D(pX, pY);
            Eng_Point2D actual1 = s * p;
            Eng_Point2D actual2 = p * s;
            // Performing the test; test both (s * p) and (p * s)
            Assert.AreEqual(expectedX, Math.Round(actual1.X, 4));
            Assert.AreEqual(expectedY, Math.Round(actual1.Y, 4));
            Assert.AreEqual(expectedX, Math.Round(actual2.X, 4));
            Assert.AreEqual(expectedY, Math.Round(actual2.Y, 4));
        }//eom

        public static IEnumerable<Object[]> MidPointData()
        {
            // Instructor Data - MUST NOT DELETE OR MODIFY
            // 1st new Eng_Point2D is the point A
            // 2nd new Eng_Point2D is the point B
            // 3rd new Eng_Point2D is the expected outcome
            yield return new Object[]
            {
                new Eng_Point2D(3, 4),      // point a
                new Eng_Point2D(6, 9),      // point b
                new Eng_Point2D(4.5, 6.5)   // expected midpoint
            };

            // Student Data - MUST Change
            // 1st new Eng_Point2D is the point A
            // 2nd new Eng_Point2D is the point B
            // 3rd new Eng_Point2D is student expected outcome
            yield return new Object[]
            {
                new Eng_Point2D(3, 4),      // point a
                new Eng_Point2D(6, 9),      // point b
                new Eng_Point2D(4.5, 5.5)   // expected midpoint
            };
        }//eom
    }//eoc
}//eon
