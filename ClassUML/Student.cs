using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Student : Person
    {
        public string Program { get; set; }

        public int Year { get; set; }

        public double Fee { get; set; }

        public Student(string Name, string Address, string Program, int Year, double Fee)
            : base(Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}\nProgram: {Program}\nYear: {Year}\nFee: {Fee}\n";
        }
    }
}
