using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentSystem
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, Student> listOfStudent= new Dictionary<string, Student>();

            string showStudent;
            

            while (input[0]=="Create")
            {
                string name = input[1];
                int age = int.Parse(input[2]);
                double grade = double.Parse(input[3]);

                listOfStudent[name] = new Student(age, grade);

                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            

            while (true)
            {
                
                if (input[0]=="Exit")
                {
                    Environment.Exit(0);
                    break;
                }
                showStudent = input[1];

                Print(listOfStudent, showStudent);
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

        }
        static void Print(Dictionary<string, Student> listOfStudent, string showStudent)
        {
            
            if (listOfStudent[showStudent].grade>=5.50)
            {
                Console.WriteLine($"{showStudent} is {listOfStudent[showStudent].age} years old. Excellent student.");
            }
            else if (listOfStudent[showStudent].grade >= 3.50 && listOfStudent[showStudent].grade < 5.50)
            {
                Console.WriteLine($"{showStudent} is {listOfStudent[showStudent].age} years old. Average student.");
            }
            else
            {
                Console.WriteLine($"{showStudent} is {listOfStudent[showStudent].age} years old. Weak student.");
            }



        }
       
    }
}
