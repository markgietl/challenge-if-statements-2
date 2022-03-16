namespace challenge
{
    class program
    {
        static int highScore = 2452;
        static string highScorePlayer = "pranked80085";
        

        static void Main(string[] args)
        {
            CheckHighScore(5556, "scroteyMCboogerballs");
            CheckHighScore(3455, "markwhyborn");
            CheckHighScore(7890, "yerfatmum");
            CheckHighScore(9001, "Goku");
            CheckHighScore(8999, "Vegeta");


            Console.ReadKey();
        }

        public static void CheckHighScore(int playerScore, string playerName)
        {

            if (playerScore > highScore)
            {
                highScore = playerScore;
                highScorePlayer = playerName;
                
                Console.WriteLine($"{highScorePlayer} now holds the new record with a score of {highScore}.");
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine($"With a score of {playerScore}, {playerName} was unable to dethrone {highScorePlayer}.");
                Console.WriteLine("-------------------------------------------------------------------------");
            }
        }
    }
}