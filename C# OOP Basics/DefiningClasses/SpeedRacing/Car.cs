using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
 public class Car
    {
        public string model;
        public decimal fuelAmount;
        public decimal consumption;
        public decimal distanceTravelled;
        
        public Car(string model, decimal fuelAmount, decimal consumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.consumption = consumption;
            this.distanceTravelled = 0;
        }

        public void Drive(decimal distance)
        {
            if (this.fuelAmount<distance*this.consumption)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.fuelAmount = this.fuelAmount - distance * this.consumption;
                this.distanceTravelled = distance;
            }
        }
    }
}
