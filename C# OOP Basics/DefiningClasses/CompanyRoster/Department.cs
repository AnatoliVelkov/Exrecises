using System.Collections.Generic;
using System.Linq;

public class Department
{
    private List<Employee> employees;
    string name;

    public Department(string name)
    {
        this.Employeees = new List<Employee>();
        this.Name = name;
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }


    public List<Employee> Employeees

    {
        get { return employees; }
        private set { this.employees = value; }
        
    }

    public decimal AverageSalary=> this.Employeees.Select(e => e.Salary).Average();
    
    public void AddEmployee(Employee employee)
    {
        this.Employeees.Add(employee);
    }
}