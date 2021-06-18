using System;

namespace FlodenLoopar
{
    class Program
    {

        static void Main(string[] args)
        {
            bool loopOn = true;

            while (loopOn == true)
            {
                Console.WriteLine("HuvudMeny, ange en siffra för aktuellt val.");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Gå på Bio.");
                Console.WriteLine("2: Gå på Bio med sällskap.");
                Console.WriteLine("3: Upprepa angiven text 10 ggr.");
                Console.WriteLine("4: Plocka ut tredje ordet från en mening.");

                var svar = Console.ReadLine();
                
                switch (svar)
                {
                    case "0":
                        loopOn = false;
                        break;

                    case "1":
                        loopOn = true;
                        Console.WriteLine("Hur gammal är du?");
                        int? bioSvar = null;
                        bioSvar = Int16.Parse(Console.ReadLine());
                        //Hämtar prisinfo
                        Console.WriteLine(Bio.PrisText(bioSvar));
                        Console.WriteLine("");
                        break;


                    case "2":
                        loopOn = true;
                        Console.WriteLine("Hur många är ni?");
                        int sSvar = 0;
                        //Input från användare, antal i sällskapet
                        sSvar = Int16.Parse(Console.ReadLine());
                        Sallskap s = new Sallskap();
                        s.Antal = sSvar;

                        for (int i = 1; i <= sSvar; i++)
                        {
                            Console.WriteLine("Ange ålder på person " + i + "?");
                            Person person = new Person();
                            person = s.AddPerson(i, Int16.Parse(Console.ReadLine()));
                            s.TotalKostnad += person.Pris;
                        }
                        Console.WriteLine("Totalkostnad för " + s.Antal + "st biobesökare blir " + s.TotalKostnad);
                        Console.WriteLine("");
                        break;

                    case "3":
                        loopOn = true;
                        Console.WriteLine("Ange den text som du vill upprepa 10 ggr.");
                        string text = "";
                        string totText = "";
                        text = Console.ReadLine();
                        for (int i = 1; i <= 10; i++)
                        {
                            totText += $" {i}. {text}";
                        }
                        Console.WriteLine(totText);
                        Console.WriteLine("");
                        break;

                    case "4":
                        loopOn = true;
                        Console.WriteLine("För att plocka ut tredje ordet i en mening ange en mening med minst 3 ord.");
                        bool StayInLoop = true;
                        while (StayInLoop == true)
                        {
                            string mening = Console.ReadLine();


                            if (mening == "") { Console.WriteLine("Ange en mening med minst 3 ord."); }
                            else
                            {
                                string[] ord = mening.Split(' ');
                                if (ord.Length < 3) { Console.WriteLine("Ange en mening med minst 3 ord."); } else { Console.WriteLine($"Tredje ordet är: {ord[2]}"); StayInLoop = false; }
                            }

                        }
                        Console.WriteLine("");
                        break;

                    default:
                        loopOn = true;
                        Console.WriteLine("Ogiltigt val. Välj antingen 1, 2, 3 eller 4.");
                        break;

                }
            }
        }
    }
}
