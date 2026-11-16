public class User
{
    public string FirstName;
    public string LastName;
    public string UserName;
    private string password;

    public User(string firstName, string lastName, string userName, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        UserName = userName;
        this.password = password;
    }

    public void GetInfo()
    {
        System.Console.WriteLine($"FullName: {FirstName} {LastName}");
        System.Console.WriteLine($"UserName: {UserName}");
    }

    public bool Login(string userName, string password)
    {
        if (UserName == userName && this.password == password)
        {
            System.Console.WriteLine($"Login successful! Welcome, Mr./Ms. {FirstName} {LastName}");
            return true;
        }
        return false;
    }
}