

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gane Titie , Subtitle
            Console.WriteLine("===>> MY VIDIO GAME <<==");
            Console.WriteLine("Hero Vs. Monster -- Fight Damage Calculator\n");

            // Hero stats input HP , ATK, DEF
            Console.WriteLine("Hero Health: ");
            bool heroHpOK = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack: ");
            bool heroAtkOK = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("Hero Defense: ");
            bool heroDefOK = int.TryParse(Console.ReadLine(), out int heroDef);

            // Monster stats input HP , ATK, DEF
            Console.WriteLine("Monster Health: ");
            bool monsterHpOK = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.WriteLine("Monster Attack: ");
            bool monsterAtkOK = int.TryParse(Console.ReadLine(), out int monsterAtk);
            Console.WriteLine("Monster Defense: ");
            bool monsterDefOK = int.TryParse(Console.ReadLine(), out int monsterDef);

            // Input vallidation / output
            bool heroStatValid = heroHpOK && heroAtkOK && heroDefOK;
            bool monsterStatValid = monsterHpOK && monsterAtkOK && monsterDefOK;
            Console.WriteLine($"\n Hero Stats: {heroStatValid} ");
            Console.WriteLine($" Monster Stats: {monsterStatValid} ");

            Console.WriteLine($"[HERO] HP: {heroHp} ATK: {heroAtk} DEF: {heroDef}");
            Console.WriteLine($"[MONSTER] HP: {monsterHp} ATK: {monsterAtk} DEF: {monsterDef}");

            // bool allSatOk = heroStatValid && monsterStatValid;

            // Coompound Assign & Arithmetic (+) ผู้เล่นดื่มยาก่อนต่อสู้
            int potionHeal = 5;

            heroHp += potionHeal;
            //heroHp = heroHp + potionHeal;
            Console.WriteLine($"\nHero drinks a potion, heals {potionHeal} HP. New Hero HP: {heroHp}");

            // Nomal Attack RPG style combat ATK > DEF ถึงจะมีดาเมจต่อศัตรู
            int normalDamage =Math.Max(0, heroAtk - monsterDef);
            Console.WriteLine($"Hero would deals  normal attack: {normalDamage}");

            // Power ATK
            int powerDamage = Math.Max(0, (heroAtk * 2) - monsterDef);
            Console.WriteLine($"Hero would deals  power attack: {powerDamage}");

            // Random Critical ATK
            Random rng = new Random();
            int critRoll = rng.Next(1, 101);
            bool isCrit = critRoll <= 25; // 25% chance for critical hit

            int critDmg = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // Double damage on crit
            Console.WriteLine($"Crit Roll {critRoll}. Critical Hit: {isCrit}");
            Console.WriteLine($"If critical hit player would deal: {critDmg} DMG!!"); 
        }
    }
}
