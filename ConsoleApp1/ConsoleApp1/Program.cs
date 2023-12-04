namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Numbers");
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Add(num1, num2));
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
