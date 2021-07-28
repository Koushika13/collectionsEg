using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    enum Feedback
    {
        Poor = 1, Fair, Good = 4, Excellent
    }
    //Base class or parent class
    class Department
    {
        //protected is used within the class and only in derived class

        protected int Did { get; set; }
        protected string Dname { get; set; }
        protected string City { get; set; }

        internal Department(int Did, string Dname, string City)
        {
            Console.WriteLine("Department Constructor");
            this.Did = Did;
            this.Dname = Dname;
            this.City = City;
        }

        protected internal void DisplayDepartmentInfo()
        {
            Console.WriteLine("Did:{0},Dname:{1}", Did, Dname);

        }

        //Destructor - dealloacating the memory. 
        // if we deallocate memory of parent class, child class memory will aslo get deallocated 
        //in c# garbage collector deallocated the unused memory
        //hence destructor is not necessary

        /* ~Department() 
         {

         }*/
    }


    //single inheritance
    //child or derived class employee
    //best way to write parameters is from parent class to child class
    class Employee : Department
    {
        internal static string CompanyName = "LTI";
        internal int Eid { get; set; }
        internal string Name { get; set; }
        internal string City = "Pune";

        internal Employee(int Eid, string Name, int Did, string Dname, string City) : base(Did, Dname, City)
        {
            Console.WriteLine("Employee Constructor");

            this.Eid = Eid;
            this.Name = Name;

        }

        internal void DisplayEmployeeInfo()
        {
            DisplayDepartmentInfo();
            Console.WriteLine("Deparment City is:{0}", base.City);
            Console.WriteLine("Eid:{0} || Ename:{1} || feedback:{2}", Eid, Name, (int)Feedback.Excellent);
            Console.WriteLine("Employee City is:{0}", City);
        }

        /*
        ~Employee()
        {
            Console.WriteLine("Employee Destructor");
        }*/

    }

    //class deriving from Employee class, Department<-Employee<-PartTimeEmployee
    class PartTimeEmployee : Employee
    {
        internal int hoursofwork { get; set; }
        internal int Salary { get; set; }

        internal PartTimeEmployee(int Eid, string Name, int Did, string Dname, string City, int hoursofwork,int Salary) : base(Eid,Name,Did,Dname,City)
        {
            this.hoursofwork = hoursofwork;
            this.Salary = Salary;
        }

        internal int MonthlySalary()
        {
            int Payment = hoursofwork * 30 * Salary;
            return Payment;
            //Console.WriteLine(Payment);
        }
        
        /*
        ~PartTimeEmployee()
        {
        Console.WriteLine("parttimeemployee destructor);
        }*/

    }

    class Multileverlinheritance
    {

        static void Main()
        {
            //Single inheritance
            //Employee employee = new Employee(1001, "Sai", 101, "HR", "Madhurai");
            //employee.DisplayEmployeeInfo();

            //error: since or if protected
            //employee.DisplayDepartmentInfo();

            //Multilevel Inheritance

            PartTimeEmployee pt = new PartTimeEmployee(1001, "Sai", 101, "HR", "Madhurai", 67, 200);
            pt.DisplayEmployeeInfo();
            //pt.MonthlySalary();
            Console.WriteLine("Monthly Salary:{0}",pt.MonthlySalary());

            //Garbage collector which invokes the destructor

           // GC.Collect(); 


        }

    }
}

