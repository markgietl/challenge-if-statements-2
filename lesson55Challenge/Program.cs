namespace challenge
{
    internal class program
    {
        public static string highScorePlayer = "David";
        public static int highScore = 435643;

        private static void Main(string[] args)
        {
            CheckHighScore();
            Console.ReadKey();
        }

        private static void CheckHighScore()
        {
            int playerScore = 100084222;

            string playerName = "Ben";

            if (playerScore > highScore)
            {
                Console.WriteLine($"{playerName} has overtaken {highScorePlayer} by {playerScore - highScore} points.");
                Console.WriteLine($"{playerName} is the new champion!");
            }
            else
            {
                Console.WriteLine($"With a score of {playerScore}, {playerName} was unable to dethrone {highScorePlayer}, who still reigns supreme with a hefty score of {highScore}!");
            }
        }
    }
}