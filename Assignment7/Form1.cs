using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using assign7Lib;

namespace Assignment7
{

    public partial class Form1 : Form
    {
        const int MAX_NUMBER_OF_CUSTOMERS = 400;
        Customer[] arrayOfCustomers = new Customer[MAX_NUMBER_OF_CUSTOMERS];
        int indexSelectedBoat;
        int indexSelectedCust;
        const char DELIM = ',';

        Boat[] boatArray = new Boat[20];
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLoadCustom_Click(object sender, EventArgs e)
        {

            string fileName = txtCustFilePath.Text;


            
            string[] fields;
            string record;
            FileStream inFile = null;
            StreamReader reader = null;


            bool filefound = true;

            do
            {
                if (!filefound)
                {
                    fileName = Convert.ToString(Console.ReadLine());
                }
                try
                {

                    inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    filefound = true;
                    reader = new StreamReader(inFile);
                    record = reader.ReadLine();

                    int i = 0;
                    while (record != null)
                    {
                        fields = record.Split(DELIM);
                        arrayOfCustomers[i] = new Customer(fields[0], fields[1],fields[2]);
                        record = reader.ReadLine();
                        i++;
                    }

                    foreach (var part in arrayOfCustomers)
                    {
                        if (part != null)
                        {
                            lstOfCustomers.Items.Add(part.CustomerName + "," + part.CustomerMobPhone);
                        }
                        else
                        {
                            break;
                        }
                    }

                }


                catch (FileNotFoundException fileNotfounde)
                {
                    MessageBox.Show("Caught in my own catch block, Exception  fileNotfounde: " + fileNotfounde.Message);
                    filefound = false;
                }

                catch (ArgumentException notCorrectArguments)
                {
                    MessageBox.Show(notCorrectArguments.Message);
                }

                catch (Exception overAllException)
                {
                    MessageBox.Show("Something went wrong: " + overAllException.Message);
                }

                finally
                {
                    reader.Close();
                    inFile.Close();
                }
            } while (!filefound);

        }

        private void lstOfCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexSelectedCust = lstOfCustomers.SelectedIndex;
            lblCustomInfo.Text = arrayOfCustomers[indexSelectedCust].ToString();


            // MessageBox.Show(arrayOfCustomers[index].ToString());

            int numberOfBoats = arrayOfCustomers[indexSelectedCust].BoatCounter;
            if (numberOfBoats >0)
            {
                //string textForBoatsOwned = "";
                for (int k = 0; k < numberOfBoats; k++)
               {
                       lblBoatsOwned.Text = arrayOfCustomers[indexSelectedCust].GetAnotherInfo() ;
                  
                }
                
               
            }
            else
            {
                lblBoatsOwned.Text = "";
            }
        }

        private void btnLoadBoats_Click(object sender, EventArgs e)
        {
            string fileName = txtBoatFilePath.Text;

            const char DELIM = ',';
            string[] fields;
            string record;
            FileStream inFile = null;
            StreamReader reader = null;

            bool filefound = true;

             do
            {
                if (!filefound)
                {
                    fileName = Convert.ToString(Console.ReadLine());
                }
                try
                {

                    inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    filefound = true;
                    reader = new StreamReader(inFile);
                    record = reader.ReadLine();

                    int i = 0;
                    while (record != null)
                    {
                        fields = record.Split(DELIM);
                        if(fields.Length==6)
                        {
                                boatArray[i] = new Boat(fields[0], fields[1], fields[2], Convert.ToInt32(fields[3]), fields[4], fields[5]);
                        }
                        
                      else 
                        {
                                boatArray[i] = new Boat(fields[0],fields[1], Convert.ToInt32(fields[2]), fields[3], fields[4]);
                        }
                        record = reader.ReadLine();
                        i++;
                    }

                    foreach (var part in boatArray)
                    {
                        if (part != null)
                        {
                          lstOfBoats.Items.Add(part.RegistrationNumber+", " + part.BoatType);
                        }
                        else
                        {
                            break;
                        }
                    }

                }
            

               catch (FileNotFoundException fileNotfounde)
                {
                    MessageBox.Show("Caught in my own catch block, Exception  fileNotfounde: " + fileNotfounde.Message);
                    filefound = false;
                }

                catch (ArgumentException notCorrectArguments)
                {
                    MessageBox.Show(notCorrectArguments.Message);
                }

                catch (Exception overAllException)
                {
                    MessageBox.Show("Something went wrong: " + overAllException.Message);
                }

                finally
                {
                    reader.Close();
                    inFile.Close();
                }
            } while (!filefound);

           
        }
        

         
        


        private void btnAssignBoat_Click(object sender, EventArgs e)
        {
            if (boatArray[indexSelectedBoat].Ownership == null & boatArray[indexSelectedBoat].PhoneNum==null)
            {
                boatArray[indexSelectedBoat].Ownership = arrayOfCustomers[indexSelectedCust];

                boatArray[indexSelectedBoat].Ownership.AddBoatToCustomer(boatArray[indexSelectedBoat]);
                MessageBox.Show("Assigned boat to a customer: " + boatArray[indexSelectedBoat].Ownership.ToString());
               
            }
            else
            {
                MessageBox.Show("The boat can not be assigned, it already has an owner!!!");
            }
        }

        private void lstOfBoats_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexSelectedBoat = lstOfBoats.SelectedIndex;
            lblBoatInfo.Text = boatArray[indexSelectedBoat].ToString();
        }

        private void btnSaveBoats_Click(object sender, EventArgs e)
        {
             FileStream outFile = new FileStream("NewRecord.txt",FileMode.Create, FileAccess.Write);
             StreamWriter writer = new StreamWriter(outFile);
             
            
            for(int i = 0;i<boatArray.Length;i++)
            {
                if (boatArray[i]!=null)
                {
                    writer.WriteLine(boatArray[i].ToString());
                }
                else
                {
                    break;
                }
                
            }
            writer.Close();
            outFile.Close();

        }
      
       }
         
     
   }
    


