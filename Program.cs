// See https://aka.ms/new-console-template for more information
using System;

namespace CompoundInterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double principal, rate;
            int years;

            // Input validation for principal amount
            string input;
            do
            {
                Console.Write("Enter the principal amount: ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out principal) || principal <= 0);

            // Input validation for annual interest rate
            do
            {
                Console.Write("Enter the annual interest rate (e.g., 0.12 for 12%): ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out rate) || rate <= 0);

            // Input validation for number of years
            do
            {
                Console.Write("Enter the number of years: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out years) || years <= 0);

            double amount = CalculateFutureValue(principal, rate, years);
            double interest = amount - principal;

            DisplayResults(years, amount, interest);

            Console.ReadLine();
        }

        static double CalculateFutureValue(double principal, double rate, int years)
        {
            // The Math.Pow method is used to calculate the future value of the investment using the compound interest formula: 
            // FutureValue = Principal * (1 + Rate)^Years.
            return principal * Math.Pow(1 + rate, years);
        }

        static void DisplayResults(int years, double amount, double interest)
        {
            Console.WriteLine($"After {years} years, the total amount will be {amount:C}, and the interest earned will be {interest:C}.");
        }
    }
}
