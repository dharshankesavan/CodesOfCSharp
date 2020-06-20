using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract Implementation
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.FirstName = "dharshan kesavans";
            Console.WriteLine(fullTimeEmployee.Add());
            Console.WriteLine(fullTimeEmployee.CalculateWage());

            //Interface Implementation
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.FirstName = "DHARSHAN KESAVAN";
            Console.WriteLine(partTimeEmployee.Search());
            Console.ReadKey();
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override string FirstName
        {
            get
            {
                return Fname;
            }
            set
            {
                Fname = value;
            }
        }
        public override string CalculateWage() // Abstract Method Implemented
        {
            return "Full time employee " +
                  base.Fname + " is calculated " +
                  "using the Abstract Method...";
        }
    }

    public class PartTimeEmployee : IEmployee
    {
        protected string Fname;
        public string FirstName
        {
            get
            {
                return Fname;
            }
            set

            {
                Fname = value;
            }
        }
        public string Search() // Interface Method Implemented
        {
            return "Fulltime Employee " + Fname + " searched using Interface Method.";
        }
    }

    public interface IEmployee
    {
        string FirstName { get; set; }
        //interface methods
        string Search();
    }

    public abstract class Employee
    {
        protected string Fname;

        public abstract string FirstName
        {
            get;
            set;
        }

        //completed methods
        public string Add()
        {
            return "Employee " + Fname + " added";
        }

        public string Delete()
        {
            return "Employee " + Fname + " deleted";
        }

        //abstract methods
        public abstract string CalculateWage();
    }
}
