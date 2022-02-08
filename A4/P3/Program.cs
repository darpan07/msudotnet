using System;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("DARPAN","RATHWA",750000);
            Employee e2 = new Employee("KEZAL","CHAVDA",700000);

            Console.WriteLine("Before Promotion");
            Console.WriteLine(e1.ToString());
            Console.WriteLine(e2.ToString());

            Console.WriteLine("After Promotion");
            e1.giveRaise(10.0);
            e2.giveRaise(10.0);

            Console.WriteLine(e1.ToString());
            Console.WriteLine(e2.ToString());


            Console.WriteLine("----------- Permanent Employee ---------");

            PermanentEmployee pe1 = new PermanentEmployee("DARPAN","RATHWA",45000,35000,20000,10000,"01-03-2022","31-05-2022");

            PermanentEmployee pe2 = new PermanentEmployee("KEZAL","CHAVDA",23000,15000,50000,9500,"01-03-2022","30-12-2022");

            Console.WriteLine("Before Promotion");

            Console.WriteLine(pe1);
            Console.WriteLine(pe2);

            pe1.giveRaise(10.0);
            pe2.giveRaise(10.0);

            Console.WriteLine("After Promotion");

            Console.WriteLine(pe1.ToString());
            Console.WriteLine(pe2.ToString());
        }
    }

    public class Employee {
        
        private String _firstName;
        private String _lastName;
        private double _monSalary;

        public Employee(String first, String last, double sal) {
            _firstName = first;
            _lastName = last;
            _monSalary = sal;
        }

        public String First {
            get => _firstName;
            set => _firstName = value;
        }

        public String Last {
            get => _lastName;
            set => _lastName = value;
        }

        public double MonSalary {
            get => _monSalary;
            set  {
                if(value < 0.0) {
                    _monSalary = 0.0;
                }
                else {
                    _monSalary = value;
                }
            }
            // 2nd way
            // set => _monSalary = value < 0.0 ? 0.0 : value;
            
        }

        public virtual void giveRaise(double inc) {
            _monSalary = _monSalary + (_monSalary*inc/100);
        }

        public override string ToString()
        {
            return "Employee Details : " + _firstName + " " + _lastName + " Annually Salary : " +( _monSalary)*12;
        }
    }

    public class PermanentEmployee : Employee {

        private double _hra;
        private double _da;
        private double _pf;
        private String _joiningDate;
        private String _retirementDate;

        public PermanentEmployee(String first, String last, double sal,double hra, double da, double pf, String joiningDate, String retirementDate) : base(first, last, sal) {
            this._hra = hra;
            this._da = da;
            this._pf = pf;
            this._joiningDate = joiningDate;
            this._retirementDate = retirementDate;
            this.MonSalary = this.MonSalary + _hra + _da;
        }

        public double Hra {
            get => _hra;
        }

        public double Da {
            get => _da;
        }

        public double Pf {
            get => _pf;
        }

        public String JoiningDate {
            get => _joiningDate;
            set => _joiningDate = value;
        }

        public String RetirementDate {
            get => _retirementDate;
            set => _retirementDate = value;
        }

        public override void giveRaise(double inc)
        {
            this.MonSalary = this.MonSalary + (this.MonSalary*inc) / 100 + _da + _hra;
        }

        public override string ToString()
        {
            return "Permanent Employee Details : " + this.First + " " + this.Last + " Joining Date : " + _joiningDate + " Retirement Date : " + _retirementDate + " Annually Salary : " + (this.MonSalary)*12;
        }
    }
}
