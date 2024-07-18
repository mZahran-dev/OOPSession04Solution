using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession04.IClonable
{
    class Department : ICloneable
    {
         public int id { get; set; }
         public string name { get; set; }

        public object Clone()
        {
            return new Department()
            {
                id = this.id,
                name = this.name
            };
        }

        public override string ToString()
        {
            return $"id:{id}, name:{name}";  
        }
        
    }
    internal class Employee : ICloneable, IComparable

    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Department department { get; set; }


        public object Clone()
        {
            return new Employee(this);
        }
        public Employee()
        {

        }
        public Employee(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.Salary = employee.Salary;  
            this.department = (Department)employee.department.Clone();
        }
        public override string ToString()
        {
            return $"Id : {Id}\nName: {Name}\nsalary: {Salary}\n department: {department}";
        }

        public int CompareTo(object? obj)
        {
            //-VE => this.Salary < obj.Salary
            //+VE => this.salary > obj.Salary
            // 0 => this.Salary == obj.Salary
            Employee passedEmp = (Employee) obj; // Unsafe Casting
            //if (this.Salary < passedEmp.Salary)
            //    return -1;
            //else if (this.Salary < passedEmp.Salary)
            //    return 1;
            //else
            //    return 0;

            return this.Salary.CompareTo(passedEmp.Salary);
        }
   
    
    
    }
}
