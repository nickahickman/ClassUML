using System;
using System.Collections.Generic;

namespace ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Student("Student 1", "111 S Student St City, ST 11111", "Computer Science", 3, 12500.00),
                new Student("Student 2", "222 S Student St City, ST 11111", "Computer Science", 2, 12500.00),
                new Student("Student 3", "333 S Student St City, ST 11111", "Computer Science", 3, 12500.00),
                new Staff("Staff 1", "111 S Staff St City, ST 22222", "Grand Circus", 50000.00),
                new Staff("Staff 2", "222 N Staff St City, ST 22223", "Grand Circus", 55000.00),
            };

            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
