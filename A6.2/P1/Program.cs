using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18jan2022
{
    
    class SelectionSort {
        static public void Sort<T>(IList<T> sortArray, Func<T,T,bool> comparision) {
            bool swapped = true;
            do {    
                int position , i , j;
                swapped = false;
                for(i=0; i < sortArray.Count - 1; i++) {
                    position = i;
                    for(j = i; j < sortArray.Count; j++) {
                        if(comparision(sortArray[position],sortArray[j])) {
                            position = j;
                        }
                    }

                    if(position!=i){
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i+1];
                        sortArray[i+1] = temp;
                        swapped=true; 
                    }
                }
            } while(swapped);
        }
    }
        public enum Designations
        {
           CEO=4,
           CFO=10,
           sde=5,
           ba=2,
           pm=6
        }

        class Employee
        {
            int empid;
            float salary;
            public string name;
            Designations designation;

            public Employee(int EmpId, float Salary, string NAme, Designations design)
            {
                this.empid = EmpId;
                this.salary = Salary;
                this.name = NAme;
                this.designation = design;

            }

           internal static bool CompareSalary(Employee e1, Employee e2)
            {
                return e1.salary < e2.salary;
            }

           internal static bool CompareNames(Employee e1, Employee e2)
            {
                if(e1.name.CompareTo(e2.name)== 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

           internal static bool CompareDesignations(Employee e1, Employee e2)
            {
                return e1.designation < e2.designation;
            }
        }
    

    public class TestGenericMethods
    {
        public static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>(30);
            emplist.Add(new Employee(1111, 1000000, "Franklin", Designations.CFO)); 

            emplist.Add(new Employee(2222, 1200000, "Trevor", Designations.CEO));

            emplist.Add(new Employee(3333, 1400000, "Micheal", Designations.sde));

            emplist.Add(new Employee(4444,1600000,"Chandler",Designations.CEO));

            emplist.Add(new Employee(5555,1800000,"Joey",Designations.sde));

            emplist.Add(new Employee(6666,2000000,"Carl",Designations.CFO));


            SelectionSort.Sort<Employee>(emplist, Employee.CompareSalary);

            foreach(Employee e1 in emplist)
            {
                Console.WriteLine(e1.name);
            }
        }
    }
}
