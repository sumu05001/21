using System;
namespace BlackJack
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Black Jack!");
            string senastevinnaren = ("Ingen har vunnit än");
            //  Alternativer
            string Alternativ = "0";
            while (Alternativ != "4")
            {
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta programmet");
                Alternativ = Console.ReadLine();
                Console.WriteLine();
                
                switch (Alternativ)
                {
                    // Spela 21:an(1)
                    case "1":
                        Random slump = new Random();
                        int datornsPoäng = 0;
                        int spelarensPoäng = 0;
                        Console.WriteLine("Nu kommer två kort dras per spelare");
                        datornsPoäng += slump.Next(1, 11);
                        datornsPoäng += slump.Next(1, 11);
                        spelarensPoäng += slump.Next(1, 11);
                        spelarensPoäng += slump.Next(1, 11);

                        // Om man vill dra fler kort
                        string kortVal = "";
                        while (kortVal != "n" && spelarensPoäng <= 21)
                        {
                            Console.WriteLine($"Din poäng: {spelarensPoäng}");
                            Console.WriteLine($"Datorns poäng: {datornsPoäng}");
                            Console.WriteLine("Vill du ha ett till kort? (j/n)");
                            kortVal = Console.ReadLine();

                            switch (kortVal)
                            {
                                case "j":
                                    int nyPoäng = slump.Next(1, 11);
                                    spelarensPoäng += nyPoäng;
                                    Console.WriteLine($"Ditt nya kort är värt {nyPoäng} poäng");
                                    Console.WriteLine($"Din totalpoäng är {spelarensPoäng}");
                                    break;

                                case "n":
                                    break;
                                default:
                                    Console.WriteLine("Du valde inte ett giltigt alternativ");
                                    break;
                            }
                        }
                        if (spelarensPoäng > 21)
                        {
                            Console.WriteLine("Du har mer än 21 och har förlorat");
                            break;
                        }

                        while (datornsPoäng < spelarensPoäng && datornsPoäng <= 21)
                        {
                            int datornsNyaPoäng = slump.Next(1, 11);
                            datornsPoäng += datornsNyaPoäng;
                            Console.WriteLine($"Datorn drog ett kort värt {datornsNyaPoäng}");
                        }

                        Console.WriteLine($"Din poäng: {spelarensPoäng}");
                        Console.WriteLine($"Datorns poäng: {datornsPoäng}");

                        // Undersök vem som vann
                        if (datornsPoäng > 21)
                        {
                            Console.WriteLine("Du har vunnit!");
                            Console.WriteLine("Skriv in ditt namn");
                            senastevinnaren = Console.ReadLine();
                             
                        }
                        else
                        {
                            Console.WriteLine("Datorn har vunnit!");
                        }

                        break;

                        // Visa senaste vinnaren(2)
                        case "2":
                        Console.WriteLine($"Senaste vinnaren: {senastevinnaren}");
                        break;

                    // Visa spelets regler(3)
                    case "3":
                        Console.WriteLine("Ditt mål är att tvinga datorn att få mer än 21 poäng.");
                        Console.WriteLine("Du får poäng genom att dra kort, varje kort har 1-10 poäng.");
                        Console.WriteLine("Om du får mer än 21 poäng har du förlorat.");
                        Console.WriteLine("Både du och datorn får två kort i början. Därefter får du");
                        Console.WriteLine("dra fler kort tills du är nöjd eller får över 21.");
                        Console.WriteLine("När du är färdig drar datorn kort till den har");
                        break;

                    // programmet avslutas(4)
                    case "4":
                        break;

                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}