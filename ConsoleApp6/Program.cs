using System.Reflection.Metadata;
class ConsoleApp2
{
    public static void Main()
    {
        int num_1, num_2;
        Console.WriteLine("Enter two integer numbers: ");
        num_1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the speed you are driving: ");
        num_2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a sign: ");
        char sign = char.Parse(Console.ReadLine());
        if (sign == '+')
        {
            Console.WriteLine("{0} + {1} = {2}!", num_1, num_2, (num_1 + num_2));
        }
        else
            Console.WriteLine("{0} - {1} = {2}!", num_1, num_2, (num_1 - num_2));
    }
}
