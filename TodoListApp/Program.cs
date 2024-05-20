using System.Collections.Generic;

class TodoApp {

    enum UserActions{
        AddTask = 1,
        Exit
    }
    public static void Main(string[] args) {
        List<string> toDoList = new List<string>();

        while (true) {
            Console.WriteLine("You Can: ");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. Exit");

            int choice = int.Parse(Console.ReadLine());

            if(choice == (int)UserActions.AddTask) {
                Console.WriteLine("Enter the task name: ");
                string taskName = Console.ReadLine();
                toDoList.Add(taskName);
                Console.Clear();
                Console.WriteLine("Task added successfully");
            }
            else if(choice == (int)UserActions.Exit) {
                break;
            }
        }
    }
}