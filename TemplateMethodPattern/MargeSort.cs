using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class MargeSort:SortBase
    {
        override
        public void Marge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        override
        public int Devide(int[] numbers, int left, int right)
        {
            int mid = (right + left) / 2;
            return mid;
        }
        
        //public void Sort(int[] arr, int left, int right)
        //{
        //    if (right > left)
        //    {
        //        int pivot = Devide(arr, left, right);

        //        if (pivot > 1)
        //            Sort(arr, left, pivot);

        //        if (pivot + 1 < right)
        //            Sort(arr, pivot + 1, right);

        //        Marge(arr, left, pivot + 1, right);
        //    }
        //}
    }
}
