using System;

namespace Quest
{
    // Prize class representing a prize awarded to the adventurer
    class Prize
    {
        private string _text;

        // Constructor to set the textual description of the prize
        public Prize(string text)
        {
            _text = text;
        }

        // Method to show the prize to the adventurer
        public void ShowPrize(Adventurer adventurer)
        {
            if (adventurer.Awesomeness > 0)
            {
                for (int i = 0; i < adventurer.Awesomeness; i++)
                {
                    Console.WriteLine(_text);
                }
            }
            else
            {
                Console.WriteLine("Oh no! You didn't earn any prize. Better luck next time!");
            }
        }
    }
}
