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
            Sort.Merge(a, b, c);
            Program.Print(c);

            
        }

        

        public static void Print(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i);
            }

            Console.WriteLine();
        }
    }
}
