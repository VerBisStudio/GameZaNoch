using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZaNoch
{
    interface IWeapons
    {
        int Shop();
        int Hit();
        char Show();
        string GetName();
    }
    class Fist : IWeapons
    {
        public int Value { set; get; }
        public int Damage { set; get; }
        public char Look { set; get; }
        public string Name { set; get; }

        public Fist()
        {
            Value = 0;
            Damage = 2;
            Look = '*';
            Name = "Fist";
        }
        public int Shop()
        {
            return Value;
        }
        public int Hit()
        {
            return Damage;
        }
        public char Show()
        {
            return Look;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class Stick : IWeapons
    {
        public int Value { set; get; }
        public int Damage { set; get; }
        public char Look { set; get; }
        public string Name { set; get; }

        public Stick()
        {
            Value = 15;
            Damage = 5;
            Look = '|';
            Name = "Stick";
        }
        public int Shop()
        {
            return Value;
        }
        public int Hit()
        {
            return Damage;
        }
        public char Show()
        {
            return Look;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class baton : IWeapons
    {
        public int Value { set; get; }
        public int Damage { set; get; }
        public char Look { set; get; }
        public string Name { set; get; }

        public baton()
        {
            Value = 25;
            Damage = 10;
            Look = '!';
            Name = "baton";
        }
        public int Shop()
        {
            return Value;
        }
        public int Hit()
        {
            return Damage;
        }
        public char Show()
        {
            return Look;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class Saber : IWeapons
    {
        public int Value { set; get; }
        public int Damage { set; get; }
        public char Look { set; get; }
        public string Name { set; get; }

        public Saber()
        {
            Value = 35;
            Damage = 20;
            Look = '?';
            Name = "Saber";
        }
        public int Shop()
        {
            return Value;
        }
        public int Hit()
        {
            return Damage;
        }
        public char Show()
        {
            return Look;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class Sword : IWeapons
    {
        public int Value { set; get; }
        public int Damage { set; get; }
        public char Look { set; get; }
        public string Name { set; get; }

        public Sword()
        {
            Value = 40;
            Damage = 30;
            Look = '/';
            Name = "Sword";
        }
        public int Shop()
        {
            return Value;
        }
        public int Hit()
        {
            return Damage;
        }
        public char Show()
        {
            return Look;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class Katana : IWeapons
    {
        public int Value { set; get; }
        public int Damage { set; get; }
        public char Look { set; get; }
        public string Name { set; get; }

        public Katana()
        {
            Value = 80;
            Damage = 70;
            Look = '}';
            Name = "Katana";
        }
        public int Shop()
        {
            return Value;
        }
        public int Hit()
        {
            return Damage;
        }
        public char Show()
        {
            return Look;
        }
        public string GetName()
        {
            return Name;
        }
    }
    class Halberd : IWeapons
    {
        public int Value { set; get; }
        public int Damage { set; get; }
        public char Look { set; get; }
        public string Name { set; get; }

        public Halberd()
        {
            Value = 130;
            Damage = 100;
            Look = 'I';
            Name = "Halberd";
        }
        public int Shop()
        {
            return Value;
        }
        public int Hit()
        {
            return Damage;
        }
        public char Show()
        {
            return Look;
        }
        public string GetName()
        {
            return Name;
        }
    }
}