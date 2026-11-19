using System.Net.Sockets;
using System.Numerics;

public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        SetName("Null");
        SetDescription("Null");
        SetValue(0);
        SetIsComplete(false);
    }
    public override int RecordEvent()
    {
        bool compsey = GetIsComplete();
        if (compsey == false)
        {
            SetIsComplete(true);
            return GetValue();
        }
        else
        {
            return 0;
        }


    }
}