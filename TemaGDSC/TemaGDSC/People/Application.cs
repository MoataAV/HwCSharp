using System.Reflection.Metadata;

namespace TemaGDSC.People;

public abstract class Application
{
    private string name;
    private int MaxUsers = 15;
    public List<User> Users = new List<User>(15);
    private int NumberOfUsers;

    public Application(string name, int MaxUsers, int NumberOfUsers, List<User> Users)
    {
        this.name = name;
        this.MaxUsers = MaxUsers;
        this.NumberOfUsers = Users.Count;
        this.Users = Users;
    }
    
    public string GetName()
    {
        return name;
    }

    public int GetNumberOfUsers()
    {
        return NumberOfUsers;
    }

    public int GetMaxUsers()
    {
        return MaxUsers;
    }

    public override string ToString()
    {
        return name + " " + NumberOfUsers;
    }
}