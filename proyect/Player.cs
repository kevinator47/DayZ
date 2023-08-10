namespace DayZ ;

public class Player : Criature
{
    // Properties
    // (Aqui ira luego lv , xp, dinero , zonaActual , etc)

    // Methods

    // constructor
    public Player()
    {
        Random randint = new Random();   // para determinar las estadisticas
        
        // name
        string ask ;
        do
        {
            Console.Write("Introduzca el nommbre de su personaje : ");
            this.Name = Console.ReadLine() ;

            Console.Write("Está seguro? (S/N) : ") ;
            ask = Console.ReadLine() ;

        } while (! ask.StartsWith("s" , StringComparison.OrdinalIgnoreCase)) ;

        Console.Clear();

        Console.WriteLine("Creando personaje.....") ;
        Thread.Sleep(3000) ;
        Console.Clear();


        // stats
        this.F = randint.Next(2,12);
        this.D = randint.Next(2,12);
        this.I = randint.Next(2,12);
        this.S = randint.Next(2,12);

        Console.WriteLine("Personaje creado") ;
        this.ShowStatus();

        Thread.Sleep(6000) ;
        Console.Clear();
    }

    public void ShowStatus()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Nombre : {0}" , this.Name) ;
        Console.WriteLine("Stats : " + this.Stats()) ;
        Console.WriteLine("------------------------------------------");
    }

    private string Stats()
    {
        string output = "" ;
        int[] st = new int[4]{this.F , this.D , this.I , this.S } ;

        foreach (int num in st)
        {
            output += Tools.GetLetter(num) ;
        }
        return output ;
    }

}