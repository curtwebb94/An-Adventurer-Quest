using System;


namespace Quest
{
    // An instance of the Challenge class is an occurrence of a single challenge
    public class Challenge
    {
        public string Text { get; set; }
        public dynamic ExpectedAnswer { get; set; }
        public int AwesomenessPoints { get; set; }

        public Challenge(string text, dynamic expectedAnswer, int awesomenessPoints)
        {
            Text = text;
            ExpectedAnswer = expectedAnswer;
            AwesomenessPoints = awesomenessPoints;
        }

        public bool RunChallenge(Adventurer adventurer)
        {
            Console.WriteLine(Text);

            dynamic userAnswer;
            if (ExpectedAnswer is int)
            {
                userAnswer = int.Parse(Console.ReadLine());
            }
            else
            {
                userAnswer = Console.ReadLine();
            }

            bool isAnswerCorrect = userAnswer == ExpectedAnswer;
            if (isAnswerCorrect)
            {
                adventurer.Awesomeness += AwesomenessPoints;
                Console.WriteLine("That's correct! You gain {0} awesomeness points.", AwesomenessPoints);
            }
            else
            {
                adventurer.Awesomeness -= AwesomenessPoints;
                Console.WriteLine("Oops, that's incorrect! You lose {0} awesomeness points.", AwesomenessPoints);
            }

            Console.WriteLine(); // Add a line break for readability

            return isAnswerCorrect;
        }
    }
}