using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Vehicle
    {
        protected int regNumber { get; set; }
        protected double speed { get; set; }
        protected string color { get; set; }
        protected string ownerName { get; set; }
        internal Vehicle(int regNumber, double speed, string color, string ownerName)
        {
            this.regNumber = regNumber;
            this.speed = speed;
            this.color = color;
            this.ownerName = ownerName;
        }

        protected internal virtual void showData()
        {
            Console.WriteLine("This is a Vehicle");
        }


    }

    class Bus : Vehicle
    {
        int routeNumber { get; set; }

        internal Bus(int regNumber, double speed, string color, string ownerName, int routeNumber):base(regNumber,speed,color,ownerName)
        {
            this.routeNumber = routeNumber;
        }

        protected internal override void showData()
        {
            base.showData();
            
            Console.WriteLine(" Registration Number is:{0} || Speed is: {1} || Color is :{2} || Owner Name: {3} ,Route Number is: {4} ", regNumber,regNumber,speed,color,ownerName, routeNumber);
        }
    }

    class   Car : Vehicle
    {
        string manufacturerName { get; set; }

        internal Car(int regNumber, double speed, string color, string ownerName, string manufactureName) : base(regNumber, speed, color, ownerName)
        {
            this.manufacturerName = manufacturerName;
        }

        protected internal override void showData()
        {
            base.showData();
            
            Console.WriteLine(" Registration Number is:{0} || Speed is: {1} || Color is :{2} || Owner Name: {3} ,Manufactue Name is: {4} ", regNumber, regNumber, speed, color, ownerName, manufacturerName);
        }
    }

    class InheritanceA
    {
        static void Main()
        {
            Bus bus = new Bus(1, 66, "Orange", "Akhil",22);
            bus.showData();

            Car car = new Car(1, 66, "Orange", "Akhil", "Hyundai");
            car.showData();
        }
    }
}
