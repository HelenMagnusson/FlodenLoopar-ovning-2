using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlodenLoopar
{
    class Person
    {
        public int Id { get; set; }
        public int? Age { get; set; }
        public int? Pris { get; set; }
        public string PrisText { get; set; }

        public Person()
        {

        }
        public Person(int id, int age)
        {
            Id = id;
            Age = age;

        }
    }
}
