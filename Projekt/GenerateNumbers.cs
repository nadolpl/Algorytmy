using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class GenerateNumbers
    {
        private int length;
        private int[] array;

        public int Length { get { return length; } }
        public int[] Array { get { return array; } }

        public GenerateNumbers(int length)
        {
            this.length = length;
            array = new int[length];
        }

        public void Ascending()
        {
            for (int i = 0; i < length; i++)
            {
                array[i] = i;
            }
        }
        public void Descending()
        {
            for (int i = 0; length > 0; i++)
            {
                array[i] = length - 1;
                length--;
            }
        }

        public void Random()
        {
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(length);
            }
        }
    }
}
