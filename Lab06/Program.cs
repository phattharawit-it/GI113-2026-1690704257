/*
* Student ID :1690704257
* Name       :Lab06
* Section    :129D
* No.        :N/D
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Hero vs Monster: Turn Judge ===");

            int heroHp;
            int heroAtk;
            int monsterHp;
            int monsterAtk;

            Console.Write("Hero HP: ");
            if (!int.TryParse(Console.ReadLine(), out heroHp))
            {
                Console.WriteLine("Invalid input. Please enter a whole number.");
                return;
            }

            Console.Write("Hero Attack: ");
            if (!int.TryParse(Console.ReadLine(), out heroAtk))
            {
                Console.WriteLine("Invalid input. Please enter a whole number.");
                return;
            }

            Console.Write("Monster HP: ");
            if (!int.TryParse(Console.ReadLine(), out monsterHp))
            {
                Console.WriteLine("Invalid input. Please enter a whole number.");
                return;
            }

            Console.Write("Monster Attack: ");
            if (!int.TryParse(Console.ReadLine(), out monsterAtk))
            {
                Console.WriteLine("Invalid input. Please enter a whole number.");
                return;
            }

            if (heroHp <= 0 || monsterHp <= 0 || heroAtk < 0 || monsterAtk < 0)
            {
                Console.WriteLine("Invalid values. HP must be above 0 and Attack cannot be negative.");
                return;
            }

            // One round: both sides attack at the same time
            monsterHp = monsterHp - heroAtk;
            heroHp = heroHp - monsterAtk;

            Console.WriteLine("--- Round Result ---");
            Console.WriteLine("Hero HP left: " + heroHp);
            Console.WriteLine("Monster HP left: " + monsterHp);

            if (heroHp <= 0 && monsterHp <= 0)
            {
                Console.WriteLine("Result: Draw! Both fell at the same time.");
            }
            else if (monsterHp <= 0)
            {
                Console.WriteLine("Result: Hero wins!");
            }
            else if (heroHp <= 0)
            {
                Console.WriteLine("Result: Monster wins!");
            }
            else
            {
                Console.WriteLine("Result: Both survive. The fight continues!");
            }
        }
    }
}
