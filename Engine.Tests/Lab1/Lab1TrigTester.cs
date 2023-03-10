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
    public class Lab1TrigTester
    {
        // Part 1 - Trigonometry
        //2.a - Test 1.a - A method to convert degrees to radians.
        [Test,
            // 1st = degrees
            // 2nd = expected radians
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(30, 0.5236),
            // Student Data - MUST Change
            TestCase(90, 1.5708)
        ]

        public void TestToRadians(double degrees, double expected)
        {
            // Perform test
            double actual = Functions.ToRadians(degrees);
            // Assert
            Assert.AreEqual(expected, Math.Round(actual,4));
        }//end of TestToRadians

        //2.b - Test 1.b - A method to convert radians to degrees.
        [Test,
            // 1st = radians
            // 2nd = expected degrees
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(0.6283, 35.9989),
            // Student Data - MUST CHANGE
            TestCase(2.5,143.2394)
        ]

        public void TestToDegrees(double radians, double expected)
        {
            // Perform test
            double actual = Functions.ToDegrees(radians);
            // Assert
            Assert.AreEqual(expected, Math.Round(actual, 4));
        }//end of TestToDegrees

        //2.c - Test 1.c - A method to solve a right triangle given an angle in degrees and the hypotenuse;
	//                 returns a Tuple<double, double> for the missing sides (adjacent, opposite).
        [Test,
            // 1st = theta in degrees
            // 2nd = hypotenuse
            // 3rd = expected adjacent
            // 4th = expected opposite
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(25, 6, 5.4378, 2.5357),
            // Student Data - MUST CHANGE
            TestCase(25, 6, 5.4378, 2.5357)
        ]

        public void TestCalculateAdjacentOpposite(double degrees, double hypotenuse, double adjacent, double opposite)
        {
            // Perform test
            Tuple<double,double> actual = Functions.CalculateAdjacentOpposite(Functions.ToRadians(degrees), hypotenuse);
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(Math.Round(actual.Item1, 4), Is.EqualTo(adjacent));
                Assert.That(Math.Round(actual.Item2, 4), Is.EqualTo(opposite));
            });
        }//end of TestCalculateAdjacentOpposite

        //2.d - Test 1.d - A method to solve a right triangle given an angle in degrees and the side opposite;
	//                 returns a Tuple<double, double> for the missing sides (adjacent, hypotenuse).
        [Test,
            // 1st = theta in degrees
            // 2nd = opposite
            // 3rd = expected adjacent
            // 4th = expected hypotenuse
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(25, 6, 12.867, 14.1972),
            // Student Data - MUST CHANGE
            TestCase(60,12,6.9282,13.8564)
        ]

        public void TestCalculateAdjacentHypotenuse(double degrees, double opposite, double adjacent, double hypotenuse)
        {
            // Perform test
            Tuple<double, double> actual = Functions.CalculateAdjacentHypotenuse(Functions.ToRadians(degrees), opposite);
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(Math.Round(actual.Item1, 4), Is.EqualTo(adjacent));
                Assert.That(Math.Round(actual.Item2, 4), Is.EqualTo(hypotenuse));
            });
        }//end of TestCalculateAdjacentHypotenuse

        //2.e - Test 1.e - A method to solve a right triangle given an angle in degrees and the side adjacent;
	//                 returns a Tuple<double, double> for the missing sides (opposite, hypotenuse).
        [Test,
            // 1st = theta in degrees
            // 2nd = adjacent
            // 3rd = expected opposite
            // 4th = expected hypotenuse
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(25, 6, 2.7978, 6.6203),
            // Student Data - MUST CHANGE
            TestCase(55,10,14.2815,17.4345)
        ]

        public void TestCalculateOppositeHypotenuse(double degrees, double adjacent, double opposite, double hypotenuse)
        {
            // Perform test
            Tuple<double, double> actual = Functions.CalculateOppositeHypotenuse(Functions.ToRadians(degrees),adjacent);
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(Math.Round(actual.Item1, 4), Is.EqualTo(opposite));
                Assert.That(Math.Round(actual.Item2, 4), Is.EqualTo(hypotenuse));
            });

        }//end of TestCalculateOppositeHypotenuse

        //2.f - Test 1.f - A method to solve a right triangle given side opposite and side adjacent;
	//                 returns a Tuple<double, double> for the missing side and the angle in degrees.
        [Test,
            // 1st = adjacent
            // 2nd = opposite
            // 3rd = expected hypotenuse
            // 4th = expected theta in degrees
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(3, 5, 5.8310, 59.0362),
            // Student Data - MUST CHANGE
            TestCase(35,15,38.0789,23.1986)
        ]

        public void TestCalculateHypotenuseTheta(double adjacent, double opposite, double hypotenuse, double degrees)
        {
            // Perform test
            Tuple<double, double> actual = Functions.CalculateHypotenuseTheta(opposite, adjacent);
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(Math.Round(actual.Item1, 4), Is.EqualTo(hypotenuse));
                Assert.That(Math.Round(Functions.ToDegrees(actual.Item2),4), Is.EqualTo(degrees));
            });
        }//end of TestCalculateHypotenuseTheta

        //2.g - Test 1.g - A method to solve a right triangle given side opposite and hypotenuse;
	//                 returns a Tuple<double, double> for the missing side and the angle in degrees.
        [Test,
            // 1st = opposite
            // 2nd = hypotenuse
            // 3rd = expected adjacent
            // 4th = expected theta in degrees
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(3, 4, 2.6458, 48.5904),
            // Student Data - MUST CHANGE
            TestCase(10,15,11.1803,41.8103)
        ]

        public void TestCalculateAdjacentTheta(double opposite, double hypotenuse, double adjacent, double degrees)
        {
            // Perform test
            Tuple<double, double> actual = Functions.CalculateAdjacentTheta(opposite, hypotenuse);
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(Math.Round(actual.Item1, 4), Is.EqualTo(adjacent));
                Assert.That(Math.Round(Functions.ToDegrees(actual.Item2), 4), Is.EqualTo(degrees));
            });

        }//end of TestCalculateAdjacentTheta

        //2.h - Test 1.h - A method to solve a right triangle given side adjacent and hypotenuse;
	//                 returns a Tuple<double, double> for the missing side and the angle in degrees.
        [Test,
            // 1st = adjacent
            // 2nd = hypotenuse
            // 3rd = expected opposite
            // 4th = expected theta in degrees
            // Instructor Data - MUST NOT DELETE OR MODIFY
            TestCase(4, 6, 4.4721, 48.1897),
            // Student Data - MUST CHANGE
            TestCase(12,20,16,53.1301)
        ]

        public void TestCalculateOppositeTheta(double adjacent, double hypotenuse, double opposite, double degrees)
        {
            // Perform test
            Tuple<double, double> actual = Functions.CalculateOppositeTheta(adjacent, hypotenuse);
            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(Math.Round(actual.Item1, 4), Is.EqualTo(opposite));
                Assert.That(Math.Round(Functions.ToDegrees(actual.Item2), 4), Is.EqualTo(degrees));
            });
        }//end of TestCalculateOppositeTheta
    }//eoc
}//eon
