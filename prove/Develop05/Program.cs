using System;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {   
        bool on = true;
        string rank = "Null";
        Console.Clear();
        int points = 0;
        List<Goal> goals= [];
        while (on == true)
        {
            if (points < 0)
            {
                rank = "cheater";
            }
            else if (points is >= 0 and < 100)
            {
                rank = "beginner";
            }
            else if (points is >= 100 and < 500)
            {
                rank = "novice";
            }
            else if (points is >= 500 and < 1000)
            {
                rank = "professoinal";
            }
            else if (points is >= 1000 and < 10000)
            {
                rank = "expert";
            }

            Console.WriteLine($"You have {points} points");
            Console.WriteLine($"You are at the {rank} rank");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choiceSelection = Console.ReadLine();

            if (choiceSelection == "1") //Create new goal
            {
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                
                string typeSelection = Console.ReadLine();

                if (typeSelection == "1") // Create simple goal
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.SetGoalBasics();
                    goals.Add(simpleGoal);
                }
                else if (typeSelection == "2") // Create eternal goal
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.SetGoalBasics();
                    goals.Add(eternalGoal);
                }
                else if (typeSelection == "3") // Create ChecklistGoal
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.SetGoalBasics();
                    checklistGoal.SetGoalAdditions();
                    goals.Add(checklistGoal);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            else if (choiceSelection == "2") //Display List new goal
            {
                Console.WriteLine("The goals are: ");
                foreach (Goal goal in goals)
                {
                    int index = goals.IndexOf(goal) + 1;
                    bool complete = goal.GetIsComplete();
                    string digital = "";
                    if (complete == true)
                    {
                        digital = "[X]";
                    }
                    else
                    {
                        digital = "[ ]";
                    }

                    if (goal is SimpleGoal or EternalGoal)
                    {
                        Console.WriteLine($"{index}. {digital} {goal.GetName()} ({goal.GetDescription()})");
                    }
                    else
                    {
                        ChecklistGoal altered = (ChecklistGoal)goal;
                        Console.WriteLine($"{index}. {digital} {altered.GetName()} ({altered.GetDescription()}) --- Currently Completed: {altered.GetTimesCompleted()}/{altered.GetTimesCompltedGoal()}");
                    }

                }

            }
            else if (choiceSelection == "3") //Save goal
            {
                Console.WriteLine("What is the file name?");
                Console.WriteLine("Remember to add '.txt'");
                string fileName = Console.ReadLine();
        
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(points);

                    foreach (Goal goal in goals)
                    {
                        if (goal is SimpleGoal)
                        {
                            outputFile.WriteLine($"SimpleGoal:{goal.GetName()},{goal.GetDescription()},{goal.GetValue()},{goal.GetIsComplete()}");
                        }
                        else if (goal is EternalGoal)
                        {
                            outputFile.WriteLine($"EternalGoal:{goal.GetName()},{goal.GetDescription()},{goal.GetValue()},{goal.GetIsComplete()}");
                        }
                        else if (goal is ChecklistGoal)
                        {
                            ChecklistGoal alteredGoal = (ChecklistGoal)goal;
                            outputFile.WriteLine($"ChecklistGoal:{alteredGoal.GetName()},{alteredGoal.GetDescription()},{alteredGoal.GetValue()},{alteredGoal.GetIsComplete()},{alteredGoal.GetBonusValue()},{alteredGoal.GetTimesCompleted()},{alteredGoal.GetTimesCompltedGoal()}");
                        }
                        
                    }

                }
            }
            else if (choiceSelection == "4") //Load goals
            {
                Console.WriteLine("What is the file name?");
                Console.WriteLine("Remember to add '.txt'");
                string fileName = Console.ReadLine();
                goals = [];
        
                string[] lines = System.IO.File.ReadAllLines(fileName);
                
                points = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] halves = line.Split(":");
                    string type = halves[0];
                    string info = halves[1];    
                
                    if (type == "SimpleGoal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal();
                        string[] part = info.Split(",");
                        string name = part[0];
                        string description = part[1];
                        int value = int.Parse(part[2]);
                        bool isComplete = bool.Parse(part[3]);

                        simpleGoal.SetName(name);
                        simpleGoal.SetDescription(description);
                        simpleGoal.SetValue(value);
                        simpleGoal.SetIsComplete(isComplete);

                        goals.Add(simpleGoal);
                    }
                    else if (type == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal();
                        string[] part = info.Split(",");
                        string name = part[0];
                        string description = part[1];
                        int value = int.Parse(part[2]);
                        bool isComplete = bool.Parse(part[3]);

                        eternalGoal.SetName(name);
                        eternalGoal.SetDescription(description);
                        eternalGoal.SetValue(value);
                        eternalGoal.SetIsComplete(isComplete);

                        goals.Add(eternalGoal);
                    }
                    else if (type == "ChecklistGoal")
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal();
                        string[] part = info.Split(",");
                        string name = part[0];
                        string description = part[1];
                        int value = int.Parse(part[2]);
                        bool isComplete = bool.Parse(part[3]);
                        int bonusValue = int.Parse(part[4]);
                        int timesCompleted = int.Parse(part[5]);
                        int timesCompletedGoal = int.Parse(part[6]);

                        checklistGoal.SetName(name);
                        checklistGoal.SetDescription(description);
                        checklistGoal.SetValue(value);
                        checklistGoal.SetIsComplete(isComplete);
                        checklistGoal.SetBonusValue(bonusValue);
                        checklistGoal.SetTimesCompleted(timesCompleted);
                        checklistGoal.SetTimesCompletedGoal(timesCompletedGoal);

                        goals.Add(checklistGoal);
                    }

            }
            }
            else if (choiceSelection == "5") //Record event
            {
                Console.WriteLine("The goals are:");
                foreach (Goal goal in goals)
                {
                    int index = goals.IndexOf(goal) + 1;
                    Console.WriteLine($"{index}. {goal.GetName()}");
                }
                Console.WriteLine("Which goal did you accomplish?");
                int response = int.Parse(Console.ReadLine()) - 1;

                int added = goals[response].RecordEvent();
                points = points + added;

                Console.WriteLine($"Congrats!! you just earned {added} points!!");
            }
            else if (choiceSelection == "6") // quit
            {
                Console.WriteLine("Goodbye");
                on = false;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        
    }
}