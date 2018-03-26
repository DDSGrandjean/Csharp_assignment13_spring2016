//DYLAN GRANDJEAN
//Assignment 13
//This program is designed to display monthly sales and salers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    class Main
    {
        static void Main(string[] args)
        {
            //2D array declaration
            string[,] sales = { { "Rosa",  "2500",  "35000", "20000" },
                                { "Yan",   "17000", "50000", "10000" },
                                { "Boggs", "13000", "25000", "25000" },
                                { "Cano",  "55000", "35000", "30000" } };

            DisplayAllSale(sales);
            MonthlySale(sales);
            DisplayName(sales);

            Console.Read();
        }

        private static void DisplayAllSale(string[,] array)
        {
            //Prompts user for input
            Console.WriteLine("Name\tJan\tFeb\tMar");
            //Display array rows
            for (int i = 0; i < array.GetLength(0); i++)
                Console.WriteLine(array[i, 0] + "\t" + array[i, 1] + "\t" + array[i, 2] + "\t" + array[i, 3]); 
        }

        private static void MonthlySale(string[,] array)
        {
            //Variable declaration
            int total = 0;
            int input;

            //Prompts user for input
            Console.Write("\nEnter sales month(1, 2, or 3) ");
            input = int.Parse(Console.ReadLine());

            //Calculates monthly sale
            for (int i = 0; i < array.GetLength(0); i++)
                total += int.Parse(array[i, input]);
            Console.WriteLine("Monthly sales > {0:C}", total);
        }

        private static void DisplayName(string[,] array)
        {
            //Variable declaration
            string input;
            bool found = false;
            int sales = 0;

            //Prompts user for input
            Console.Write("\nEnter name: ");
            input = Console.ReadLine();

            //Search array
            for(int i = 0; !found && i < array.GetLength(0); i++)
            {
                //If found, get sales and found is true
                if((input.ToUpper()).Equals(array[i, 0].ToUpper()))
                {
                    sales = (int.Parse(array[i, 1])) + (int.Parse(array[i, 2])) + (int.Parse(array[i, 3]));
                    found = true;
                }
            }

            //Diplay results if found else. display error message
            if (found)
                Console.WriteLine("{0}'s sales are {1:C}", input, sales);
            else
                Console.WriteLine("Not found");
        }
    }
}
