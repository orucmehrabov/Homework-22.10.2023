using Homework_22._10._2023.Helpers.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_22._10._2023
{
    internal class Person
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public Person(string email)
        {
            Email = email;
            Console.WriteLine(Email.CheckStr(@"\W"));
        }
    }
}
