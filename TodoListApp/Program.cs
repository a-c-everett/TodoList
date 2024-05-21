using System.Collections.Generic;

class TodoApp
{

    enum UserActions
    {
        AddTask = 1,

        DeleteTask,
        Exit
    }
    public static void Main(string[] args)
    {
        List<string> toDoList = new List<string>();


        while (true)
        {
            if (toDoList.Count > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("ToDo List: ");
                for (int i = 0; i < toDoList.Count; i++)
                {
                    Console.WriteLine("(" + (i + 1) + ") " + toDoList[i]);
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("No tasks on your list.");
                Console.WriteLine("");
            }

            Console.WriteLine("You Can: ");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. Delete a task");
            Console.WriteLine("3. Exit");
            Console.WriteLine("");

            int choice = int.Parse(Console.ReadLine());

            if (choice == (int)UserActions.AddTask)
            {
                Console.WriteLine("Enter the task name: ");
                string taskName = Console.ReadLine();
                toDoList.Add(taskName);
                Console.Clear();
                Console.WriteLine("Task added successfully");
            }
            else if (choice == (int)UserActions.DeleteTask)
            {
                Console.WriteLine("Enter the number of the task you want to delete: ");
                int taskNum = int.Parse(Console.ReadLine());

                while (taskNum < 1 || taskNum > toDoList.Count)
                {
                    Console.WriteLine("Please enter a valid list item number: ");
                    taskNum = int.Parse(Console.ReadLine());
                }

                toDoList.RemoveAt(taskNum - 1);
                Console.WriteLine("Task deleted successfully!");



            }
            else if (choice == (int)UserActions.Exit)
            {
                break;
            }
        }
    }
}