namespace RefactorAndImproveTheCode
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
      public static void Main()
        {
            const int MAX_SCORE = 35;
            string command = string.Empty;
            int row = 0;
            int col = 0;
            int counter = 0;
            bool isBombed = false;
            bool inGame = true;
            bool maxResultAchieved = false;
            char[,] gameField = MinnesCommands.CreateGameField();
            char[,] bombs = MinnesCommands.PlantTheBombs();
            List<Player> champions = new List<Player>(6);

            do
            {
                if (inGame)
                {
                    Console.WriteLine("Let's play on minnes. Try your luck to open all minnes." +
                    " Command 'top' show standings, 'restart' restarts your game, 'exit' exit from game!");
                    MinnesCommands.DrawGameField(gameField);
                    inGame = false;
                }

                Console.Write("Give row and col: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= gameField.GetLength(0) && col <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        MinnesCommands.Standings(champions);
                        break;
                    case "restart":
                        gameField = MinnesCommands.CreateGameField();
                        bombs = MinnesCommands.PlantTheBombs();
                        MinnesCommands.DrawGameField(gameField);
                        isBombed = false;
                        inGame  = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                MinnesCommands.YourTurn(gameField, bombs, row, col);
                                counter++;
                            }

                            if (MAX_SCORE == counter)
                            {
                                maxResultAchieved = true;
                            }
                            else
                            {
                                MinnesCommands.DrawGameField(gameField);
                            }
                        }
                        else
                        {
                            isBombed = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! invalid command\n");
                        break;
                }

                if (isBombed)
                {
                    MinnesCommands.DrawGameField(bombs);
                    Console.Write("\nHrrrrrr! You died with {0} points. " + "Write your nickname: ", counter);
                    string playerName = Console.ReadLine();
                    Player player = new Player(playerName, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < player.Points)
                            {
                                champions.Insert(i, player);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    champions.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    MinnesCommands.Standings(champions);
                    gameField = MinnesCommands.CreateGameField();
                    bombs = MinnesCommands.PlantTheBombs();
                    counter = 0;
                    isBombed = false;
                    inGame = true;
                }

                if (maxResultAchieved)
                {
                    Console.WriteLine("\ncongratulation! You open 35 sheets without dying.");
                    MinnesCommands.DrawGameField(bombs);
                    Console.WriteLine("Give your nickname: ");
                    string playerName = Console.ReadLine();
                    Player player = new Player(playerName, counter);
                    champions.Add(player);                                      
                    MinnesCommands.Standings(champions);
                    gameField = MinnesCommands.CreateGameField();
                    bombs = MinnesCommands.PlantTheBombs();
                    counter = 0;
                    maxResultAchieved = false;
                    inGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria !");                   
        }
    }
}