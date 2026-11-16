public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public double Avarage { get; set; }

    public Student(int id, string name, int age, double avarage)
    {
        Id = id;
        Name = name;
        Age = age;
        Avarage = avarage;
    }

    public void GetInfo()
    {
        System.Console.WriteLine($"Id={Id}; Name: {Name}, Age: {Age}, Average Grade: {Avarage.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture)}");
    }

    public bool IsExcellentStudent()
    {
        return Avarage > 4.0;
    }
}