namespace PlayerScoreService.Tests;

public class UnitTest1
{
    [Fact]
    public void Service_ShouldReturnNull_ForUnknownPlayers()
    {
        // Arrange
        var service = new PlayerScoreService();

        // Act
        var result = service.GetScore("Alice");
        // Assert
        Assert.Null (result);
    }
}
