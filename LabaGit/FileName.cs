public class Tracker
{
    public int DailyK { get; }
    public int StepsToday_A { get; private set; }

    public Tracker(int dailyGoal)
    {
        DailyK = dailyGoal;
        StepsToday_A = 0;
    }


}