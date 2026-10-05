using System;
using System.Collections.Generic;
using System.Text;

namespace F26Week5IntroToLinq
{
    public class Employee (string? firstName, string? lastname, double salary)
    {
        public string? FirstName { get; set; } = firstName;
        public string? LastName { get; set; } = lastname;
        public double Salary { get; set; } = salary;

        public override string ToString()
        {
            return $"{FirstName,-10} {LastName,-10} {Salary,10:C}";
        }
    }
}
