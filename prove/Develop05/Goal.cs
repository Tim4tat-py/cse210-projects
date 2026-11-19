public abstract class Goal
{
    private string _name;
    private string _description;
    private int _value;
    private bool _isComplete;

    public Goal()
    {
        SetName("Null");
        SetDescription("Null");
        SetValue(0);
        SetIsComplete(false);
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetValue()
    {
        return _value;
    }
    public void SetValue(int value)
    {
        _value = value;
    }
    public void SetGoalBasics()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int value = int.Parse(Console.ReadLine());
        
        SetName(name);
        SetDescription(description);
        SetValue(value);
    }
    public bool GetIsComplete()
    {
        return _isComplete;
    }
    public void SetIsComplete(bool complete)
    {
        _isComplete = complete;
    }
    public abstract int RecordEvent();
}