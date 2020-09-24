using System;

namespace swag
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            int totalpoints = 3;
            string playeranswer1 = "";
            string playeranswer2 = "";
            string playeranswer3 = "";
            int a = 1;
            int b = 1;
            int c = 1;
            string restart = "";

            Console.WriteLine("Här är Min frågesport om min hund:");

            while (a == 1)
            {


                Console.WriteLine("Vad heter hon?  A. Nelly  B.Shanti  C.Chelsea");
                playeranswer1 = Console.ReadLine().ToLower();

                if (playeranswer1 == "a")
                {
                    Console.WriteLine("Rätt mannen!");
                    points++;
                    a = a - 1;

                }
                else if (playeranswer1 == "b" || playeranswer1 == "c")
                {
                    Console.WriteLine("FEL SVAR");
                    a = a - 1;
                }
                else
                {
                    Console.WriteLine("Fel input, välj mellan A, B eller C");
                }
            }

            while (b == 1)
            {
                Console.WriteLine("Alright next question: ");

                Console.WriteLine("Hur gammal är min hund?  A. 5  B. 10  C. 12");

                playeranswer2 = Console.ReadLine().ToLower();

                if (playeranswer2 == "c")
                {
                    Console.WriteLine("Good job dud, d va rätt!");
                    points++;
                    b = b - 1;
                }
                else if (playeranswer2 == "a" || playeranswer2 == "b")
                {
                    Console.WriteLine("Dumb hoe kan inte ens enklaste frågan... ");
                    b = b - 1;
                }
                else
                {
                    Console.WriteLine("Fel input, välj mellan A, B eller C");
                }

            }

            Console.WriteLine("Okidoki bror du e on a rollllll, lets get it nästa: ");

            while (c == 1)
            {
                Console.WriteLine("Hur mycket väger mi hund?  A. 4kg  B. 5kg  C. 3kg");

                playeranswer3 = Console.ReadLine().ToLower();

                if (playeranswer3 == "c")
                {
                    Console.WriteLine("Fuck do I know inte ens jag vet, men nått sånt gissar jag. Bra gjort!");
                    points++;
                    c = c - 1;
                }
                else if (playeranswer3 == "a" || playeranswer3 == "b")
                {
                    Console.WriteLine("Åååååååå du ÄR så dum. Du fick fel.");
                    c = c - 1;
                }
                else
                {
                    Console.WriteLine("Fel input, välj mellan A, B eller C");
                }
            }

            if (points == 0 | points == 1)
            {
                Console.WriteLine("Is you dumb stupid, or dumb. You got " + points + " points out of " + totalpoints + ".");

            }
            else if (points == 2)
            {
                Console.WriteLine("You kinda smart bro good job. You got " + points + " points out of " + totalpoints + ".");

            }

            else
            {
                Console.WriteLine("You a damn genius bro daaamn ayy. You got " + points + " points out of " + totalpoints + ".");
            }

            Console.WriteLine("Vill du spel igen? Y/N");
            restart = Console.ReadLine().ToLower();

            if (restart == "y")
            {
                a = 1;
                b = 2;
                c = 3;
            }
            else if (restart == "n")
            {
                Console.WriteLine("Okej tack för att du spelade!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect input!");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
