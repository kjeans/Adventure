using System;

namespace Adventure
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Je staat aan de kust. Het is een wonder dat het water nog niet bevroren is in deze kou. De boot waarmee je bent aangekomen, is allang vertrokken.");
            Console.WriteLine("Wat wil je doen?");
            Console.WriteLine("1: Oost");
            string direction = Console.ReadLine();

            if (direction == "1") 
            {
                Console.WriteLine("Je staat buiten in de kou. Het sneeuwt en je wilt zo snel mogelijk naar binnen. Richting het noorden zie je licht branden.");
                Console.WriteLine("Wat wil je doen?");
                Console.WriteLine("1: Noord, 2: Oost, 3: Zuid, 4: West");
                string directionStart = Console.ReadLine();


                if (directionStart == "1")
                {
                    Console.WriteLine("Je staat voor een huis. Binnen brand licht en door het raam zie je een brandende open haard, maar geen mensen.");
                    Console.WriteLine("Wat wil je doen?");
                    Console.WriteLine("1: Zuid, 2: Deur");
                    string directionHouse = Console.ReadLine();
                    if (directionHouse == "1")
                    {
                        Console.WriteLine("Nog niet klaar...");
                        Console.WriteLine("Je staat buiten in de kou. Het sneeuwt en je wilt zo snel mogelijk naar binnen. Richting het noorden zie je licht branden.");
                        Console.WriteLine("Wat wil je doen?");
                        Console.WriteLine("Keuze: Noord, Oost, Zuid, West");
                    }
                    else if (directionHouse == "2") 
                    {
                        Console.WriteLine("Nog niet klaar...");
                        Console.WriteLine("Je klopt op de deur, maar niemand doet open. Je wilt naar binnen; het is koud!");
                        Console.WriteLine("Wat wil je doen?");
                        Console.WriteLine("Keuze: Zuid");
                    }
                }




                else if (directionStart == "2")
                {
                    Console.WriteLine("Je staat voor een kerk. Door het raam zie je belichting van kaarsen en fakkels. Maar er zijn geen mensen aanwezig.");
                    Console.WriteLine("Wat wil je doen?");
                    Console.WriteLine("1: West, 2: Binnen");
                    string directionChurch = Console.ReadLine();
                    if (directionChurch == "1")
                    {
                        Console.WriteLine("Nog niet klaar...");
                        Console.WriteLine("Je staat buiten in de kou. Het sneeuwt en je wilt zo snel mogelijk naar binnen. Richting het noorden zie je licht branden.");
                        Console.WriteLine("Wat wil je doen?");
                        Console.WriteLine("Keuze: Noord, Oost, Zuid, West");
                    }
                    else if (directionChurch == "2")
                    {
                        Console.WriteLine("Nog niet klaar...");
                        Console.WriteLine("Je pakt de fakkel op en neemt hem mee.");
                        Console.WriteLine("Wat wil je doen?");
                        Console.WriteLine("Keuze: West");
                    }
                }




                else if (directionStart == "3")
                {
                    Console.WriteLine("Je staat aan de rand van een donker bos. Je bent niet van plan om met dit weer het bos te gaan verkennen.");
                    Console.WriteLine("Wat wil je doen?");
                    Console.WriteLine("1: Noord, 2: Water");
                    string directionForest = Console.ReadLine();
                    if (directionForest == "1")
                    {
                        Console.WriteLine("Nog niet klaar...");
                        Console.WriteLine("Je staat buiten in de kou. Het sneeuwt en je wilt zo snel mogelijk naar binnen. Richting het noorden zie je licht branden.");
                        Console.WriteLine("Wat wil je doen?");
                        Console.WriteLine("Keuze: Noord, Oost, Zuid, West");
                    }
                    else if (directionForest == "2")
                    {
                        Console.WriteLine("Nog niet klaar...");
                        Console.WriteLine("Je loopt verder het bos in en komt een eenhoorn tegen bij het water.");
                        Console.WriteLine("Wat wil je doen?");
                        Console.WriteLine("Keuze: Noord, Eenhoorn");
                    }
                }




                else if (directionStart == "4")
                {
                    Console.WriteLine("Je staat aan de kust. Het is een wonder dat het water nog niet bevroren is in deze kou. De boot waarmee je bent aangekomen, is allang vertrokken.");
                    Console.WriteLine("Wat wil je doen?");
                    Console.WriteLine("1: Oost");
                    string directionCoast = Console.ReadLine();
                    if (directionCoast == "1")
                    {
                        Console.WriteLine("Nog niet klaar...");
                        Console.WriteLine("Je staat buiten in de kou. Het sneeuwt en je wilt zo snel mogelijk naar binnen. Richting het noorden zie je licht branden.");
                        Console.WriteLine("Wat wil je doen?");
                        Console.WriteLine("Keuze: Noord, Oost, Zuid, West");
                    }
                }
            }

        }
    }
}

