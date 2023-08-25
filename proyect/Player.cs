namespace DayZ ;

public class Player : Creature
{
    Place actualZone ;  // para ubicar al personaje en una zona especifica y se pueda ir moviendo entre zonas

    public Player() : base("" , new int[] {3,2,10}) 
    {
        string confirm ;
        do
        {
            Console.Write(TextBox.CreatingPJ[0]) ;
            this.Name = Console.ReadLine();

            Console.WriteLine(TextBox.CreatingPJ[1]) ;
            confirm = Console.ReadLine() ;

            Console.Clear();

        } while (! confirm.StartsWith("s" , StringComparison.OrdinalIgnoreCase));

        Console.WriteLine(TextBox.CreatingPJ[2]) ;
        Thread.Sleep(3000) ;
        Console.Clear();

        Console.WriteLine(TextBox.CreatingPJ[3]) ;
        this.ShowStatus();

        Thread.Sleep(6000) ;
        Console.Clear();
    }

}