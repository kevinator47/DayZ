namespace DayZ ;

using System.Net.Mime;
using System.Collections.Generic;
using System.Threading ;

class Program
{
    static void Main()
    {
        Game newgame = new Game() ;
    }
}

public class Game
{
    public Player P1 {get ; set ; }
    public Dictionary<string , Action<string>> CommPool = new Dictionary<string , Action<string>> () ;

    public Game()
    {
        Console.WriteLine(TextBox.Intro) ;
        
        Console.WriteLine(TextBox.WaitingMsg) ;
        Console.ReadLine();
        Console.Clear();

        P1 = new Player() ;  // crea un nuevo personaje
        Run();               // ejecuta el juego

        
    }

    private void Run()
    {
        Console.WriteLine(TextBox.First) ;
        Console.WriteLine(TextBox.Help1)  ;

        while(P1.Hp > 0)                    
        {
            // este bucle mantendra corriendo el programa pidiendole al usuario introducir algun comando
            Console.Write(">> ") ;
            string[] action = Console.ReadLine().ToLower().Split();

            if( !CommPool.ContainsKey(action[0]) )
            {
                Console.WriteLine("Comando no reconocido") ; // captura los comandos no validos *mostrar lo escrito por el usuario* 
                continue ;
            }
            
            CommPool[action[0]].Invoke(action[1]) ; // ?de momento todos los comandos tienen un unico argumento
        }
    }
}