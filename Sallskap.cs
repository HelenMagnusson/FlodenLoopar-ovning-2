using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlodenLoopar
{
    class Sallskap
    {
        public List<Person> SallskapList = new();
        public int Antal { get; set; }
        public int? TotalKostnad { get; set; }

        public Sallskap()
        {
            TotalKostnad = 0;
        }
        public Person AddPerson(int id, int age)
        {
            Person p = new Person(id,age);
            p = Bio.PrisInfo(p);
            SallskapList.Add(p);
            return p;
        }
        
    }
}
