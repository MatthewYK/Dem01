using MyLibrary;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageWriter writer = new MessageWriter();
            MyWriter.Write("Hello, Writer");
        }
    }
}
