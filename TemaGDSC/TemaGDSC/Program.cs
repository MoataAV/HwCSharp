using System.Security.Cryptography;
using TemaGDSC.People;

User u = new User("LucianM", "Luci123", "Lucmoc@yahoo.com");
User u1 = new User("LucianM", "Luci123", "Lucmoc@yahoo.com");
User u2 = new User("Calin", "123", "CaLin@yahoo.com");
User u3 = new User("Alex", "1234", "Alex2@yahoo.com");
Console.WriteLine(u.ToString());

WebApplication w = new WebApplication("The Game", 15, 0, new List<User>());

w.Users.Add(u);
w.HttpRequest(u1);
w.HttpRequest(u2);

MobileApplication m = new MobileApplication("Other Game", 15, 0, new List<User>());

m.Users.Add(u2);
m.Users.Add(u3);
m.Users.Add(u);
Console.WriteLine(m.RateApp());

Admin a = new Admin("Mihai", new List<Application>());

a.AddUser(u3, w);
a.RemoveUser(u2, m);





