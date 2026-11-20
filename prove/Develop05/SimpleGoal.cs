using System.Net.Sockets;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        SetName("Null");
        SetDescription("Null");
        SetValue(0);
        SetIsComplete(false);
    }
    public override string GetGoalDisplay()
    {
        return $"{GetName()} ({GetDescription()})";
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
    public override string GetGoalInfo()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetValue()},{GetIsComplete()}";
    }
}