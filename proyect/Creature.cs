namespace DayZ ;

public class Creature
{
    // Propiedades
    public string Name {get ; set ;} 
    public int Atk {get ; set ;}
    public int Def {get ; set ;}
    public int Hp  {get ; set ;}

    // Metodos
    public Creature(string nm , int[] stats)
    {
        this.Name = nm ;
        this.Atk = stats[0] ;
        this.Def = stats[1] ;
        this.Hp  = stats[2] ;
    }

    public void ShowStatus()
    {
        Console.WriteLine(this.Name);
        Console.WriteLine("atk : {0}" , this.Atk) ;
        Console.WriteLine("def : {0}" , this.Def) ;
        Console.WriteLine("hp  : {0}" , this.Hp)  ;
        Console.WriteLine("--------------------------") ;
    }

    public void Attack (Creature target)
    {
        // Implementa el combate entre dos criaturas(*mejorar a un sistema mas desarrollado)
        Random randint = new Random() ;

        if(randint.Next(0,5) != 1)   // da una posibilidad del 20% de que el ataque falle
        {
            int dmg = Math.Max(0, this.Atk - target.Def) ;
            target.Hp -= dmg ;
            Console.WriteLine("{0} ha recibido {1} puntos de daño.", target.Name , dmg.ToString());
        }

        else
        {
            Console.WriteLine("El ataque sobre {0} ha fallado." , target.Name) ;
        }
    }
}