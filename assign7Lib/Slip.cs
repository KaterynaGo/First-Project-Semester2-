using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign7Lib
{
    public class Slip
    {
        private string slipId;

        public string SlipId
        {
            get { return slipId; }
            set { slipId = value; }
        }
        private int slipWidth;

        public int SlipWidth
        {
            get { return slipWidth; }
        }

        private int slipLength;

        public int SlipLength
        {
            get { return slipLength; }
        }

        private int slipDepth;

        public int SlipDepth
        {
            get { return slipDepth; }
        }

        public Slip(string slipId, int slipWidth, int slipLength, int slipDepth)
        {
            this.SlipId = slipId;
            this.slipWidth = slipWidth;
            this.slipLength = slipLength;
            this.slipDepth = slipDepth;
        }
        public bool LeasesSlip(Customer aCustomer)
        {
            bool addSlip = false;
            if ((anotherCustomer == null) && (anotherBoat == null))
            {

                anotherCustomer = aCustomer;
                aCustomer.AddSlipToCustomer(this);
                addSlip = true;
            }
            return addSlip;
        }

        private Customer anotherCustomer;

        internal Customer AnotherCustomer
        {
            get { return anotherCustomer; }
            set { anotherCustomer = value; }
        }
        private Boat anotherBoat;

        internal Boat AnotherBoat
        {
            get { return anotherBoat; }
            set { anotherBoat = value; }
        }
        //public string GetInfo()
        //{

        //    string information = string.Format("The slip Id is {0}, Slip length is {1},  Slip width  is {2} , Slip Depth is {3}, the owner is {4}, the registration number is {5}", SlipId, SlipLength, SlipWidth, SlipDepth, AnotherCustomer.CustomerName, AnotherBoat.RegistrationNumber);
        //    return information;
        //}

        public override string ToString()
        {
            
            return ("Slip Id:" +SlipId + " Slip width " + SlipWidth  + " Slip Length: "  + SlipLength);
        }
        public override bool Equals(object obj)
        {
            bool isEqual;

            Slip temp = (Slip)obj;
            if (SlipId == temp.SlipId)
                isEqual = true;
            else isEqual = false;

            return isEqual;
        }

    }
}
