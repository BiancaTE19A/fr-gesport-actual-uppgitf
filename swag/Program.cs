using System;

namespace swag
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            int totalpoints = 3;
            string answer1 = "a";
            string answer2 = "c";
            string answer3 = "c";
            string playeranswer1 = "";
            string playeranswer2 = "";
            string playeranswer3 = "";


            Console.WriteLine("Här är Min frågesport om min hund:");

            Console.WriteLine("Vad heter hon?  A. Nelly  B.Shanti  C.Chelsea");
            playeranswer1 = Console.ReadLine().ToLower();

            if (playeranswer1 == "a")
            {
                Console.WriteLine("Rätt mannen!");
                points++;

            }
            else if (playeranswer1 == "b" || playeranswer1 == "c")
            {
                Console.WriteLine("FEL SVAR");
            }
            else
            {
                Console.WriteLine("Fel input, välj mellan A, B eller C");
            }

            Console.WriteLine("Alright next question: ");
            Console.WriteLine("Hur gammal är min hund?  A. 5  B. 10  C. 12");

            playeranswer2 = Console.ReadLine().ToLower();

            if (playeranswer2 == "c")
            {
                Console.WriteLine("Good job dud, d va rätt!");
                points++;
            }
            else if (playeranswer2 == "a" || playeranswer2 == "b")
            {
                Console.WriteLine("Dumb hoe kan inte ens enklaste frågan... ");
            }
            else
            {
                Console.WriteLine("Fel input, välj mellan A, B eller C");
            }

            Console.WriteLine("Okidoki bror du e on a rollllll, lets get it nästa: ");
            Console.WriteLine("Hur mycket väger mi hund?  A. 4kg  B. 5kg  C. 3kg");

            playeranswer3 = Console.ReadLine().ToLower();

            if (playeranswer3 == "c")
            {
                Console.WriteLine("Fuck do I know inte ens jag vet, men nått sånt gissar jag. Bra gjort!");
                points++;
            }
            else if (playeranswer3 == "a" || playeranswer3 == "b")
            {
                Console.WriteLine("Åååååååå du ÄR så dum. Du fick fel.");
            }
            else
            {
                Console.WriteLine("Fel input, välj mellan A, B eller C");
            }

            Console.WriteLine("You got " + points + " points out of " + totalpoints + ".");

            Console.WriteLine("Vill du spel igen???????");
            Console.ReadLine();
        }
    }
}
