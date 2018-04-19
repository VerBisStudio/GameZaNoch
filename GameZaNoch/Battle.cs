using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZaNoch
{
    class Battle
    {
        Witcher Geralt;
        List<IEnemy> Enemies;

        public int Beast;
        public bool GameOver { set; get; }
        public bool IEnemyIsLife;

        public Battle()
        {
            Geralt = new Witcher();
            Enemies = new List<IEnemy>();

            Enemies.Add(new RockTroll());
            Enemies.Add(new Griffin());
            Enemies.Add(new Gargoyle());
            Enemies.Add(new Basilisk());
            Enemies.Add(new Hym());
            Enemies.Add(new Katakan());
            Enemies.Add(new Nightwraith());
            Enemies.Add(new Ekhidna());
            Enemies.Add(new Kernun());
            Enemies.Add(new Eredin());

            Beast = 0;
            GameOver = false;
            IEnemyIsLife = true;
        }
        public string GameOverWin()
        {
            return "You Win!";
        }
        public void Fight()
        {
            Geralt.Money = 1000;
            while (GameOver == false)
            {
                if (Enemies[Beast].ShowHp() <= 0)
                {
                    Geralt.LevelUp();
                    Geralt.Money += Enemies[Beast].Trophy();
                    if (Beast <=8)
                    {
                        Beast++;
                    }
                }
                ToDisplay();
                var Button = Console.ReadKey().Key;

                if (Button == ConsoleKey.Escape)
                {
                    break;
                }
                else if (Button == ConsoleKey.Q)
                {
                    IEnemyIsLife = Enemies[Beast].GetDamage(Geralt);
                    MakeStepEnemy();
                }
                else if (Button == ConsoleKey.W)
                {
                    Geralt.BuyWeapon();
                }
                else if (Button == ConsoleKey.E)
                {
                    Geralt.Heal();
                }
                if (Beast == 9 && Enemies[Beast].ShowHp() <= 0)
                {
                    Console.SetCursorPosition(2, 25);
                    Console.WriteLine(GameOverWin());
                    break;
                }
            }
        }
        public void MakeStepEnemy()
        {
            Geralt.GetGamage(Enemies[Beast]);
            if (Geralt.IsLife == false)
            {
                GameOver = true;
            }
        }
        public void ToDisplay()
        {
            Console.Clear();

            Console.SetCursorPosition(4, 2);
            Console.WriteLine("Geralt");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("Level = {0}", Geralt.Level + 1);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("Health = {0}/{1}",Geralt.Health, Geralt.MaxHealth);
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Money = {0}", Geralt.Money);
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("Weapon = {1} {0}", Geralt.InHande, Geralt.GetWeapon());
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("Power = {0}", Geralt.Attack());

            Console.SetCursorPosition(4, 10);
            Console.WriteLine("Beast");
            Console.SetCursorPosition(2, 11);
            Console.WriteLine("Name = {0}", Enemies[Beast].GetName());
            Console.SetCursorPosition(2, 12);
            Console.WriteLine("Level = {0}", Enemies[Beast].ShowLvl());
            Console.SetCursorPosition(2, 13);
            Console.WriteLine("Health = {0}", Enemies[Beast].ShowHp());
            Console.SetCursorPosition(2, 14);
            Console.WriteLine("Power = {0}", Enemies[Beast].Attack());
            Console.SetCursorPosition(2, 15);
            Console.WriteLine("Trophy = {0}", Enemies[Beast].Trophy());

            Console.SetCursorPosition(4, 19);
            Console.WriteLine("Menu");
            Console.SetCursorPosition(2, 20);
            Console.WriteLine("Q - Attack");
            Console.SetCursorPosition(2, 21);
            Console.WriteLine("W - Buy mew weapon");
            Console.SetCursorPosition(2, 22);
            Console.WriteLine("E - Buy heal");

        }
    }
}