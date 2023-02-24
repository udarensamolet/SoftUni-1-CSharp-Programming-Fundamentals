using System;
using System.Collections.Generic;
using System.Text;

namespace DragonArmy
{
    class Type
    {
       public string Name { get; set; }
        public List<double> Damage { get; set; }

        public List<double> Health { get; set; }
        public List<double> Armor { get; set; }

        public Type(string name)
        {
            Name = name;
            Damage = new List<double>();
            Health = new List<double>();
            Armor = new List<double>();
        }
    }
}
