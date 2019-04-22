using System;
using System.Linq;
using System.Collections.Generic;

using System.Threading.Tasks;

namespace SpeedRacing
{
  //Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the
  //cars.Define a class Car that keeps track of a car’s model, fuel amount, fuel consumption for 1 kilometer and
  //distance traveled.A Car’s model is unique - there will never be 2 cars with the same model.
  //On the first line of the input you will receive a number N – the number of cars you need to track, on each of the
  //next N lines you will receive information for a car in the following format “&lt; Model&gt; &lt;FuelAmount&gt;
  //&lt;FuelConsumptionFor1km&gt;”. All cars start at 0 kilometers traveled.
  //After the N lines, until the command “End” is received, you will receive commands in the following format “Drive
  //&lt; CarModel&gt; &lt;amountOfKm&gt;”. Implement a method in the Car class to calculate whether or not a car can move
  //that distance.If it can, the car’s fuel amount should be reduced by the amount of used fuel and its distance
  //traveled should be increased by the number of kilometers traveled.Otherwise, the car should not move (its fuel
  //amount and distance traveled should stay the same) and you should print on the console “Insufficient fuel for the
  //drive”. After the “End” command is received, print each car and its current fuel amount and distance traveled in
  //the format “&lt;Model&gt; &lt;fuelAmount&gt; &lt;distanceTraveled&gt;”. Print the fuel amount rounded to two decimal places
  //after the separator.

    class Program
    {
        static void Main()
        {

            int countOfCars = int.Parse(Console.ReadLine());
            Car[] car = new Car[countOfCars];

            for (int i = 0; i < countOfCars; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                decimal fuelAmount = decimal.Parse(input[1]);
                decimal consumption = decimal.Parse(input[2]);

                car[i] = new Car(model, fuelAmount, consumption);
            }

            var command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (command[0]!="End")
            {
                string model = command[1];
                decimal distance = decimal.Parse(command[2]);

                car.Where(c => c.model == model).ToList().ForEach(c => c.Drive(distance));
                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (Car item in car)
            {
                Console.WriteLine($"{item.model} {item.fuelAmount:f2} {item.distanceTravelled}");
            }    
        }
    }
}
