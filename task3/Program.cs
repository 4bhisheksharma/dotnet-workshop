
//Console.WriteLine("Hello, World from task 3");


class Program
{
    static void Main()
    {
        byte b = 6;
        short s = 2000;
        int i = 98;
        long l = 987456123L;
        float f = 14.2f;
        double d = 6.25;
        decimal dec = 987.654m;
        char c = 'S';
        bool apple = true;


        int val = 20;
        string intoString = val.ToString();

        string strapple = "1522.07";
        double intoDouble = Convert.ToDouble(strapple);

        Console.WriteLine($"byte: {b}");
        Console.WriteLine($"short: {s}");
        Console.WriteLine($"int: {i}");
        Console.WriteLine($"long: {l}");
        Console.WriteLine($"float: {f}");
        Console.WriteLine($"double: {d}");
        Console.WriteLine($"decimal: {dec}");
        Console.WriteLine($"char: {c}");
        Console.WriteLine($"bool: {apple}");
        Console.WriteLine($"The int value is converted into: {intoString}");
        Console.WriteLine($"The string value is convert into: {intoDouble}");
    }

}
