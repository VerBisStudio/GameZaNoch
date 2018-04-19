using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZaNoch
{
    interface IEnemy
    {
        int ShowLvl();
        int Attack();
        int ShowHp();
        int Trophy();
        bool GetDamage(Witcher a);
        string GetName();
        //bool ShowArmor();

    }
    class RockTroll : IEnemy
    {
        public int Level { set; get; }
        public int Health { set; get; }
        public bool IsLife { set; get; }
        public int Power { set; get; }
        public int Gold { set; get; }
        public string Name { set; get; }
        //public int Armor;
        
        public RockTroll()
        {
            Level = 1;
            Health = 37;
            IsLife = true;
            Power = 3;
            Gold = 20;
            Name = "RockTroll";
        }
        public int ShowLvl()
        {
            return Level;
        }
        public int Attack()
        {
            return Power;
        }
        public int ShowHp()
        {
            return Health;
        }
        public int Trophy()
        {
            return Gold;
        }
        public bool GetDamage(Witcher a)
        {
            if (Health > 0)
            {
                Health -= a.Attack();
            }
            else
            {
                IsLife = false;
            }
            return IsLife;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class Griffin : IEnemy
    {
        public int Level { set; get; }
        public int Health { set; get; }
        public bool IsLife { set; get; }
        public int Power { set; get; }
        public int Gold { set; get; }
        public string Name { set; get; }
        //public int Armor;

        public Griffin()
        {
            Level = 2;
            Health = 50;
            IsLife = true;
            Power = 4;
            Gold = 30;
            Name = "Griffin";
        }
        public int ShowLvl()
        {
            return Level;
        }
        public int Attack()
        {
            return Power;
        }
        public int ShowHp()
        {
            return Health;
        }
        public int Trophy()
        {
            return Gold;
        }
        public bool GetDamage(Witcher a)
        {
            if (Health > 0)
            {
                Health -= a.Attack();
            }
            else
            {
                IsLife = false;
            }
            return IsLife;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class Gargoyle : IEnemy
    {
        public int Level { set; get; }
        public int Health { set; get; }
        public bool IsLife { set; get; }
        public int Power { set; get; }
        public int Gold { set; get; }
        public string Name { set; get; }
        //public int Armor;

        public Gargoyle()
        {
            Level = 3;
            Health = 55;
            IsLife = true;
            Power = 6;
            Gold = 35;
            Name = "Gargoyle";
        }
        public int ShowLvl()
        {
            return Level;
        }
        public int Attack()
        {
            return Power;
        }
        public int ShowHp()
        {
            return Health;
        }
        public int Trophy()
        {
            return Gold;
        }
        public bool GetDamage(Witcher a)
        {
            if (Health > 0)
            {
                Health -= a.Attack();
            }
            else
            {
                IsLife = false;
            }
            return IsLife;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class Basilisk : IEnemy
    {
        public int Level { set; get; }
        public int Health { set; get; }
        public bool IsLife { set; get; }
        public int Power { set; get; }
        public int Gold { set; get; }
        public string Name { set; get; }
        //public int Armor;

        public Basilisk()
        {
            Level = 4;
            Health = 70;
            IsLife = true;
            Power = 8;
            Gold = 50;
            Name = "Basilisk";
        }
        public int ShowLvl()
        {
            return Level;
        }
        public int Attack()
        {
            return Power;
        }
        public int ShowHp()
        {
            return Health;
        }
        public int Trophy()
        {
            return Gold;
        }
        public bool GetDamage(Witcher a)
        {
            if (Health > 0)
            {
                Health -= a.Attack();
            }
            else
            {
                IsLife = false;
            }
            return IsLife;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class Hym : IEnemy
    {
        public int Level { set; get; }
        public int Health { set; get; }
        public bool IsLife { set; get; }
        public int Power { set; get; }
        public int Gold { set; get; }
        public string Name { set; get; }
        //public int Armor;

        public Hym()
        {
            Level = 5;
            Health = 120;
            IsLife = true;
            Power = 12;
            Gold = 55;
            Name = "Hym";
        }
        public int ShowLvl()
        {
            return Level;
        }
        public int Attack()
        {
            return Power;
        }
        public int ShowHp()
        {
            return Health;
        }
        public int Trophy()
        {
            return Gold;
        }
        public bool GetDamage(Witcher a)
        {
            if (Health > 0)
            {
                Health -= a.Attack();
            }
            else
            {
                IsLife = false;
            }
            return IsLife;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class Katakan : IEnemy
    {
        public int Level { set; get; }
        public int Health { set; get; }
        public bool IsLife { set; get; }
        public int Power { set; get; }
        public int Gold { set; get; }
        public string Name { set; get; }
        //public int Armor;

        public Katakan()
        {
            Level = 6;
            Health = 130;
            IsLife = true;
            Power = 18;
            Gold = 50;
            Name = "Katakan";
        }
        public int ShowLvl()
        {
            return Level;
        }
        public int Attack()
        {
            return Power;
        }
        public int ShowHp()
        {
            return Health;
        }
        public int Trophy()
        {
            return Gold;
        }
        public bool GetDamage(Witcher a)
        {
            if (Health > 0)
            {
                Health -= a.Attack();
            }
            else
            {
                IsLife = false;
            }
            return IsLife;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class Nightwraith : IEnemy
    {
        public int Level { set; get; }
        public int Health { set; get; }
        public bool IsLife { set; get; }
        public int Power { set; get; }
        public int Gold { set; get; }
        public string Name { set; get; }
        //public int Armor;

        public Nightwraith()
        {
            Level = 7;
            Health = 150;
            IsLife = true;
            Power = 20;
            Gold = 70;
            Name = "Nightwraith";
        }
        public int ShowLvl()
        {
            return Level;
        }
        public int Attack()
        {
            return Power;
        }
        public int ShowHp()
        {
            return Health;
        }
        public int Trophy()
        {
            return Gold;
        }
        public bool GetDamage(Witcher a)
        {
            if (Health > 0)
            {
                Health -= a.Attack();
            }
            else
            {
                IsLife = false;
            }
            return IsLife;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class Ekhidna : IEnemy
    {
        public int Level { set; get; }
        public int Health { set; get; }
        public bool IsLife { set; get; }
        public int Power { set; get; }
        public int Gold { set; get; }
        public string Name { set; get; }
        //public int Armor;

        public Ekhidna()
        {
            Level = 8;
            Health = 175;
            IsLife = true;
            Power = 25;
            Gold = 80;
            Name = "Ekhidna";
        }
        public int ShowLvl()
        {
            return Level;
        }
        public int Attack()
        {
            return Power;
        }
        public int ShowHp()
        {
            return Health;
        }
        public int Trophy()
        {
            return Gold;
        }
        public bool GetDamage(Witcher a)
        {
            if (Health > 0)
            {
                Health -= a.Attack();
            }
            else
            {
                IsLife = false;
            }
            return IsLife;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class Kernun : IEnemy
    {
        public int Level { set; get; }
        public int Health { set; get; }
        public bool IsLife { set; get; }
        public int Power { set; get; }
        public int Gold { set; get; }
        public string Name { set; get; }
        //public int Armor;

        public Kernun()
        {
            Level = 9;
            Health = 200;
            IsLife = true;
            Power = 28;
            Gold = 100;
            Name = "Kernun";
        }
        public int ShowLvl()
        {
            return Level;
        }
        public int Attack()
        {
            return Power;
        }
        public int ShowHp()
        {
            return Health;
        }
        public int Trophy()
        {
            return Gold;
        }
        public bool GetDamage(Witcher a)
        {
            if (Health > 0)
            {
                Health -= a.Attack();
            }
            else
            {
                IsLife = false;
            }
            return IsLife;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class Eredin : IEnemy
    {
        public int Level { set; get; }
        public int Health { set; get; }
        public bool IsLife { set; get; }
        public int Power { set; get; }
        public int Gold { set; get; }
        public string Name { set; get; }
        //public int Armor;

        public Eredin()
        {
            Level = 10;
            Health = 300;
            IsLife = true;
            Power = 40;
            Gold = 200;
            Name = "Eredin";
        }
        public int ShowLvl()
        {
            return Level;
        }
        public int Attack()
        {
            return Power;
        }
        public int ShowHp()
        {
            return Health;
        }
        public int Trophy()
        {
            return Gold;
        }
        public bool GetDamage(Witcher a)
        {
            if (Health > 0)
            {
                Health -= a.Attack();
            }
            else
            {
                IsLife = false;
            }
            return IsLife;
        }
        public string GetName()
        {
            return Name;
        }
    }
}