using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUML
{
    class Staff : Person
    {
        public string School { get; set; }
        public double Pay { get; set; }

        public Staff(string Name, string Address, string School, double Pay)
            : base(Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}\nSchool: {School}\nPay: {Pay}\n";
        }
    }
}
