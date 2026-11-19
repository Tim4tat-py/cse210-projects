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
}