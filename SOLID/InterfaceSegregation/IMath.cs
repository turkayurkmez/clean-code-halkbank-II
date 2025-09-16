using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IMath
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);

        int Divide(int a, int b);

  



    }

    public interface IComplexMath :IMath
    {
        int Modulo(int a, int b);

        int Min(int a, int b);

        int Max(int a, int b);
        int Power(int a, int b);
        double Sqrt(int a);
    }


    public class SimpleMath : IMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Divide(int a, int b)
        {
            return (a + b);
        }

     

        public int Multiply(int a, int b)
        {
            return a * b;
        }

     

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    public class ComplexMath : IComplexMath
    {
        public int Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Divide(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Max(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Min(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Modulo(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Power(int a, int b)
        {
            throw new NotImplementedException();
        }

        public double Sqrt(int a)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
