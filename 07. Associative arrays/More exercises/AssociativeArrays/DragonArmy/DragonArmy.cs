using System;
using System.Linq;
using System.Collections.Generic;

namespace DragonArmy
{
    class DragonArmy
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Dragon> dragons = new List<Dragon>();
            List<Type> types = new List<Type>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = tokens[0];
                string name = tokens[1];
                double damage = 45;
                if (tokens[2] != "null")
                {
                    damage = Convert.ToInt32(tokens[2]);
                }
                double health = 250;
                if (tokens[3] != "null")
                {
                    health = Convert.ToInt32(tokens[3]);
                }
                double armor = 10;
                if (tokens[4] != "null")
                {
                    armor = Convert.ToInt32(tokens[4]);
                }

                Dragon dragon = new Dragon(type, name, damage, health, armor);
                bool isMatchDragon = false;

                foreach (var addedDragon in dragons)
                {
                    if (addedDragon.Name == dragon.Name && addedDragon.Type == dragon.Type)
                    {
                        addedDragon.Health = dragon.Health;
                        addedDragon.Damage = dragon.Damage;
                        addedDragon.Armor = dragon.Armor;
                        isMatchDragon = true;
                        break;
                    }
                }

                if (!isMatchDragon)
                {
                    dragons.Add(dragon);
                }
            }

            foreach (var dragon in dragons)
            {
                if (!types.Any())
                {
                    Type newType = new Type(dragon.Type);
                    newType.Armor.Add(dragon.Armor);
                    newType.Damage.Add(dragon.Damage);
                    newType.Health.Add(dragon.Health);
                    types.Add(newType);
                }
                else
                {
                    bool isMatchType = false;
                    int positionMatch = 0;
                    for (int i = 0; i < types.Count; i++)
                    {
                        if (dragon.Type == types[i].Name)
                        {
                            positionMatch = i;
                            isMatchType = true;
                            break;
                        }
                    }

                    if (isMatchType)
                    {
                        types[positionMatch].Armor.Add(dragon.Armor);
                        types[positionMatch].Damage.Add(dragon.Damage);
                        types[positionMatch].Health.Add(dragon.Health);
                    }
                    else
                    {
                        Type newType = new Type(dragon.Type);
                        newType.Armor.Add(dragon.Armor);
                        newType.Damage.Add(dragon.Damage);
                        newType.Health.Add(dragon.Health);
                        types.Add(newType);
                    }
                }
            }

            foreach (var type in types)
            {
                Console.WriteLine($"{type.Name}::({type.Damage.Average():f2}/{type.Health.Average():f2}/{type.Armor.Average():f2})");
                foreach (var dragon in dragons.OrderBy(x => x.Name))
                {
                    if (dragon.Type == type.Name)
                    {
                        Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                    }
                }
            }
        }
    }
}
