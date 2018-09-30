using NUnit.Framework;

public class ScoreboardTest {

    [Test]
    public void NewScoreboardShouldReturnZeroPoints()
    {
        // Given
        Scoreboard scoreboard = new Scoreboard(); //On déclare un objet scoreboard de type "Scoreboard" (classe) et on créer un nouveau à partir du template (instance) 

        // When
        int nbPoints = scoreboard.GetTotalPoints(); //On déclare une variabla entier "nbPoints" et on récupère le résultat de l'exectution de "getTotalPoints" de l'objet scoreboard

        // Then
        Assert.That(nbPoints == 0); // On peut aussi utiliser Assert.AreEqual(0, nbPoints);
    }

    [Test]
    public void OneThrowKnockFivePinsEqualFivePoints()
    {
        //Given
        Scoreboard scoreboard = new Scoreboard();
        scoreboard.UpdateScore(5);

        //When        
        int nbPoints = scoreboard.GetTotalPoints();

        //Then
        Assert.That(nbPoints == 5);
    }

    [Test]
    public void ThrowOfFourPlusThrowOfThreeEqualSevenPoints()
    {
        //Given
        Scoreboard scoreboard = new Scoreboard();
        scoreboard.UpdateScore(4);
        scoreboard.UpdateScore(3);
        
        //When
        int nbPoints = scoreboard.GetTotalPoints();

        //Then
        Assert.AreEqual(7,nbPoints);
    }


}
