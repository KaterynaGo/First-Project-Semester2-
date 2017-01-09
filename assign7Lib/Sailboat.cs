using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign7Lib
{
    public class Sailboat:Boat
    {
        private int numberOfSails;

        public int NumberOfSails
        {
            get { return numberOfSails; }
            set { numberOfSails = value; }
        }
        private int numberOfMasts;

        public int NumberOfMasts
        {
            get { return numberOfMasts; }
            set { numberOfMasts = value; }
        }

        public Sailboat( int numberOfSails, int numberOfMasts)
        {
            NumberOfSails = numberOfSails;
            NumberOfMasts = numberOfMasts;
        }
        public Sailboat()
        {
            NumberOfSails = 1;
        }

        public override string ToString()
        {
            string sailboatToString = base.ToString();

            sailboatToString += "Number of Sails:" + NumberOfSails + " and number of Masts :" +NumberOfMasts;

            return sailboatToString;
          
        }
    }
}
