using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class SelectionSort : SortType
    {
        public SelectionSort(int[] array) : base(array) { }
        protected override void Sort(int[] array, int left, int right)
        {
            int arrayLength = array.Length;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                int smallestVal = i;

                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (array[j] < array[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                (array[i], array[smallestVal]) = (array[smallestVal], array[i]);
            }
        }
    }
}
