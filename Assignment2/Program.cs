
/*
 * Student ID :1690704257
 * Name       :Assignment2
 * Section    :129D
 * No.        :N/D
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Mythril";
            const double SmeltRate = 0.15;
            const double SalvageRate = 0.20;
            const double MaxBatch = 999;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("===================================");
            Console.WriteLine("==   THE DRAGON'S FORGE (v1.0)   ==");
            Console.WriteLine("==  Where legends are hammered   ==");
            Console.WriteLine("===================================");
            Console.ResetColor();

            Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate} / Salvage {SalvageRate}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            Console.Write("=> Choose Menu: ");
            string menuInput = Console.ReadLine();
            bool isMenuParsed = char.TryParse(menuInput, out char menu);

            Console.Write("=> How much would you like: ");
            string amountInput = Console.ReadLine();
            bool isAmountParsed = double.TryParse(amountInput, out double amount);
            bool isAmountValid = isAmountParsed && amount > 0 && amount <= MaxBatch;
            

            if (isMenuParsed)
            {
                if (isMenuParsed && (menu != 'S' && menu != 's' && menu != 'B' && menu != 'b'))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" error: invalid menu. The blacksmith only knows 'S' or 'B' (one key).");
                    Console.ResetColor();
                }
                else if (!isAmountValid)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" => error: invalid amount. Enter a number greater than 0 and up to {MaxBatch}.");
                    Console.ResetColor();
                }
                else if (isMenuParsed && (menu == 'S' || menu == 's'))
                {
                    double ingot = amount * SmeltRate;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("*clang clang* The furnace roars to life!");
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {ingot:F2} {MaterialName} Ingot");
                    Console.ResetColor();
                }
                else if (isMenuParsed && (menu == 'B' || menu == 'b'))
                {
                    double ore = amount / SalvageRate;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("*crack* The ingot shatters back into raw ore!");
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ingot = {ore:F2} {MaterialName} Ore");
                    Console.ResetColor();
                }


            }
        }
    }

 }
