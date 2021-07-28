using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
     abstract class Car1
    {
        internal int regNo { get; set; }

        internal Car1(int regNo)
        {
            this.regNo = regNo;
        }

        public void openTank()
        {
            Console.WriteLine("Open Tank");
        }

        public abstract void steering(int direction, int angle);
        public abstract void braking(int force);

       
    }

    class Tata : Car1
    {

        internal Tata(int regNo) : base(regNo)
        {
            this.regNo = regNo;
        }
        public override void steering(int direction, int angle)
        {
           
            Console.WriteLine("Direction is {0} || Angle is{1}", direction,angle);
        }

        public override void braking(int force)
        {
            force = 50;
            Console.WriteLine("Force is {0}", force);
        }
    }

    class Mahindra : Car1
    {

        internal Mahindra(int regNo):base(regNo)
        {
            this.regNo = regNo;
        }
        public override void steering(int direction, int angle)
        {
            Console.WriteLine("hey");
        }

        public override void braking(int force)
        {
            Console.WriteLine("bye");
        }
    }

    class abstracteg
    {
        static void Main()
        {
            Tata tata = new Tata(510);
            tata.braking(10);
            tata.steering(10,30);
            tata.openTank();
            Mahindra mahindra = new Mahindra(210);
            mahindra.braking(10);
            mahindra.steering(10, 30);


        }
    }
}
