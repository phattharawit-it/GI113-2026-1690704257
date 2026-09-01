namespace Lap02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ﻿/*
 * Student ID :1690704067
 * Name       :Lap02
 * Section    :129D
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string bossnaem = "kirin";
            char rank = 's';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;


            Console.WriteLine("=====BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossnaem}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Max HP: {maxHp}");
            Console.WriteLine($"Current HP: {currentHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("=====BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            
            Console.WriteLine("=====Fantasy World =====");
            //ชื่อตัวละคร
            string humanName = "Yasuo";
            string dwarfName = "Gimli";
            string elfName   = "Legolas";
            string orcName   = "Thrall";
            // ระดับของตัวละคร
            char humanRank   = 'A';
            char dwarfRank   = 'B';
            char elfRank     = 'C';
            char orcRank     = 'C';
            // เผ่าพันธุ์ของตัวละคร
            string raceYasuo   = "human";
            string raceGimli   = "dwarf";
            string raceLegolas = "elf";
            string raceThrall  = "orc";
            // อาชีพของตัวละคร
            string classYasuo   = "swordsman";
            string classGimoli  = "cleric";
            string classLegolas = "archer";
            string classThrall  = "shaman";
            // เลเวลของตัวละคร
            int levelYasuo   = 5;
            int levelGimoli  = 4;
            int levelLegolas = 3;
            int levelThrall  = 3;
            // ค่าพลังโจมตีของตัวละคร
            float attackPowerYasuo   = 16.5f;
            float attackPowerGimoli  = 10.0f;
            float attackPowerLegolas = 20.6f;
            float attackPoewerThrall = 12.5f;
            // ค่าพลังชีวิตของตัวละคร
            int maxHpYasuo   = 100;
            int maxHpGimpli  = 140;
            int maxHpLegolas = 70;
            int maxHpThrall  = 100;
            // ค่าตัวคูณคริติคอลของตัวละคร
            double critMultiplierYasuo   = 1.4;
            double critMultiplierGimpli  = 1.2;
            double critMultiplierLegolas = 1.8;
            double critMultiplierThrall  = 1.3;
            // สถานะการเป็นสมาชิกปาร์ตี้ของตัวละคร
            bool isPartyMemberYasuo   = true;
            bool isPartyMemberGimpli  = true;
            bool isPartyMemberLegolas = true;
            bool isPartyMemberThrall  = false;


            Console.WriteLine("=====CHARACTER STATUS: INITIAL =====");
            Console.WriteLine($"Name: {humanName}");
            Console.WriteLine($"Rank: {humanRank}");
            Console.WriteLine($"Race: {raceYasuo}");
            Console.WriteLine($"Class: {classYasuo}");
            Console.WriteLine($"Level: {levelYasuo}");
            Console.WriteLine($"Max HP: {maxHpYasuo}");
            Console.WriteLine($"Attack Power: {attackPowerYasuo}");
            Console.WriteLine($"Critical Multiplier: {critMultiplierYasuo}");
            Console.WriteLine($"Is Party Member: {isPartyMemberYasuo}");
            Console.WriteLine();
            Console.WriteLine($"Name: {dwarfName}");
            Console.WriteLine($"Rangk: {dwarfRank}");
            Console.WriteLine($"Race: {raceGimli}");
            Console.WriteLine($"Class: {classGimoli}");
            Console.WriteLine($"Level: {levelGimoli}");
            Console.WriteLine($"Max HP: {maxHpGimpli}");
            Console.WriteLine($"Attack Power: {attackPowerGimoli}");
            Console.WriteLine($"Critical Multiplier: {critMultiplierGimpli}");
            Console.WriteLine($"Is Party Member: {isPartyMemberGimpli}");
            Console.WriteLine();
            Console.WriteLine($"Name: {elfName}");
            Console.WriteLine($"Rank: {elfRank}");
            Console.WriteLine($"Race: {raceLegolas}");
            Console.WriteLine($"Class: {classLegolas}");
            Console.WriteLine($"Level: {levelLegolas}");
            Console.WriteLine($"Max HP: {maxHpLegolas}");
            Console.WriteLine($"Attack Power: {attackPowerLegolas}");
            Console.WriteLine($"Critical Multiplier: {critMultiplierLegolas}");
            Console.WriteLine($"Is Party Member: {isPartyMemberLegolas}");
            Console.WriteLine();
            Console.WriteLine($"Name: {orcName}");
            Console.WriteLine($"Rank: {orcRank}");
            Console.WriteLine($"Race: {raceThrall}");
            Console.WriteLine($"Class: {classThrall}");
            Console.WriteLine($"Level: {levelThrall}");
            Console.WriteLine($"Max HP: {maxHpThrall}");
            Console.WriteLine($"Attack Power: {attackPoewerThrall}");
            Console.WriteLine($"Critical Multiplier: {critMultiplierThrall}");
            Console.WriteLine($"Is Party Member: {isPartyMemberThrall}");
            Console.WriteLine();







        }
    }
}
        }
    }
}
