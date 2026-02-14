using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Item> items = new List<Item>();
            double weightLimit = 100;

            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Demo sort algorithm");
                Console.WriteLine("2. Add item for greedy algorithm");
                Console.WriteLine("3. Run greedy algorithm");
                Console.WriteLine("4. Reset list of items");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Random random = new Random();
                        int[] demoArray = new int[8];
                        for (int i = 0; i < 8; i++)
                        {
                            demoArray[i] = random.Next(0, 10);
                        }

                        Console.WriteLine("Random demo array: " + string.Join(", ", demoArray));
                        SortUtils.InsertSort(demoArray);
                        Console.WriteLine("Demo array insertion sorted: " + string.Join(", ", demoArray));

                        break;

                    case "2":
                        Console.Write("Enter item name: ");
                        string name = Console.ReadLine();
                        int value = 0;
                        while (value < 1 || value > 10)
                        {
                            Console.Write("Enter item value between 1 and 10: ");
                            value = Convert.ToInt32(Console.ReadLine());
                        }
                        double weight = 0;
                        while (weight<=0)
                        {
                            Console.Write("Enter item weight: ");
                            weight = Convert.ToInt32(Console.ReadLine());
                        }
                        Item item = new Item(name, value, weight);
                        items.Add(item);

                        break;

                    case "3":
                        List<Item> greedyItems = GreedyUtils.GetGreedyManifesto(items, weightLimit);
                        foreach (Item greedyItem in greedyItems)
                        {
                            Console.WriteLine(greedyItem.Name);
                        }

                        break;

                    case "4":
                        items = new List<Item>();
                        Console.WriteLine("Items list reset!");

                        break;

                }
            }
        }
    }
}
