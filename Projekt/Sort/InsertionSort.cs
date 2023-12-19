using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class InsertionSort : SortType
    {
        public InsertionSort(int[] array) : base(array) { }
        protected override void Sort(int[] array, int left, int right)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
        }
    }
}
