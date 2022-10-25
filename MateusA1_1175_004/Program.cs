// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Net.Sockets;
using MateusA1_1175_004;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {

        DisplayMotto();
        DisplayInstructions();

        WriteLine("Enter you first and last name: ");
        string name = ReadLine();

        WriteLine("Enter a type do you want (canoe or kayak): ");
        string type = ReadLine();

        WriteLine("For how many minutes to you to rent: ");
        int minutes = int.Parse(ReadLine());

        RentalApp rental1 = new RentalApp(name, type);

        double total = rental1.CalculateTotal(minutes);

        WriteLine("Mr/Ms " + name + " to rent a {0} for {1} minutes would be {2:c}."
            , type, minutes, total);
        //instantiating the object

        //WriteLine("\t\tSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");
        //WriteLine("\t\tS\t\t\t\t\tS");
        //WriteLine("\t\tS" + "    Sam's makes it fun in the sun.    " + " S");
        //WriteLine("\t\tS\t\t\t\t\tS");
        //WriteLine("\t\tSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS\n");

        //RentalApp rentalApp = new RentalApp();

        //rentalApp.DisplayMotto();
        //rentalApp.DisplayInstructions();
        //rentalApp.DisplayDetails();

        ReadKey();
    }

    static void DisplayMotto()
    {
        WriteLine("\t\tSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");
        WriteLine("\t\tS\t\t\t\t\tS");
        WriteLine("\t\tS" + "    Sam's makes it fun in the sun.    " + " S");
        WriteLine("\t\tS\t\t\t\t\tS");
        WriteLine("\t\tSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS\n");
    }

    static void DisplayInstructions()
    {
        WriteLine("This application computes rent for Kayak and Canoe.\n" +
       "It asks a customer to enter his/her first name, last name, \naddress and number of minutes he/she wanted to rent a kayak and canoe.\n" +
       "The application calculates the rental price of kayak and canoe and displays that.\n" +
       "Two tests will be performed.\n");

    }

}







