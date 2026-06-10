/*

**TO DO LIST**

*/
List<ToDoList.Task> taskList = new List<ToDoList.Task>()
{
    new ToDoList.Task("task1", "taskdescription"),
    new ToDoList.Task("task2", "taskdescription")
};

while (true)
{
    Console.WriteLine("-- TO DO LIST --");
    Console.WriteLine("Digite a funcao desejada:");
    Console.WriteLine("0. Exit\n1. Create new task\n2. Print all tasks\n3. Change task status\n");

    switch (Console.ReadLine())
    {
        case "0":
            Console.WriteLine("Exiting...");
            return;
        break;
        case "1":
            Console.WriteLine("Enter task title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter task description:");
            string description = Console.ReadLine();

            //try catch
            ToDoList.Task newTask = new ToDoList.Task(title, description);

            taskList.Add(newTask);

            Console.WriteLine("Task created succesfully!\n");
        break;
        case "2":
            foreach (var task in taskList)
            {
                Console.WriteLine(task);
            }
        break;
        default:
            Console.WriteLine("Enter a valid option!\n");
        break;
    }
}

/*
ToDoList.Task task = new ToDoList.Task("task1", "taskdescript");
ToDoList.Task task2 = new ToDoList.Task("task2", "taskdescript");

task2.status = ToDoList.TaskStatus.DONE;

Console.Write(task);
Console.Write(task2);
*/