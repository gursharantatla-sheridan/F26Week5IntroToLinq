namespace F26Week5IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 3, 6, 4, 8, 9, 7, 1, 2, 5, 4, 6, 7 };

            // query syntax
            var greaterThan4 = from n in arr
                               where n > 4
                               orderby n
                               select n;

            foreach (var i in greaterThan4)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");


            // method syntax
            var lessThan5 = arr.Where(n => n < 5).OrderByDescending(n => n);

            foreach (var i in lessThan5)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");
        }
    }
}
