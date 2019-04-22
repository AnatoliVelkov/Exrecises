using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class Program
    {
        static void Main()
        {
            List<Department> departments = new List<Department>();

            int peopleCount = int.Parse(Console.ReadLine());

            for (int person = 0; person < peopleCount; person++)
            {
                string[] empInput = Console.ReadLine().Split();

                string name = empInput[0];
                decimal salary = decimal.Parse(empInput[1]);
                string position = empInput[2];
                string depName = empInput[3];
                string email = "n/a";
                int age = -1;

                if (empInput.Length==6)
                {
                    email = empInput[4];
                    age = int.Parse(empInput[5]);
                }
                else if (empInput.Length==5)
                {
                    bool isAge = int.TryParse(empInput[4], out age);
                    if (!isAge)
                    {
                        email = empInput[4];
                    }
                }


                if (!departments.Any(d=>d.Name==depName))
                {
                    Department dep = new Department(depName);
                    departments.Add(dep);
                }
                var department = departments.FirstOrDefault(d => d.Name == depName);
                Employee employee = new Employee(name, position, salary, age, email);
                department.AddEmployee(employee);
            }
            
        }
    }
}
