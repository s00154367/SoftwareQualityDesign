using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestAndQualAssign;

namespace NUnitTest
{
    [TestFixture]
    public class InsuranceTest
    {
        const double premium = 1;
        Premium p1;

        [SetUp]
        public void init(){
            p1 = new Premium();
        }

        [Test]
        public void Test1()
        {
            Assert.That(p1, Is.Not.Null, "Premium not Created");
        }

        [Test]
        public void TestCalcPremium()
        {
            double expectedResult = 5;
            double actualResult = p1.CalcPremium(20,"female");
            Assert.That(actualResult, Is.EqualTo(expectedResult),"Test of premium Passed for female aged 20",premium);


        }

        [TestCase(17, "male", ExpectedResult = 0)]
        [TestCase(37, "male", ExpectedResult = 5)]
        [TestCase(60, "female", ExpectedResult = 0.375)]

        public double test3(int age, string gender)
        {
            double actualResult = p1.CalcPremium(age, gender);
            return actualResult;
        }

    }
}
