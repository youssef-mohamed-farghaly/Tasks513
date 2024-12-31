using System.Globalization;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            int CarpetSmall = 25;
            int CarpetLarge = 35;
            double TaxRate = .06;
            Console.WriteLine("Hello in carpet cleaning service");
            Console.Write("Number of small carpets : ");
            int NumSmall = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of Large carpets : ");
            int NumLarge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Price per small carpet : {CarpetSmall:C}");
            Console.WriteLine($"Price per Large carpet : {CarpetLarge:C}");
            int PriceSmall = NumSmall * CarpetSmall;
            int PriceLarge = NumLarge * CarpetLarge;
            int Cost = PriceSmall + PriceLarge;
            double Tax = Cost * TaxRate;
            double Total = Tax + Cost;
            Console.WriteLine($"Cost : {Cost:C}");
            Console.WriteLine($"Tax : {Tax:C}");
            Console.WriteLine($"Total estimate : {Total:C}");
            Console.WriteLine("This estimate is valid for 30 days.");
        }
    }
}

