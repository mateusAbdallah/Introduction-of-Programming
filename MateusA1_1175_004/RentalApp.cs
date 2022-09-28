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
        
         public void DisplayMotto()
         {
            WriteLine("\t\tSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");
            WriteLine("\t\tS\t\t\t\t\tS");
            WriteLine("\t\tS" + "    Sam's makes it fun in the sun.    " + " S");
            WriteLine("\t\tS\t\t\t\t\tS");
            WriteLine("\t\tSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS\n");
         }

        public void DisplayInstructions()
        {
            WriteLine("This application computes rent for Kayak and Canoe.\n" +
            "It asks a customer to enter his/her first name, last name, \naddress and number of minutes he/she wanted to rent a kayak and canoe.\n" +
            "The application calculates the rental price of kayak and canoe and displays that.\n" +
            "Two tests will be performed.\n");
        }

        public string GetFullName()
        {
            WriteLine("Enter your first name:");
            string firstName = ReadLine();

            WriteLine("Enter your last name:");
            string lastName = ReadLine();

            string fullName = firstName + lastName;

            return fullName;
        }

        public string GetAddress()
        {
            WriteLine("Enter your address:");
            string address = ReadLine();

            return address;
        }

        public int GetMinutes()
        {
            WriteLine("Enter how many minutes you want:");
            string minutes = ReadLine();
            int minutesInt = int.Parse(minutes);

            return minutesInt;
        }


    }
}
