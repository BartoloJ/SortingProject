namespace SortingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting Project");
            int[] arr = { 2, 1, 5, 4 };
            int[] a = { 1, 3, 5, 7 };
            int[] b = { 2, 4, 6, 8 };
            int[] c = new int[a.Length + b.Length];
            Program.Print(arr);
            Program.Print(a);
            Program.Print(b);
            Program.Merge(a, b, c);
            Program.Print(c);

            
        }

        static void Merge(int[] a, int[] b, int[] c)
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

        static void Print(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i);
            }

            Console.WriteLine();
        }
    }
}
