using System;
using System.Collections.Generic;

namespace OpinionPoll
{

    //Using the Person class, write a program that reads from the console N lines of personal information and then prints
    //all people whose age is more than 30 years, sorted in alphabetical order.

    class Program
    {
        static void Main()
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string name;
            int age;
            var listOfPersons = new ListOfPersons();

            for (int i = 0; i < countOfPeople; i++)
            {
                var input = Console.ReadLine().Split();

                name = input[0];
                age = int.Parse(input[1]);

                listOfPersons.AddPerson(new Person(name, age));
                
            }

            listOfPersons.PrintResult();

           
        }
    }
}
