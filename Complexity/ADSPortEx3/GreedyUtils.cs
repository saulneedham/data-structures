using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{
    class GreedyUtils
    {

        public static List<Item> GetGreedyManifesto(List<Item> items, double limit)
        {
            Item[] itemArray = items.ToArray();
            SortUtils.InsertSortGen(itemArray);
            items = itemArray.ToList();  //Array sorted decsending by valRatio

            List<Item> greedyItems = new List<Item>();

            foreach (Item item in items)
            {
                Boolean limitReached = false;
                while (limitReached == false) {
                    if (item.Weight <= limit)
                    {
                        limit -= item.Weight;
                        greedyItems.Add(item);
                    }
                    else
                    {
                        limitReached = true;
                    }
                }
            }

            return greedyItems;
        }
    }
}
