using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace TemaGDSC.People;

public class Admin
{
    private string name;
    public List<Application> Aplic = new List<Application>();

    public Admin(string name, List<Application> Aplic)
    {
        this.name = name;
        this.Aplic = Aplic;
    }
    
    public void AddUser(User user, Application app)
    {
        if (app.Users.Count >= app.GetMaxUsers())
        {
            Console.WriteLine("Can't add anymore");
            
        }
        else
        {
            app.Users.Add(user);
        }
        
    }

    public void RemoveUser(User user, Application app)
    {
        if (app.Users.Count == 0)
        {
            Console.WriteLine("No user to remove");
        }
        else
        {
            app.Users.Remove(user);
        }
    }
}