public class ChecklistGoal : Goal
{
    private int _bonusValue;
    private int _timesCompleted;
    private int _timesCompletedGoal;

    public ChecklistGoal() : base()
    {
        SetBonusValue(0);
        SetTimesCompleted(0);
        SetTimesCompletedGoal(0);
    }

    public int GetBonusValue()
    {
        return _bonusValue;
    }
    public void SetBonusValue(int bonusValue)
    {
        _bonusValue = bonusValue;
    }
    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }
    public int GetTimesCompltedGoal()
    {
        return _timesCompletedGoal;
    }
    public void SetGoalAdditions()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int timesCompletedGoal = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonusValue = int.Parse(Console.ReadLine());

        SetTimesCompletedGoal(timesCompletedGoal);
        SetBonusValue(bonusValue);
    }
    public void SetTimesCompletedGoal(int timesCompletedGoal)
    {
        _timesCompletedGoal = timesCompletedGoal;
    }
    public override int RecordEvent()
    {
        int current = GetTimesCompleted();
        int bNew = current + 1;
        SetTimesCompleted(bNew);

        if (GetTimesCompleted() == GetTimesCompltedGoal())
        {
            SetIsComplete(true);
        }
        return (GetValue() + GetBonusValue());
    }
}