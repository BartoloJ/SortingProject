using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortingProject
{
    public class Sort
    {
        public static void MergeSort(int[] arr)
        {

        }

        public static void Merge(int[] a, int[] b, int[] c)
        {
            int i = 0; int j = 0; int k = 0;
            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    c[k++] = a[i++];
                }
                else
                {
                    c[k++] = b[j++];
                }
            }

            while (i < a.Length)
            {
                c[k++] = a[i++];
            }

            while (j < b.Length)
            {
                c[k++] = b[j++];
            }
        }

    
    }
}
