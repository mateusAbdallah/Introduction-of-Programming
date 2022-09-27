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
        GetFullName();
        GetAddress();
        GetMinutes();
        

        
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

    static string GetFullName()
    {
        WriteLine("Enter your first name:");
        string firstName = ReadLine();

        WriteLine("Enter your last name:");
        string lastName = ReadLine();

        string fullName = firstName + lastName;

        return fullName;
    }

    static string GetAddress()
    {
        WriteLine("Enter your address:");
        string address = ReadLine();
        
        return address;
    }

    static int GetMinutes()
    {
        WriteLine("Enter how many minutes you want:");
        string minutes = ReadLine();
        int minutesInt = int.Parse(minutes);

        return minutesInt;
    }


}