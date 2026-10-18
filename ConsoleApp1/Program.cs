using System;
using System.Collections.Generic;


namespace ConsoleApp1
{

   
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List <Task> ();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("*Menu*");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Mark Complete");
                Console.WriteLine("3. Delete Task");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose A Number:");



                int.TryParse(Console.ReadLine(), out int userChoise);


                switch (userChoise)
                {
                    case 1:
                        AddTask(tasks);
                        break;

                    case 2:
                        MarkComplete(tasks);
                        break;

                    case 3:
                        DeleteTask(tasks);
                        break;

                    case 4:
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Number");
                        break;
                }   
            }
  
        }

        public static void AddTask(List<Task> tasks)
        {
            Console.WriteLine("Type Your New Task:");
            Task newTask = new Task();
            newTask.title = Console.ReadLine();
            newTask.isComplete = false;
            tasks.Add(newTask);
            ShowTasks(tasks);
        }

        public static void MarkComplete(List<Task> tasks)
        {
            Console.WriteLine("Type Number Of The Task You Wanna Mark As A Complete One:");
            if (int.TryParse(Console.ReadLine(),out int completionNum) && completionNum >= 0 && completionNum < tasks.Count)
            {
                tasks[completionNum].isComplete = true;
            }
            else
            {
                Console.Write("Invalid Number");
            }

            ShowTasks(tasks);

        }

        public static void DeleteTask(List<Task> tasks)
        {
            ShowTasks(tasks);

            Console.WriteLine("Type Number Of The Task You Wanna Delete:");

            if (int.TryParse(Console.ReadLine(), out int deletationNum) && deletationNum >= 0 && deletationNum < tasks.Count)
            {
                tasks.RemoveAt(deletationNum);
            }
            else
            {
                Console.Write("Invalid Number");
            }

            ShowTasks(tasks);
        }

        public static void ShowTasks(List<Task> tasks)
        {
            Console.WriteLine("*Tasks*");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.Write($"{i}: {tasks[i].title}");

                if (tasks[i].isComplete)
                {
                    Console.Write(" _ Completed");
                }

                Console.WriteLine();

            }
        }

    }

    class Task
    {
        public string title;
        public bool isComplete;
    }
}
                