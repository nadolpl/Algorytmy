using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class QuickSort : SortType
    {
        public QuickSort(int[] array) : base(array) { }
        protected override void Sort(int[] array, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = array[(left + right) / 2];
            while (i < j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;
                if (i <= j)
                {
                    int tmp = array[i];
                    array[i++] = array[j];
                    array[j--] = tmp;
                }
            }
            if (left < j) Sort(array, left, j);
            if (i < right) Sort(array, i, right);
        }
    }
}
