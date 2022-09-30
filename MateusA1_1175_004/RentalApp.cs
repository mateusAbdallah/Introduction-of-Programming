using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MateusA1_1175_004
{
    internal class RentalApp
    {   

        //pattern message from the application
         public void DisplayMotto()
         {
            WriteLine("\t\tSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");
            WriteLine("\t\tS\t\t\t\t\tS");
            WriteLine("\t\tS" + "    Sam's makes it fun in the sun.    " + " S");
            WriteLine("\t\tS\t\t\t\t\tS");
            WriteLine("\t\tSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS\n");
         }
        //pattern message from the application
        public void DisplayInstructions()
        {
            WriteLine("This application computes rent for Kayak and Canoe.\n" +
            "It asks a customer to enter his/her first name, last name, \naddress and number of minutes he/she wanted to rent a kayak and canoe.\n" +
            "The application calculates the rental price of kayak and canoe and displays that.\n" +
            "Two tests will be performed.\n");
        }
        
        //getting the user's full name
        public string GetFullName()
        {
            WriteLine("Please enter your first name: ");
            string firstName = ReadLine();

            WriteLine("Please enter your last name: ");
            string lastName = ReadLine();

            string fullName = firstName + " " + lastName;
            

            return fullName;
        }
        //getting the user's address
        public string GetAddress()
        {
            WriteLine("Please enter your address:");
            string address = ReadLine();

            return address;
        }


        //getting the user's minutes
        public int GetMinutes()
        {
            WriteLine("Please enter how many minutes you want:");
            string minutes = ReadLine();
            int minutesInt = int.Parse(minutes);

            return minutesInt;
        }


        //display the infos in the console
        public void DisplayDetails()
        {
            string name = GetFullName();
            string address = GetAddress();
            int minutes = GetMinutes();
            


            WriteLine("\nSam's rental App");
            WriteLine("Customer name: " + name + " ");
            WriteLine("Customer address: " + address);
            WriteLine("Minutes would be rented: " + minutes);
            
        }
        


    }
}
