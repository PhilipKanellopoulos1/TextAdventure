using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("You walk into a dark room...");
                Console.WriteLine("Would you like to look around?");
                string lookAroundResponse = Console.ReadLine();

                if (lookAroundResponse == "yes" || lookAroundResponse == "Yes" || lookAroundResponse == "Yes!")
                {
                    Console.WriteLine("You can't see much but you hear movement");
                    Console.WriteLine("...");
                    Console.WriteLine("...");
                    Console.WriteLine("...");
                    Console.WriteLine("The Lights Turn on and blind you");
                    Console.WriteLine("Surprise!!! Happy Birthday!");
                }
            }

            Console.WriteLine("Were you surprised?");
            string surpriseResponse = Console.ReadLine();
            if (surpriseResponse == "yes" || surpriseResponse == "Yes" || surpriseResponse == "Yes!")
            {
                Console.WriteLine("AWESOME!! We were worried you may have found out");
                Console.WriteLine("As you look around the room the happy faces of your friends and family who have come together to celebrate your birthday feel you with a sense of fullness");
            }

            Console.WriteLine("You then look up as your brother walks your way and slaps his hand on your back.");
            Console.WriteLine("He's got a cool beer in his hand ready for you...");

            Console.WriteLine("Take the beer?");
            string beerofferresponse = Console.ReadLine();
            if (beerofferresponse == "yes")
            {
                Console.WriteLine("As you take your first sip of beer, still overwhelmed by the cheer and hospitality shown by your loved ones.");
            }
            if (beerofferresponse == "no" || beerofferresponse == "")
            {
                Console.WriteLine("Come on! I thought it was your birthday!!");
                Console.WriteLine("You give a look of disapproval and thank him.");
                Console.WriteLine("Your brother looks you back in the eye and says one word -SHOTS!");
            }

            Console.WriteLine("Almost everyone in the room has their hand up at this point. How many people do you see? What about in the back?");
            Console.WriteLine("You count 10 around you and 7 more in the back");

            Console.WriteLine("What is 10 + 7?");
           string shotnumber = Console.ReadLine();
            if (shotnumber != "17")
            {

                Console.WriteLine("Are you sure? Count again.");

            }
            string shotnumber2 = Console.ReadLine();
           if (shotnumber2 == "17" || shotnumber2 == "seventeen" || shotnumber2 == "Seventeen")
            {
                Console.WriteLine("HAPPY BIRTHDAY!!SEVENTEEN SHOTS! COUNT 'EM, POOR 'EM, SHOOT 'EM!");
            }

        }
        }
    }
    