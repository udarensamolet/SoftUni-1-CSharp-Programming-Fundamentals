namespace ShoppingSpree
{
    class ShoppingSpree
    {
        static void Main()
        {
            string[] peopleInfo = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] productsInfo = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<Person> people = new List<Person>();
            for (int i = 0; i < peopleInfo.Length; i++)
            {
                string[] tokens = peopleInfo[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = tokens[0];
                double money = Convert.ToDouble(tokens[1]);
                Person person = new Person(name, money);
                people.Add(person);
            }

            List<Product> products = new List<Product>();
            for (int i = 0; i < productsInfo.Length; i++)
            {
                string[] tokens = productsInfo[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = tokens[0];
                double cost = Convert.ToDouble(tokens[1]);
                Product product = new Product(name, cost);
                products.Add(product);
            }

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (input[0] == "END")
                {
                    break;
                }

                string person = input[0];
                string product = input[1];

                double cost = products.FirstOrDefault(x => x.Name == product).Cost;
                Person targetedPerson = people.FirstOrDefault(x => x.Name == person);
                Product targetedProduct = products.FirstOrDefault(x => x.Name == product);
                if (targetedPerson.Money >= cost)
                {
                    targetedPerson.Products.Add(targetedProduct);
                    targetedPerson.Money -= cost;
                    Console.WriteLine($"{person} bought {product}");
                }
                else
                {
                    Console.WriteLine($"{person} can't afford {product}");
                }
            }

            foreach (var person in people)
            {
                Console.Write($"{person.Name} - ");
                if (!person.Products.Any())
                {
                    Console.WriteLine("Nothing bought");

                }
                else
                {
                    for (int i = 0; i < person.Products.Count; i++)
                    {
                        if (i == person.Products.Count - 1)
                        {
                            Console.Write($"{person.Products[i].Name}");
                        }
                        else
                        {
                            Console.Write($"{person.Products[i].Name}, ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}