using System;
using System.Collections.Generic;
using System.IO;


    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score;


        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Menu Options");
                Console.WriteLine("  1. Create a new goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit\n");
                Console.Write("Select a choice from the menu: ");
                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        DisplayPlayerInfo();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        return;
                }


            }
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Current Score: {_score}");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }


        public void CreateGoal()
        {
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Choose goal type: ");
            string choice = Console.ReadLine();

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter description: ");
            string description = Console.ReadLine();
            Console.Write("Enter points: ");
            int points = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("Enter target number: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    break;

            }
        }

        public void RecordEvent()
        {
            Console.WriteLine("Select a goal to record an event: ");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
            int choice = int.Parse(Console.ReadLine());
            Goal selectedGoal = _goals[choice - 1];
            selectedGoal.RecordEvent();
            _score += selectedGoal.GetPoints();
            if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.GetBonus();
            }
        }

        public void SaveGoals()
        {
           Console.WriteLine("Enter filename to save goals: ");
           string filename = Console.ReadLine();
           using (StreamWriter outputFile = new StreamWriter(filename))
           {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
           }
        }

        public void LoadGoals()
        {
            Console.Write("Enter filename to load goals: ");
            string filename = Console.ReadLine();
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                _score = int.Parse(lines[0]);
                _goals.Clear();
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(':');
                    string type = parts[0];
                    string[] goalParts = parts[1].Split(',');
                    string name = goalParts[0];
                    string description = goalParts[1];
                    int points = int.Parse(goalParts[2]);

                    switch (type)
                    {
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(goalParts[3]);
                            _goals.Add(new SimpleGoal(name, description, points));
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "ChecklistGoal":
                            int amountCompleted = int.Parse(goalParts[3]);
                            int target = int.Parse(goalParts[4]);
                            int bonus = int.Parse(goalParts[5]);
                            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                            break;
                    }
                } 
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        
        }

    }