using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZaNoch
{
    class Witcher
    {
        public int Health { set; get; }
        public int MaxHealth { set; get; }
        public int Money { set; get; }
        public int Level { set; get; }
        public bool IsLife;
        public int Tool;
        public char InHande;

        List<IWeapons> Tools;

        public Witcher()
        {
            Health = 100;
            MaxHealth = 100;
            Money = 10;
            IsLife = true;

            Tools = new List<IWeapons>();
            Tool = 0;
            Tools.Add(new Fist());
            Tools.Add(new Stick());
            Tools.Add(new baton());
            Tools.Add(new Saber());
            Tools.Add(new Sword());
            Tools.Add(new Katana());
            Tools.Add(new Halberd());

            InHande = Tools[Tool].Show();
        }
        public Witcher(int Health, int MaxHealth, int Money, int Tool)
        {
            this.Health = Health;
            this.MaxHealth = MaxHealth;
            this.Money = Money;
            this.Tool = Tool;

            Tool = 0;
            Tools.Add(new Fist());
            Tools.Add(new Stick());
            Tools.Add(new baton());
            Tools.Add(new Saber());
            Tools.Add(new Sword());
            Tools.Add(new Katana());
            Tools.Add(new Halberd());
        }
        public bool GetGamage(IEnemy a)
        {
            if (Health > 0)
            {
                Health -= a.Attack();
            }
            else if (Health <= 0)
            {
                IsLife = false;
            }
            return IsLife;
        }
        public int Attack()
        {
            return Tools[Tool].Hit();
        }
        public void BuyWeapon()
        {
            if (Tool <= 5)
            {
                if (Money >= Tools[Tool + 1].Shop())
                {
                    Money -= Tools[Tool + 1].Shop();
                    Tool++;
                    InHande = Tools[Tool].Show();
                    
                }
                else
                {
                    Console.WriteLine("You haven't enough money");
                }
            }
            else
            {
                Console.WriteLine("You have best weapon");
            }
        }
        public string GetWeapon()
        {
            return Tools[Tool].GetName();
        }
        public void Heal()
        {
            if (Money >= 5)
            {

                if (Health >= MaxHealth - 10)
                {
                    Health = MaxHealth;
                    Money -= 5;
                }
                else if (Health == MaxHealth)
                {
                    Console.WriteLine("You are healthy");
                }
                else
                {
                    Health += 10;
                    Money -= 5;
                }
            }
            else
            {
                Console.WriteLine("You haven't enough money");
            }
        }
        public void LevelUp()
        {
            if (Level < 10)
            {
                MaxHealth += 20;
                Level++;
            }
            else
            {
                Console.WriteLine("You have max level");
            }
        }
        public void BuyArmor() //включать броню паттерном декоратор
        {
            
        }
    }
}