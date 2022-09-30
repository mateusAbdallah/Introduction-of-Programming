// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Net.Sockets;
using MateusA1_1175_004;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        //instantiating the object
        RentalApp rentalApp = new RentalApp();

        rentalApp.DisplayMotto();
        rentalApp.DisplayInstructions();
        rentalApp.DisplayDetails();

        ReadKey();
    }

     




}