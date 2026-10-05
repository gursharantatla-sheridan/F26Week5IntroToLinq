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




            List<string> colors = new List<string>();
            colors.Add("bLuE");
            colors.Add("rUsT");
            colors.Add("grEEn");
            colors.Add("ReD");
            colors.Add("OranGE");

            var startsWithR = from c in colors
                              let uppercaseColor = c.ToUpper()
                              where uppercaseColor.StartsWith("R")
                              orderby uppercaseColor
                              select uppercaseColor;

            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");


            // deferred execution
            colors.Add("rUbY");
            colors.Add("yeLLow");

            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");




        }
    }
}
