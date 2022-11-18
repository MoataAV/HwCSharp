namespace TemaGDSC.People;

public class MobileApplication : Application
{
    public MobileApplication(string name, int MaxUsers, int NumberOfUsers, List<User> Users) : base(name, MaxUsers, NumberOfUsers, Users) { }
    private double Rating;

    private double r;
    private double s = 0;

    public double RateApp()
    {
        foreach (var u in Users)
        {
            Console.WriteLine("Give a Rating:");
            string str = Console.ReadLine();
            r = double.Parse(str);
            s = s + r;
          
        }
        
        return s / Users.Count;
        
    }
}