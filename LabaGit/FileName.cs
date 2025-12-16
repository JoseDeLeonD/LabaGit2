using System;

public class Tracker
{
    public int DailyK { get; }
    public int StepsToday_A { get; private set; }

    public Tracker(int dailyGoal)
    {
        if (dailyGoal < 0)
        {
            throw new ArgumentException("Ціль не може бути від'ємною");
        }

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
        if (DailyK == 0) return 100; 


        return (int)((double)StepsToday_A / DailyK * 100);
    }

    public bool IsGoalReached => StepsToday_A >= DailyK;
}