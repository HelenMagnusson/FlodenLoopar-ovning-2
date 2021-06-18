using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlodenLoopar
{
    class Bio
    {
        public static Person PrisInfo(Person p)
        {
            if (p.Age is null)
            {
                //return "Felinmatning. Du måste ange en ålder på personen!";
                throw new ArgumentNullException("Felinmatning. Du måste ange en ålder på personen!");
            }

            if (p.Age < 20)
            {
                p.Pris = 80;
                p.PrisText = "Ungdomspris: 80kr";
                return p;
            }
            else if (p.Age > 64)
            {
                p.Pris = 90;
                p.PrisText = "Pensionärspris: 90kr";
                return p;
            }
            else
            {
                p.Pris = 120;
                p.PrisText = "Standardpris: 80kr";
                return p;
            }
        }
        public static string PrisText(int? age)
        {
            if (age is null)
            {
                return "Felinmatning. Du måste ange en ålder på personen!";
                //throw new ArgumentNullException(nameof(age));
            }

            if (age < 20)
            {
                return "Ungdomspris: 80kr";
            }
            else if (age > 64)
            {
                return "Pensionärspris: 90kr";
            }
            else
            {
                return "Standardpris: 120kr";
            }
        }
    }


}
