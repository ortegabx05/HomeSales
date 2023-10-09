using System;

class Program
{
    public static void Main(string[] args)
    {
        double salesPersonD = 0;
        double salesPersonE = 0;
        double salesPersonF = 0;
        double grandTotal = 0;
        string initial;
        char highestSalesPerson = ' ';
        double highestTotal = 0;

        while (true)
        {
            Console.Write("Enter salesperson's initial : ");
            initial = Console.ReadLine().ToUpper();

            if (initial == "Z")
            {
                break;
            }

            double saleAmount = 0;

            switch (initial)
            {
                case "D":
                    Console.WriteLine("Enter the total amount for Danielle: ");
                    saleAmount = double.Parse(Console.ReadLine());
                    salesPersonD += saleAmount;
                    break;

                case "E":
                    Console.WriteLine("Enter the total amount for Edward: ");
                    saleAmount = double.Parse(Console.ReadLine());
                    salesPersonE += saleAmount;
                    break;

                case "F":
                    Console.WriteLine("Enter the total amount for Francis: ");
                    saleAmount = double.Parse(Console.ReadLine());
                    salesPersonF += saleAmount;
                    break;

                default:
                    Console.WriteLine("Invalid initial entered");
                    continue;
            }

            grandTotal += saleAmount;

            if (saleAmount > highestTotal)
            {
                highestTotal = saleAmount;
                highestSalesPerson = initial[0];
            }
        }

        Console.WriteLine($"Grand Total: ${grandTotal}");
        Console.WriteLine($"Highest Sale: {highestSalesPerson}");

    }
}

