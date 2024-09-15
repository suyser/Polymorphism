using Polymorphism;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomConverter converter = new CustomConverter();
        string input = "123";

        converter.Convert(input, out int result1);
        Console.WriteLine(result1);
        converter.Convert(input, out string result2);
        Console.WriteLine(result2);
        converter.Convert(input, out double result3);
        Console.WriteLine(result3);
    }

}