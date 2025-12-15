using Xunit;

public class TrackerTests
{
    [Fact]
    public void Constructor_ShouldThrow_WhenDailyGoalIsNegative()
    {
        Assert.Throws<ArgumentException>(() => new Tracker(-5));
    }

    [Fact]
    public void Constructor_ShouldSetDailyGoal()
    {
        var tracker = new Tracker(5000);

        Assert.Equal(5000, tracker.DailyK);
    }

    [Fact]
    public void AddSteps_ShouldIncreaseSteps_WhenPositive()
    {
        var t = new Tracker(5000);
        t.AddSteps(1000);
        Assert.Equal(1000, t.StepsToday_A);
    }

    [Fact]
    public void ResetDay_ShouldSetStepsToZero()
    {
        var t = new Tracker(5000);
        t.AddSteps(3000);
        t.ResetDay();

        Assert.Equal(0, t.StepsToday_A);
    }

    [Fact]
    public void GetProgress_ShouldReturnCorrectPercentage()
    {
        var t = new Tracker(1000);
        t.AddSteps(500);

        Assert.Equal(50, t.GetProgress());
    }

    [Fact]
    public void IsGoalReached_ShouldReturnTrue_WhenGoalMet()
    {
        var t = new Tracker(1000);
        t.AddSteps(1000);

        Assert.True(t.IsGoalReached);
    }
}