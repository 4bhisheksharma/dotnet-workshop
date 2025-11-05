
//Console.WriteLine("Hello from task 6");

class Program
{
    static void Main()
    {
        List<string> myFavFruits = new List<string> { "Apple", "Mango", "Litchi" };

        myFavFruits.Add("Guava");

        myFavFruits.Remove("Mango");
        foreach (string i in myFavFruits)
        {
            Console.WriteLine(i + "");
        }

        Dictionary<int, String> myFavFruitDict = new Dictionary<int, string>
        {
            {1,"Apple" },
            {2, "Mango"},
            {3, "Litchi"}

        };


        myFavFruitDict.Add(4, "Guava");
        


        foreach (var i in myFavFruitDict)
        {
            Console.WriteLine($"{i.Key} -> {i.Value}");
        }

    }
}