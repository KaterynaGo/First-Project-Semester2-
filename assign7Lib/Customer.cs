using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign7Lib
{
    public class Customer
    {
        private string customerName;
        private string adressOfCustomer;
        private string customerMobPhone;

        public const int MAX_BOATS = 15;
        public const int MAX_SLIPS = 20;

        private Boat[] boats = new Boat[MAX_BOATS];

        public Boat[] Boats
        {
            get { return boats; }
            set { boats = value; }
        }
        private Slip[] slips = new Slip[MAX_SLIPS];
        private int boatCounter = 0;

        public int BoatCounter
        {
            get { return boatCounter; }
        }
        private int slipCounter = 0;


        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string AdressOfCustomer
        {
            get { return adressOfCustomer; }
            set { adressOfCustomer = value; }
        }

        public string CustomerMobPhone
        {
            get { return customerMobPhone; }
            set
            {
                string length = value + "";
                if (length.Length == 10)
                {
                    customerMobPhone = value;
                }
                else
                {
                    Console.WriteLine("wrong number");
                }
            }
        }

        public void AddBoatToCustomer(Boat aboat)
        {
            if (boatCounter < MAX_BOATS)
            {
                boats[boatCounter] = aboat;
                ++boatCounter;
            }
            else
            {
                Console.WriteLine("You are not supposed to have more than 15 boats");
            }
        }

        public void AddSlipToCustomer(Slip aslip)
        {
            if (slipCounter < MAX_SLIPS)
            {

                slips[slipCounter] = aslip;
                ++slipCounter;
            }
            else
            {
                Console.WriteLine("You are not supposed to have more than 20 slips");
            }
        }

        public Customer(string nameOfCus, string cAdress, string cTelephone)
        {
            CustomerName = nameOfCus;
            AdressOfCustomer = cAdress;
            CustomerMobPhone = cTelephone;
        }

        public string GetAnotherInfo()
        {
           string information = string.Format("");
            information += "";
            foreach (Boat item in boats)
            {

                if (item != null)
                    information += item.RegistrationNumber + " " + item.BoatType;
            }
            return information;
        }

        public string GetSlipInfo()
        {
            string slipInformation = string.Format("Owners Slips: ");
            foreach (Slip a in slips)
            {

                if (a != null)
                {

                    slipInformation += a.SlipId + " ";
                }
            }
            return slipInformation;
        }
        public override string ToString()
        {
            return (" Name:" + CustomerName + "\n Address: " + AdressOfCustomer +  "\n ph. number: " + CustomerMobPhone + " "  );
        }

        
    }
}
