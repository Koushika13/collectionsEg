using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class StudentDet
    {
        static void Main()
        {
            Undergraduate undergraduate = new Undergraduate("Koushika", 1, 65);
            Console.WriteLine(undergraduate.isPassed(65));

            Graduate graduate = new Graduate("Koushika", 2, 85);
            Console.WriteLine(graduate.isPassed(85));
        }
    }

    abstract class Student
    {
        internal string Name;
        internal int studentId;
        internal int Grade;

        public Student(string Name, int studentId, int Grade)
        {
            this.Name = Name;
            this.studentId = studentId;
            this.Grade = Grade;
        }

        public abstract bool isPassed(int Grade);
    }  

    class Undergraduate : Student
    {

        public Undergraduate(string Name, int studentId, int Grade) : base(Name, studentId, Grade)
        {
            this.Name = Name;
            this.studentId = studentId;
            this.Grade = Grade;

        }

        public override bool isPassed(int Grade)
        {
            if (Grade > 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }

    class Graduate : Student
    {
        public Graduate(string Name, int studentId, int Grade) : base(Name, studentId, Grade)
        {
            this.Name = Name;
            this.studentId = studentId;
            this.Grade = Grade;

        }

        public override bool isPassed(int Grade)
        {
            if (Grade > 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
