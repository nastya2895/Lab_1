using Lab1;

public class GameAccount
{
    public string UserName { get; private set; }
    public int CurrentRating { get; private set; }
    public int GamesCount { get; private set; }

    public GameAccount(string userName, int currentRating, int gamesCount)
    {
        UserName = userName;
        CurrentRating = currentRating < 1 ? 1 : currentRating;
        GamesCount = gamesCount;
    }

    public List<GameHistory> Histories = new List<GameHistory>();

    public void WinGame(ref GameAccount opponentName, int Rating)
    {
        if (Rating < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(Rating), "Error! Game rating must be positive!");
        }

        if (Rating >= CurrentRating && Rating >= opponentName.CurrentRating)
        {
            throw new ArgumentOutOfRangeException(nameof(Rating), "Error! Game rating is too high");
        }

        CurrentRating += Rating;
        GamesCount++;
        opponentName.CurrentRating -= Rating;
        opponentName.GamesCount++;

        GameHistory History = new GameHistory(Rating, this, opponentName, true);
        Histories.Add(History);

        opponentName.Histories.Add(History);
    }

    public void LoseGame(ref GameAccount opponentName, int Rating)
    {
        if (Rating < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(Rating), "Error! Game rating must be positive!");
        }

        if (Rating >= CurrentRating && Rating >= opponentName.CurrentRating)
        {
            throw new ArgumentOutOfRangeException(nameof(Rating), "Error! Game rating is too high");
        }

        CurrentRating -= Rating;
        GamesCount++;
        opponentName.CurrentRating += Rating;
        opponentName.GamesCount++;

        GameHistory History = new GameHistory(Rating, this, opponentName, false);
        Histories.Add(History);

        opponentName.Histories.Add(History);
    }

    public void GetStatsPlayer()
    {
        Console.WriteLine("\nName: " + UserName + "\nRating: " + CurrentRating + "\nNumber of games: " + GamesCount);
    }

    public void PrintHistory()
    {
        Console.WriteLine("\n\nHistory: ");
        foreach (GameHistory History in Histories)
        {
            History.GetStatsGame();
        }
    }
}