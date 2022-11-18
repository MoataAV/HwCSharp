namespace TemaGDSC.People;

public class User
{
    private string username;
    private string password;
    private string email;

    public User(string username, string password, string email)
    {
        this.username = username;
        this.password = password;
        this.email = email;
    }
    
    public string GetMail()
    {
        return email;
    }

    public string ChangePassword(string newPassword)
    {
        this.password = newPassword;

        return password;
    }

    public override string ToString()
    {
        return username + " " + email;
    }
}