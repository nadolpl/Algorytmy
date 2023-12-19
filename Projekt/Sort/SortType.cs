using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal abstract class SortType
    {
        protected SortType(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }
        protected abstract void Sort(int[] array, int left, int right);
    }
}
