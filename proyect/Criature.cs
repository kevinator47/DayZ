namespace DayZ ;

public class Criature
{
    /* Esta clase representa las criaturas del juego, las cuales tendran un nombre(zombi , bandido , etc), unas estadisticas
    (Fuerza, Destreza, Intuicion , Sabiduria) y comportamientos como atacar(usando el sistema PBA-PBD) y recibir daño.
    */

    // Properties
    public string Name {get ; set ;}

    // stats
    public int F {get ; set ;} 
    public int D {get ; set ;} 
    public int I {get ; set ;} 
    public int S {get ; set ;} 

   
    // constructor
    public Criature(int[] stats)
    {
        // recibe las estadisticas de cada criatura que se cree(cada criatura tendra sus stats personalizadas en su propia clase)
        this.F = stats[0] ;
        this.D = stats[1] ;
        this.I = stats[2] ;
        this.S = stats[3] ;
        
    }
   
   
    // Methods
    
    public void ShowStatus()
    {
        Console.WriteLine(this.Name) ;
        Console.WriteLine("Stats : " + this.Stats()) ;
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
    
    public void Attack(Criature obj)
    {
        /* 
        Este metodo describe el ataque de la criatura actual sobre otra, a traves del sistema PBA-PBD
        Se calcula la PBA(Puntuacion Basica de Ataque) del agresor y la PBD(Puntuacion Basica de Defensa) del atacado
        el daño será la diferencia entre ambas puntuaciones y se le restará a la F y la D del atacado, cuando ambas llegan a cero muere.
        */
        Random randint = new Random();

        int PBA = (this.F + this.D) / 2 + randint.Next(1,7) ;
        int PBD = (obj.F + obj.D) / 2 ;

        int dmg = Math.Max(0, PBA - PBD) ;
        obj.ReceiveDmg(dmg);
        
    }

    public void ReceiveDmg(int dmg)
    {
        /* Esta función realiza el daño a una criatura luego de recibir un ataque, este se divide aleatoriamente 
        y se le resta a las estadisticas de F y D */

        /* Al restar el daño si la estadística cae por debajo de cero, se vuelve cero y el daño sobrante se le quita a la otra
        este if se hace para evitar el caso donde ambas caen a negativo*/
        
        if(dmg >= this.F + this.D)
        {
            // si el daño es mayor que la suma de las estadísticas estas se reducen a cero
            this.F = 0 ;
            this.D = 0 ;
        }

        else
        {
            Random randint = new Random(); 
            
            int decrF = randint.Next(0, dmg + 1) ; // picando aleatoriamente el daño
            int decrD = dmg - decrF ;

            this.F -= decrF ;

            if(this.F < 0)
            {
                // si sobrepasa los puntos que se pueden restar se añaden los sobrantes al decremento en Destreza
                decrD += Math.Abs(this.F);
                this.F = 0 ;
            }

            this.D -= decrD ;
            
            if(this.D <= 0)
            {
                // lo mismo
                this.F -= Math.Abs(this.D);
                this.D = 0 ;
            }
        }
    }

}