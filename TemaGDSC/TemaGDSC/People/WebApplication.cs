using System.Runtime.CompilerServices;

namespace TemaGDSC.People;

public class WebApplication : Application
{
    public WebApplication(string name, int MaxUsers, int NumberOfUsers, List<User> Users) : base(name, MaxUsers, NumberOfUsers, Users) { }
    
    public void HttpRequest(User user)
    {
        foreach (var u in Users)
        {
            if (user.ToString() == u.ToString())
            {
                Console.WriteLine("Ok Request");
            }
            else Console.WriteLine("Bad Request");
        }
    }
}