using System.Text;

namespace Lab_3;

public class WebSite<T> where T : TaskBase
{


    public List<T> Tasklist = new List<T>();


    public void PrintCompleteTasks()
    {
        var builder = new StringBuilder();
        builder.Append("По сайту сделаны следующие задачи: ");
        Tasklist.ForEach(el=> builder.Append($"{el.TaskName}, "));
        Console.WriteLine(builder);
        
    }
}