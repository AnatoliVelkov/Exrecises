using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RawData
{
    public class Cars
    {
        public string model;
        public int engineSpeed;
        public int enginePower;
        public int cargoWeight;
        public string cargoType;
        public double tire1Pressure;
        public int tire1Age;
        public double tire2Pressure;
        public int tire2Age;
        public double tire3Pressure;
        public int tire3Age;
        public double tire4Pressure;
        public int tire4Age;

        public Cars(string model, int engineSpeed, int enginePower, int cargoWeight,
           string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age
            , double tire4Pressure, int tire4Age)
        {
            this.model = model;
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
            this.cargoWeight = cargoWeight;
            this.cargoType = cargoType;
            this.tire1Pressure = tire1Pressure;
            this.tire1Age = tire1Age;
            this.tire2Pressure = tire2Pressure;
            this.tire2Age = tire2Age;
            this.tire3Pressure = tire3Pressure;
            this.tire3Age = tire3Age;
            this.tire4Pressure = tire4Pressure;
            this.tire4Age = tire4Age;
        }
        

    }
}
