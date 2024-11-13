namespace SortingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting Project");
            int[] arr = { 2, 1, 5, 4 };
            Program.Print(arr);
            int[] a = { 1, 3, 5, 7 };
            int[] b = { 2, 4, 6, 8 };
            int[] c = new int[a.Length + b.Length];
        }

        static void Merge(int[] a, int[] b, int[] c)
        {
            int i = 0; int j = 0; int k = 0;
            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    c[k] = a[i];
                    i++;
                    k++;
                }
                else
                {
                    c[k] = b[j];
                    j++;
                    k++;
                }
            }

            while (i < a.Length)
            {
                c[k] = a[i];
                i++;
                k++;
            }

            while (j < b.Length)
            {
                c[k] = b[j];
                j++;
                k++;
            }
        }

        static void Print(int[] arr)
        {
            foreach (int c in arr)
            {
                Console.Write(c);
            }
        }
    }
}
