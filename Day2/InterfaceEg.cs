using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    interface INormalCal
    {
        //public and abstract by default
        int Add(int x, int y);
        int Sub(int x, int y);

    }

    class Calculator : INormalCal, ISciCal //IsciCal from other file
    {
        int INormalCal.Add(int x, int y)
        {
            return x + y;
        }



        public int Sub(int x, int y)
        {
            return x - y;
        }

        int ISciCal.Add(int x, int y)
        {
            return x + y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }
    }
    class InterfaceEg
    {
        static void Main()
        {
            INormalCal ncal = new Calculator();
            Console.WriteLine("Addition of Normal Calculator:{0}", ncal.Add(5, 7));
            Console.WriteLine("sub of Normal Calculator:{0}", ncal.Sub(90, 7));
            ISciCal sciCal = new Calculator();
            Console.WriteLine("Addition of Scientific Calculator:{0}", sciCal.Add(5, 7));
            Console.WriteLine("mul of Scientific Calculator:{0}", sciCal.Mul(90, 7));
        }

    }
}
