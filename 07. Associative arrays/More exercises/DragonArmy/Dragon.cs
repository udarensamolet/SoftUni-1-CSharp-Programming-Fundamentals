using System;
using System.Collections.Generic;
using System.Text;

namespace DragonArmy
{
    class Dragon
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public double Damage { get; set; }
        public double Health { get; set; }
        public double Armor { get; set; }

        public Dragon(string type, string name, double damage, double health, double armor)
        {
            Type = type;
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }
    }
}
