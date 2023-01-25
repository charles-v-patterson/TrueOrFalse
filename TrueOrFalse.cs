namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Questions
            string[] questions;
            questions = new string[] { "Eggplants are a type of berry.", "Ricky is a loser.", "Charles is a God." };

            bool[] answers;
            answers = new bool[] { true, true, true };
            bool[] responses;
            responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning Number of Answers Does Not Match Number of Question!");
            }

            int askingIndex = 0;

            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine($"\n{question}");
                Console.WriteLine("True or False?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);

                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = isBool;
                askingIndex++;
            }

            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool userResponse = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {userResponse} | Answer: {answer}");

                if (userResponse == answer)
                {
                    score += 1;
                }
                scoringIndex++;
            }
            Console.WriteLine($"\nYou got {scoringIndex} of 3 correct!");
        }
    }
}
