using System.Collections.Generic;

namespace JobForum.Models
{
  public class Job
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Contact { get; set; }
    private static List<Job> _instances = new List<Job> { };

    public Job(string title, string description, string contact)
    {
      Title = title;
      Description = description;
      Contact = contact;
      _instances.Add(this);
    }

    public static List<Job> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}