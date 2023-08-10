namespace DayZ ;

public class Player : Criature
{
    // Properties
    // (Aqui ira luego lv , xp, dinero , zonaActual , etc)

    // Methods

    // constructor
    public Player(int[] stats) : base(stats)
    {
        ChooseName();
        
        // para que se vea cool
        Console.WriteLine("Creando personaje.....") ;
        Thread.Sleep(1000) ;
        Console.Clear();

        this.ShowStatus();
        Console.WriteLine("------------------------------");

        Thread.Sleep(3000) ;
        Console.Clear();
    }

    private void ChooseName()
    {
        string ask ;   
        do
        {
            Console.Write("Introduzca el nombre de su personaje : ");
            this.Name = Console.ReadLine() ;

            Console.Write("Está seguro? (S/N) : ") ;
            ask = Console.ReadLine() ;

        } while (! ask.StartsWith("s" , StringComparison.OrdinalIgnoreCase)) ;
       
        Console.Clear();
    }
}