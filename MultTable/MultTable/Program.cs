using System;

namespace MultTable {
    internal class Program {
        static void Main(string[] args) {

            // Making a Multiplication Table
            // Desenvolva um código que monte a tabuada de qualquer número solicitado pela Mallu.

            Console.Write("What number would you like to know the multiplication table: ");
            double table = double.Parse(Console.ReadLine());
            // int i = 1;
            while (true) {
                Console.WriteLine($"The multiplication table of the {table} is: ");
                for (double count = 1; count <= 10; count++) {
                    Console.WriteLine($"{table} * {count} = {table * count}");
                }
                Console.Write("Would you like contining [0 = no; 1 = yes]");
                double continua = double.Parse(Console.ReadLine());
                if (continua == 0) {
                    Console.WriteLine("You choice to finish the program");
                    break;
                }
                else {
                    //while (continua == 1) {
                    Console.Write("What number would you like to know the multiplication table: ");
                    double table1 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The multiplication table of the {table} is: ");
                    for (double count = 1; count <= 10; count++) {
                        //continua = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{table1} * {count} = {table1 * count}");
                    }
                }
            }
        }
    }
}
