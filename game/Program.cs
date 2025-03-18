namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] players = { 10, 10, 10, 10, 10 };
            double pot = 0;
            double lastRoundPot = 0;

            Random random = new Random();

            int round = 1;
            int strategy = 0;

            Console.WriteLine("Everybody has 10 EUR.");

            for (int j = 0; j < 10; j++) //Amount of rounds
            {
                Console.WriteLine($"Round {round}");
                for (int i = 0; i < players.Length; i++)
                {
                    double bet = 0;

                    if (round != 1)
                    {
                        strategy = random.Next(0, 4);
                    }
                    else
                    {
                        strategy = random.Next(0, 3);
                    }

                    string strategyName = string.Empty;

                    if (players[i] == 0)
                    {
                        bet = 0;
                        strategyName = "No money";
                    }
                    else if (strategy == 0) //Fair play
                    {
                        bet = players[i] / 2;
                        players[i] -= bet;
                        strategyName = "Fair play";
                    }
                    else if (strategy == 1) //selfish play
                    {
                        bet = 0;
                        strategyName = "Selfish play";
                    }
                    else if (strategy == 3) //reactive play
                    {
                        bet = lastRoundPot / players.Length;
                        players[i] -= bet;
                        strategyName = "Reactive play";
                    }
                    else //All in (strategy 2)
                    {
                        bet = players[i];
                        players[i] -= bet;
                        strategyName = "All in";
                    }

                        pot += bet;

                    Console.WriteLine($"player {i} betted {bet} EUR and chose the {strategyName} strategy.");
                }

                
                Console.WriteLine($"The pot before the koeficient is {pot} EUR");
                lastRoundPot = pot;

                pot *= 1.5;
                
                Console.WriteLine($"The pot after the koeficient is {pot} EUR");

                for (int i = 0; i < players.Length; i++)
                {
                    players[i] += pot / players.Length;
                }

                Console.WriteLine($"player 0 has {players[0]} EUR, player 1 has {players[1]} EUR, player 2 has {players[2]} EUR, player 3 has {players[3]} EUR, player 4 has {players[4]} EUR");
                Console.WriteLine();

                pot = 0;

                round++;
            }
        }
    }
}