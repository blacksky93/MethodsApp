using Methods;

namespace MethodsApp;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Test");
        //SampleMethods.HelloWorld();

        //for (int i = 0; i < 10; i++)
        //{
        //    SampleMethods.HelloWorld();
        //}
        string str = SampleMethods.SayHi();
        // DRY Don't repeat yourself. Don't repeat logic.
        Console.WriteLine(str);
    }
}
