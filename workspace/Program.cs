// See https://aka.ms/new-console-template for more information
using workspace.Linq;

public class Welcome
{
    public static void Main(string[] arg)
    {
        Console.WriteLine("Hello World");
        SelectVsSelectMany selectVsSelectMany= new SelectVsSelectMany();
        selectVsSelectMany.ReturnResponse();

    }
}
