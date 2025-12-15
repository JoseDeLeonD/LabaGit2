public class Tracker
{
    public int DailyK { get; }
    public int StepsToday_A { get; private set; }

    public Tracker(int dailyGoal)
    {
        DailyK = dailyGoal;
        StepsToday_A = 0;
    }

    public void AddSteps(int steps)
    {
        StepsToday_A += steps;
    }

    public void ResetDay()
    {
        StepsToday_A = 0;
    }

    public int GetProgress()
    {
        return 0;
    }

    public bool IsGoalReached => false;
}