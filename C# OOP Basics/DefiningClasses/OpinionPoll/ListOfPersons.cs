using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OpinionPoll
{
   public class ListOfPersons
    {
      public  List<Person> listOfPersons;

        public ListOfPersons()
        {
            this.listOfPersons = new List<Person>();
        }

        public void AddPerson(Person addPers)
        {
            this.listOfPersons.Add(addPers);
        }
       
        public void PrintResult()
        {
            listOfPersons = listOfPersons.OrderBy(a => a.name).ToList();
            var result = listOfPersons.Where(a => a.age > 30);
            
            foreach (var item in result)
            {
                Console.WriteLine(item.name + " - " + item.age);
            }
            
        }
    }
}
