/* QUESTION 2: TASK MANAGEMENT SYSTEM
Question: Implement a Task Management System

Write a C# program to implement a Task Management System. The program should allow users to add tasks, mark tasks as complete, and view the task list.
The program should use a list to store the tasks.

Your program should provide the following functionalities:

Add Task: Implement a method called AddTask that takes a list of strings as a parameter. 
This method should prompt the user to enter a task description and add it to the task list.

Mark Task as Complete: Implement a method called MarkTaskComplete that takes a list of strings as a parameter.
This method should display the task list and prompt the user to enter the index of the task they want to mark as complete.
If the index is valid, remove the task from the list and display a message confirming the task completion. If the index is invalid, display an error message.

View Task List: Implement a method called ViewTaskList that takes a list of strings as a parameter.
This method should display the task list with each task numbered.

Main Method: Implement the Main method. Inside the Main method, create an empty list of strings to store the tasks. 
Display a welcome message to the user and enter a loop to show the menu options until the user chooses to exit.
Prompt the user for their choice and call the appropriate method based on the user's input

 SAMPLE INPUT :
 Welcome to the Task Management System!

MENU:
1. Add Task
2. Mark Task as Complete
3. View Task List
4. Exit
Enter your choice (1-4): 1

ADD TASK:
Enter the task description: Complete project report

MENU:
1. Add Task
2. Mark Task as Complete
3. View Task List
4. Exit
Enter your choice (1-4): 1

ADD TASK:
Enter the task description: Prepare presentation slides

MENU:
1. Add Task
2. Mark Task as Complete
3. View Task List
4. Exit
Enter your choice (1-4): 3


SAMPLE OUTPUT 1:
VIEW TASK LIST:
List of Tasks:
1. Complete project report
2. Prepare presentation slides



SAMPLE INPUT 2 :
MENU:
1. Add Task
2. Mark Task as Complete
3. View Task List
4. Exit
Enter your choice (1-4): 2

MARK TASK AS COMPLETE:
VIEW TASK LIST:
List of Tasks:
1. Complete project report
2. Prepare presentation slides

Enter the index of the task to mark as complete: 1

SAMPLE OUTPUT 2:
Task 'Complete project report' marked as complete. */

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();

        Console.WriteLine("Welcome to the Task Management System!");

        while (true)
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Mark Task as Complete");
            Console.WriteLine("3. View Task List");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask(tasks);
                    break;
                case "2":
                    MarkTaskComplete(tasks);
                    break;
                case "3":
                    ViewTaskList(tasks);
                    break;
                case "4":
                    Console.WriteLine("Exiting the program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddTask(List<string> tasks)
    {
        Console.WriteLine("\nADD TASK:");
        Console.Write("Enter the task description: ");
        string task = Console.ReadLine();

        tasks.Add(task);
        Console.WriteLine("Task added successfully!");
    }

    static void MarkTaskComplete(List<string> tasks)
    {
        Console.WriteLine("\nMARK TASK AS COMPLETE:");

        if (tasks.Count == 0)
        {
            Console.WriteLine("The task list is empty. Add tasks first.");
            return;
        }

        ViewTaskList(tasks);

        Console.Write("Enter the index of the task to mark as complete: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < tasks.Count)
        {
            Console.WriteLine($"Task '{tasks[index]}' marked as complete.");
            tasks.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid index. Please try again.");
        }
    }

    static void ViewTaskList(List<string> tasks)
    {
        Console.WriteLine("\nVIEW TASK LIST:");

        if (tasks.Count == 0)
        {
            Console.WriteLine("The task list is empty. Add tasks first.");
            return;
        }

        Console.WriteLine("List of Tasks:");

        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }
}








