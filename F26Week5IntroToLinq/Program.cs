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



            List<Employee> employees = new List<Employee>()
            {
                new Employee("John", "Indigo", 5000),
                new Employee("Anne", "Green", 7000),
                new Employee("James", "Indigo", 4000),
                new Employee("Alice", "Brown", 6000),
                new Employee("Matt", "Indigo", 4500),
                new Employee("Lucy", "Green", 3000)
            };

            foreach (var e in employees)
                Console.WriteLine(e);
            Console.WriteLine("\n\n");


            var between4k6k = from emp in employees
                              where emp.Salary >= 4000 && emp.Salary <= 6000
                              select emp;

            foreach (var e in between4k6k)
                Console.WriteLine(e);
            Console.WriteLine("\n\n");



            var sortedEmp = from e in employees
                            orderby e.LastName, e.FirstName
                            select e;

            foreach (var e in sortedEmp)
                Console.WriteLine(e);
            Console.WriteLine("\n\n");



            var lastnames = from e in employees
                            select e.LastName;

            foreach (var e in lastnames.Distinct())
                Console.WriteLine(e);
            Console.WriteLine("\n\n");



            var empNames = from e in employees
                           select new { e.FirstName, e.LastName };

            foreach (var e in empNames)
                Console.WriteLine(e);
            Console.WriteLine("\n\n");
        }
    }
}
