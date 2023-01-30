using System;

namespace PlayersAndMonsters
{
    class StartUp
    {
        static void Main(string[] args)
        {
           string type =Console.ReadLine();
           string username =Console.ReadLine();
            int level =int.Parse( Console.ReadLine());
            if (type=="Hero")
            {
                Hero hero = new Hero(username, level);
                Console.WriteLine(hero);
            }
            else if (type=="Elf")
            {
                Elf hero = new Elf(username, level);
                Console.WriteLine(hero);
            }
            else if (type == "MuseElf")
            {
                MuseElf hero = new MuseElf(username, level);
                Console.WriteLine(hero);
            }
            else if (type == "Wizard")
            {
                Wizard hero = new Wizard(username, level);
                Console.WriteLine(hero);
            }
            else if (type == "DarkWizard")
            {
                DarkWizard hero = new DarkWizard(username, level);
                Console.WriteLine(hero);
            }
            else if (type == "SoulMaster")
            {
                SoulMaster hero = new SoulMaster(username, level);
                Console.WriteLine(hero);
            }
            else if (type == "Knight")
            {
                Knight hero = new Knight(username, level);
                Console.WriteLine(hero);
            }
            else if (type == "DarkKnight")
            {
                DarkKnight hero = new DarkKnight(username, level);
                Console.WriteLine(hero);
            }
            else if (type == "BladeKnight")
            {
                BladeKnight hero = new BladeKnight(username, level);
                Console.WriteLine(hero);
            }

        }
    }
}
