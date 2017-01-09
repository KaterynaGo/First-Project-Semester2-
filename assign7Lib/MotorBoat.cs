using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign7Lib
{
   public class MotorBoat:Boat
    {
        private int numberOfEngines;

        public int NumberOfEngines
        {
            get { return numberOfEngines; }
            set { numberOfEngines = value; }
        }
        private string fuelType;

        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }
        public MotorBoat(int numberOfEngines, string fuelType)
        {
            NumberOfEngines = numberOfEngines;
            FuelType = fuelType;
        }

        public MotorBoat()
        {
            NumberOfEngines = 1;
            FuelType = "Diesel";
        }

        public override string ToString()
        {
            string motorboatToString = base.ToString();
           
            motorboatToString +=  "Number Of Engines: " + NumberOfEngines + "With a Type" + ":" + FuelType;

            return motorboatToString;
        }

    }
}
