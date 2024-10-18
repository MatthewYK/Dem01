using MyLibrary;
using System.Xml;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageWriter Mywriter = new MessageWriter();
            Mywriter.Write("Hello, Writer");

            FiggleWriter FWriter = new FiggleWriter();
            FWriter.Write("Hello, Writer");
        }
    }
}
