namespace DayZ ; 

using System ;
using System.Threading ;

class Program
{
    static void Main()
    {
        TextBox Tbx = new TextBox();

        Console.WriteLine(Tbx.start);
        Console.ReadLine();

        Console.WriteLine(intro);
        Thread.Sleep(3000) ;
        
        Console.WriteLine(intro2);
        
        Console.ReadLine();
        Console.Clear();
        
        Player Pj = new Player();
        
        
    }
}