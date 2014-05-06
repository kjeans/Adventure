using System;

namespace Adventure
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Je staat aan de kust. Het is een wonder dat het water nog niet bevroren is in deze kou. De boot waarmee je bent aangekomen, is allang vertrokken.");
            Console.WriteLine("Wat wil je doen?");
            Console.WriteLine("Keuze: Oost");
            string Direction = Console.ReadLine();

            if (Direction == "Oost" || Direction == "oost") 
            {
                Console.WriteLine("Je staat buiten in de kou. Het sneeuwt en je wilt zo snel mogelijk naar binnen. Richting het noorden zie je licht branden.");
                Console.WriteLine("Wat wil je doen?");
                Console.WriteLine("Keuze: Noord, Oost, Zuid, West");
                string DirectionStart = Console.ReadLine();


                if (DirectionStart == "Noord" || DirectionStart == "noord")
                {
                    Console.WriteLine("Je staat voor een huis. Binnen brand licht en door het raam zie je een brandende open haard, maar geen mensen.");
                    Console.WriteLine("Wat wil je doen?");
                    Console.WriteLine("Keuze: Zuid, Deur");
                    string DirectionHouse = Console.ReadLine();
                    if(DirectionHouse == "Zuid" || DirectionHouse == "zuid")
                    {
                        Console.WriteLine("Nog niet klaar...");
                        Console.WriteLine("Je staat buiten in de kou. Het sneeuwt en je wilt zo snel mogelijk naar binnen. Richting het noorden zie je licht branden.");
                        Console.WriteLine("Wat wil je doen?");
                        Console.WriteLine("Keuze: Noord, Oost, Zuid, West");
                    }
                    else if (DirectionHouse == "Deur" || DirectionHouse == "deur") 
                    {
                        Console.WriteLine("Nog niet klaar...");
                        Console.WriteLine("Je klopt op de deur, maar niemand doet open. Je wilt naar binnen; het is koud!");
                        Console.WriteLine("Wat wil je doen?");
                        Console.WriteLine("Keuze: Zuid");
                    }
                }




                else if (DirectionStart == "Oost" || DirectionStart == "oost")
                {
                    Console.WriteLine("Je staat voor een kerk. Door het raam zie je belichting van kaarsen en fakkels. Maar er zijn geen mensen aanwezig.");
                    Console.WriteLine("Wat wil je doen?");
                    Console.WriteLine("Keuze: West, Binnen");
                    string DirectionChurch = Console.ReadLine();
                    if (DirectionChurch == "West" || DirectionChurch == "west")
                    {
                        Console.WriteLine("Nog niet klaar...");
                        Console.WriteLine("Je staat buiten in de kou. Het sneeuwt en je wilt zo snel mogelijk naar binnen. Richting het noorden zie je licht branden.");
                        Console.WriteLine("Wat wil je doen?");
                        Console.WriteLine("Keuze: Noord, Oost, Zuid, West");
                    }
                    else if (DirectionChurch == "Binnen" || DirectionChurch == "binnen")
                    {
                        Console.WriteLine("Nog niet klaar...");
                        Console.WriteLine("Je pakt de fakkel op en neemt hem mee.");
                        Console.WriteLine("Wat wil je doen?");
                        Console.WriteLine("Keuze: West");
                    }
                }




                else if (DirectionStart == "Zuid" || DirectionStart == "zuid")
                {
                    Console.WriteLine("Je staat aan de rand van een donker bos. Je bent niet van plan om met dit weer het bos te gaan verkennen.");
                    Console.WriteLine("Wat wil je doen?");
                    Console.WriteLine("Keuze: Noord, Water");
                    string DirectionForest = Console.ReadLine();
                    if (DirectionForest == "Noord" || DirectionForest == "noord")
                    {
                        Console.WriteLine("Nog niet klaar...");
                        Console.WriteLine("Je staat buiten in de kou. Het sneeuwt en je wilt zo snel mogelijk naar binnen. Richting het noorden zie je licht branden.");
                        Console.WriteLine("Wat wil je doen?");
                        Console.WriteLine("Keuze: Noord, Oost, Zuid, West");
                    }
                    else if (DirectionForest == "Water" || DirectionForest == "water")
                    {
                        Console.WriteLine("Nog niet klaar...");
                        Console.WriteLine("Je loopt verder het bos in en komt een eenhoorn tegen bij het water.");
                        Console.WriteLine("Wat wil je doen?");
                        Console.WriteLine("Keuze: Noord, Eenhoorn");
                    }
                }




                else if (DirectionStart == "West" || DirectionStart == "west")
                {
                    Console.WriteLine("Je staat aan de kust. Het is een wonder dat het water nog niet bevroren is in deze kou. De boot waarmee je bent aangekomen, is allang vertrokken.");
                    Console.WriteLine("Wat wil je doen?");
                    Console.WriteLine("Keuze: Oost");
                    string DirectionCoast = Console.ReadLine();
                    if (DirectionCoast == "Oost" || DirectionCoast == "oost")
                    {
                        Console.WriteLine("Nog niet klaar...");
                        Console.WriteLine("Je staat buiten in de kou. Het sneeuwt en je wilt zo snel mogelijk naar binnen. Richting het noorden zie je licht branden.");
                        Console.WriteLine("Wat wil je doen?");
                        Console.WriteLine("Keuze: Noord, Oost, Zuid, West");
                    }
                }
            }

        }

        private static object House()
        {
            throw new NotImplementedException();
        }
    }
}
