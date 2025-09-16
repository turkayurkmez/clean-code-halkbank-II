using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal class MathComponent
    {

        public int A { get; set; }
        public int B { get; set; }
        public int GetPower(IComplexMath math)
        {
            return math.Power(A, B);
        }
    }
}
