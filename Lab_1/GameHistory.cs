using Lab1;

public class GameHistory
{
    private static int Index = 1;
    private int ID { get; }
    private int Rating { get; }
    private GameAccount Player1 { get; }
    private GameAccount Player2 { get; }
    private bool WinPlayer1 { get; }

    public GameHistory(int rating, GameAccount firstPlayer, GameAccount secondPlayer, bool winFirstPlayer)
    {
        Rating = rating;
        Player1 = firstPlayer;
        Player2 = secondPlayer;
        WinPlayer1 = winFirstPlayer;
        ID = Index++;
    }

    public void GetStatsGame()
    {
        Console.WriteLine("\nIndex of game: " + ID + "\nFirst player: " + Player1.UserName + " + " + "\nSecond player: " + Player2.UserName + " - " + "\nWinner: " + (WinPlayer1 ? Player1.UserName : Player2.UserName) + " with rating " + Rating);
    }
}
