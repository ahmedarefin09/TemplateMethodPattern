using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class SortBase
    {
        public abstract int Devide(int[] numbers, int left, int right);
        public abstract void Marge(int[] numbers, int left, int mid, int right);

        public void Sort(int[] arr, int left, int right)
        {
            if (right > left)
            {
                int pivot = Devide(arr, left, right);

                if (pivot > 1)
                    Sort(arr, left, pivot);

                if (pivot + 1 < right)
                    Sort(arr, pivot + 1, right);

                Marge(arr, left, pivot + 1, right);
            }
        }
    }
}
