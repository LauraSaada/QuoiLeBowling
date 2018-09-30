public class Scoreboard 
{
    private int _nbPoints = 0;

    public int GetTotalPoints()
    {
        return _nbPoints;
    }

    public void UpdateScore(int score)
    {
        _nbPoints += score;
    }
}
