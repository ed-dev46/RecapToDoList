namespace ToDoList;

public class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public TaskStatus status { get; set; }

    public Task(string title, string description)
    {
        Title = title;
        Description = description;
        status = TaskStatus.PENDING;
    }

    public override string ToString()
    {
        return $"Task: {Title}\nStatus: {status}\nDescription: {Description}\n";
    }
}
