using System;
using System.Linq;
using System.Collections.Generic;

namespace RawData
{
//  You are the owner of a courier company and want to make a system for tracking your cars and their cargo.
//  Define a class Car that holds information about model, engine, cargo and a collection of exactly 4 tires.
//  The engine, cargo and tire should be separate classes.Create a constructor that receives all information about the Car 
//  and creates and initializes its inner components (engine, cargo and tires).
//  On the first line of input you will receive a number N - the amount of cars you have.
//  On each of the next N lines you will receive information about a car in the format
//  “<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>” where the speed, power, weight and tire age are integers, tire pressure is a double. 
//  After the N lines you will receive a single line with one of 2 commands: “fragile” or “flamable”. 
//  If the command is “fragile” print all cars whose Cargo Type is “fragile” with a tire whose pressure is  < 1.
//  If the command is “flamable” print all cars whose Cargo Type is “flamable” and have Engine Power > 250. 
//  The cars should be printed in order of appearing in the input.

    class Program
    {
        static void Main(string[] args)
        {
            int countCars = int.Parse(Console.ReadLine());
            Cars[] cars = new Cars[countCars];

            for (int i = 0; i < countCars; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                cars[i] = new Cars(model, engineSpeed, enginePower, cargoWeight, cargoType, tire1Pressure, tire1Age,
                    tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age);
            }

            var command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (Cars item in cars.Where(a=>a.tire1Pressure<1))
                {
                    Console.WriteLine(item.model);
                }
            }
            if (command == "flamable")
            {
                foreach (Cars item in cars.Where(a => a.enginePower > 250))
                {
                    Console.WriteLine(item.model);
                }
            }
            
        }
    }
}
