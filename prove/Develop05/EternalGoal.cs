public class EternalGoal : Goal
{
    public EternalGoal()
    {
        SetName("Null");
        SetDescription("Null");
        SetValue(0);
        SetIsComplete(false);
    }
    public override int RecordEvent()
    {
        return GetValue();
    }
     public override string GetGoalDisplay()
    {
        return $"{GetName()} ({GetDescription()})";
    }
    public override string GetGoalInfo()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetValue()},{GetIsComplete()}";
    }
}