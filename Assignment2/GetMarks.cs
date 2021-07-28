using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class GetMarks
    {
        static void Main()
        {
            A a = new A(65, 85, 99);
            a.getPercentage();

            B b = new B(45, 60, 75, 80);
            b.getPercentage();
        }
    }

    abstract class Marks
    {
        abstract public void getPercentage();
    }

    class A : Marks
    {
             
        int sub1 { get; set; }
        int sub2 { get; set; }
        int sub3 { get; set; }

        public A(int sub1, int sub2, int sub3)
        {
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
        }
        public override void getPercentage()
        {
            int sumA;
            double percentmarksA;
            sumA = (sub1 + sub2 + sub3) ;
            percentmarksA = sumA / 3;
            Console.WriteLine("A percentage: {0}", percentmarksA);
            
        }
    }

    class B : Marks
    {

        int sub1 { get; set; }
        int sub2 { get; set; }
        int sub3 { get; set; }

        int sub4 { get; set; }

        public B(int sub1, int sub2, int sub3,int sub4)
        {
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
            this.sub4 = sub4;
        }
        public override void getPercentage()
        {
            int sumB;
            double percentmarksB;
            sumB = (sub1 + sub2 + sub3 + sub4);
            percentmarksB = sumB / 4;
            Console.WriteLine("B percentage: {0}", percentmarksB);

        }
    }

}
