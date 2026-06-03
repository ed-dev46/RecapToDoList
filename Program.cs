/*

**TO DO LIST**

*/

ToDoList.Task task = new ToDoList.Task("task1", "taskdescript");
ToDoList.Task task2 = new ToDoList.Task("task2", "taskdescript");

task2.status = ToDoList.TaskStatus.DONE;

Console.Write(task);
Console.Write(task2);