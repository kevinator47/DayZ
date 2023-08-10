namespace DayZ ; 

using System ;
using System.Threading ;

class Program
{
    static void Main()
    {
        Player Pj = NewGame();
        Hermito M = new Hermito();    
    }

    public static Player NewGame()
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
        
        Random randint = new Random();   // para determinar las estadisticas
        return new Player(new int[] {randint.Next(2,12) , randint.Next(2,12) , randint.Next(2,12) , randint.Next(2,12)});
    }
}