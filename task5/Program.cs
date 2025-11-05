
//Console.WriteLine("Hello, from task5");

class Program
{
    static void Main()
    {

        DateTime myBirthDate = new DateTime(2004, 6, 26);
        DateTime currentDate = DateTime.Now;
        TimeSpan ageSpan = currentDate - myBirthDate;
        int ageYear = (int)(ageSpan.TotalDays / 365);

        
        Console.WriteLine("Birth date: " + myBirthDate.ToShortDateString());
        Console.WriteLine("Current Date: " + currentDate.ToShortDateString());
        Console.WriteLine("Age: " + ageYear + " years");

        DateTime newDate = myBirthDate.AddDays(10);
        Console.WriteLine("Birthdate with added 10 days: " + newDate.ToShortDateString());
    }
}