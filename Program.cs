using System;
using System.Collections.Generic;
using System.Linq;

namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            StartQuest();
        }

        static void StartQuest()
        {
            Console.WriteLine("Enter adventurer's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter robe colors (separated by commas):");
            string[] robeColorsArray = Console.ReadLine().Split(',');
            List<string> robeColors = new List<string>(robeColorsArray);

            Console.WriteLine("Enter robe length (in inches):");
            int robeLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter hat shininess level (1-10):");
            int shininessLevel = int.Parse(Console.ReadLine());

            Robe colorfulRobe = new Robe(robeColors, robeLength);
            Hat adventurerHat = new Hat();
            adventurerHat.ShininessLevel = shininessLevel;

            Adventurer theAdventurer = new Adventurer(name, colorfulRobe, adventurerHat);

            Console.WriteLine(theAdventurer.GetDescription());

            // Create a list of challenges for our Adventurer's quest
            List<Challenge> challenges = new List<Challenge>()
            {
                new Challenge("2 + 2?", 4, 10),
                new Challenge("What's the answer to life, the universe and everything?", 42, 25),
                new Challenge("What is the current second?", DateTime.Now.Second, 50),
                new Challenge("What number am I thinking of?", new Random().Next() % 10, 25),
                new Challenge(@"Who's your favorite Beatle?
                    1) John
                    2) Paul
                    3) George
                    4) Ringo
                    ", 4, 20),
                // Additional challenges
                new Challenge("What's 9x9?", 81, 15),
                new Challenge("1) Harry Potter or 2) Lord of the Rings?", 1, 12)
            };

            // Randomly select 5 challenges for the Adventurer to face
            List<Challenge> selectedChallenges = challenges.OrderBy(x => Guid.NewGuid()).Take(5).ToList();

            int successfulChallenges = 0;

            // Loop through all the selected challenges and subject the Adventurer to them
            foreach (Challenge challenge in selectedChallenges)
            {
                if (challenge.RunChallenge(theAdventurer))
                {
                    successfulChallenges++;
                }
            }

            // Multiply the number of successful challenges by 10 and add it to the initial Awesomeness on the next quest
            int awesomenessBonus = successfulChallenges * 10;
            theAdventurer.Awesomeness += awesomenessBonus;

            // This code examines how awesome the Adventurer is after completing the challenges
            // And praises or humiliates them accordingly
            if (theAdventurer.Awesomeness >= 100)
            {
                Console.WriteLine("YOU DID IT! You are truly awesome!");
            }
            else if (theAdventurer.Awesomeness <= 0)
            {
                Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
            }
            else
            {
                Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
            }

            // Ask the user if they want to play again
            Console.WriteLine("Do you want to play again? Yes or No?");
            string repeat = Console.ReadLine().ToLower();

            if (repeat == "yes")
            {
                StartQuest(); // Call StartQuest() method again to repeat the quest
            }

            // Create an instance of the Prize
            Prize questPrize = new Prize("You have won a shiny trophy!");

            // Show the prize to the adventurer
            questPrize.ShowPrize(theAdventurer);
        }
    }
}
