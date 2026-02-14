using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx3
{

    class SortUtils
    {

        static public void InsertSort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int value = a[i];
                int j = i;

                for (; j > 0 && value < a[j - 1]; j--)
                {
                    a[j] = a[j - 1];
                }
                a[j] = value;
            }
        }

        static public void InsertSortGen<T>(T[] a) where T : IComparable
        {
            for (int i = 1; i < a.Length; i++)
            {
                T value = a[i];
                int j = i;

                for (; j > 0 && value.CompareTo(a[j - 1]) < 0; j--)
                {
                    a[j] = a[j - 1];
                }
                a[j] = value;
            }
        }

    }
}
