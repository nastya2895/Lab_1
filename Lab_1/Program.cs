using System;

namespace Lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameAccount FirstPlayer = new GameAccount("Vanya", 65, 0);
            GameAccount SecondPlayer = new GameAccount("Bogdan", 100, 0);

            FirstPlayer.WinGame(ref SecondPlayer, 10);
            FirstPlayer.LoseGame(ref SecondPlayer, 25);

            SecondPlayer.WinGame(ref FirstPlayer, 40);
            SecondPlayer.LoseGame(ref FirstPlayer, 30);

            FirstPlayer.GetStatsPlayer();
            SecondPlayer.GetStatsPlayer();

            FirstPlayer.PrintHistory();
        }
    }
}

