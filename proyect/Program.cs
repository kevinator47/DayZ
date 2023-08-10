namespace DayZ ; 

using System ;
using System.Threading ;

class Program
{
    static void Main()
    {
        NewGame();    
    }

    public static void NewGame()
    {
        Console.Clear();
        TextBox Tbx = new TextBox();

        Console.WriteLine(Tbx.start);
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine(Tbx.intro);
        Thread.Sleep(3000) ;
        
        Console.WriteLine(Tbx.intro2);
        
        Console.ReadLine();
        Console.Clear();
        
        Player Pj = new Player();
    }
}