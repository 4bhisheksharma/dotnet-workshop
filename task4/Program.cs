
//Console.WriteLine("Hello, from task 4");
class Program
{
    static void Main()
    {
        int[] myFavNumbers = { 9,8,7,6,5 };
        Array.Sort(myFavNumbers);
        Array.Reverse(myFavNumbers);

        Console.WriteLine("Desending order:");
        for (int i = 0; i < myFavNumbers.Length; i++)
        {
            Console.WriteLine(myFavNumbers[i]);
        }
        int findNumber = 5;
        int index = Array.IndexOf(myFavNumbers, findNumber);

        Console.WriteLine($"\nPosition of {findNumber} in array: {index}");
    }
}