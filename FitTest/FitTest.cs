using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAndQualAssign;

namespace FitTest
{
    public class FitTest : fit.ColumnFixture
    {
        public Premium lc = new Premium();
        public string Gender;
        public int age;
        public double premium;


        public double DeterminePremium()
        {
            return lc.CalcPremium(age, Gender);
        }
    }
}
