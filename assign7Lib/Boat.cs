using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign7Lib
{
    public class Boat
    {
        private string registrationNumber;
        private string boatType;
        private string phoneNum;

        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        public string BoatType
        {
            get { return boatType; }
            set { boatType = value; }
        }
        
        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }
        private int boatLength;

        public int BoatLength
        {
            set { boatLength = value; }

        }
        private string boatManufacturer;

        public string BoatManufacturer
        {
            set { boatManufacturer = value; }
        }
        private string yearOfManufectoring;

        public string YearOfManufectoring
        {
            get { return yearOfManufectoring; }
            set { yearOfManufectoring = value; }
        }
        private Customer ownership;

        public Customer Ownership
        {
            get 
            {
                    return ownership;
                
            }
            set 
            {
                if (ownership == null)
                {
                    ownership = value; 
                }
               
            }
        }
       
        public Boat(string registrationNum, int boatLength, string manufacturer, string manufacYear, Customer ownership)
        {
            ownership.AddBoatToCustomer(this);
            this.RegistrationNumber = registrationNum;
            this.BoatLength = boatLength;
            this.BoatManufacturer = manufacturer;
            this.YearOfManufectoring = manufacYear;
            this.ownership = ownership;
        }
        public Boat(string registrationNum, string customerPhoneNum,string typeOfBoat,int boatLength, string manufacturer, string manufacYear)
        {
           // ownership.AddBoatToCustomer(this);
            this.RegistrationNumber = registrationNum;
            this.BoatLength = boatLength;
            this.BoatManufacturer = manufacturer;
            this.YearOfManufectoring = manufacYear;
            this.BoatType = typeOfBoat;
            this.PhoneNum = customerPhoneNum;
        }
        public Boat(string registrationNum, string typeOfBoat,int boatLength, string manufacturer, string manufacYear)
        {
           // ownership.AddBoatToCustomer(this);
            this.RegistrationNumber = registrationNum;
            this.BoatLength = boatLength;
            this.BoatManufacturer = manufacturer;
            this.YearOfManufectoring = manufacYear;
            this.BoatType = typeOfBoat;
            
        }

        public Boat()
        {
            RegistrationNumber = "111";
            BoatManufacturer = "unknown";
            ownership = null;

        }

        //public string GetInfo()
        //{

        //    string info = string.Format("The registration number is {0}, boat length, is {1}, manufacturer is {2}, year of manufactoring {3}, the owner {4}", RegistrationNumber, boatLength, boatManufacturer, yearOfManufectoring, ownership.CustomerName);
        //    return info;
        //}

        public bool AssignBoatToSlip(Slip aSlip)
        {
            bool assignABoat = false;

            if (aSlip.SlipLength >= boatLength)
            {
                assignABoat = aSlip.LeasesSlip(ownership);
                if (assignABoat)
                {
                    aSlip.AnotherBoat = this;
                }
            }
            return assignABoat;        }

        public void RemoveBoatFromSlip(Slip aSlip)
        {
            aSlip.AnotherBoat = null;
        }
       
        
        
        public override string ToString()
        {
            string outCome=("Registration number: " + registrationNumber + "\n Boat type:" + boatType  + "\n Boat length: " + boatLength + "\n Manufacturer: " + boatManufacturer + "\nYear" + yearOfManufectoring  + ownership);    
           
            return outCome ; 
        }
       
        
        public override bool Equals(object obj)
        {
            bool isEqual;
           
                Boat temp = (Boat)obj;
                if (registrationNumber == temp.registrationNumber)
                    isEqual = true;
                else isEqual = false;
            
            return isEqual;
        }

       
    }
}
