namespace DayZ ;

public class Place
{
    string Name {get; set;}
    string Desc {get; set;}


    Place Father {get ; set ;}  // almacena la zona que contiene a la zona actual 
    public List<Place> Ady ;    // almacena las zonas adyacentes a la actual
    public List<Place> Sub ;    // almacena las subzonas de la zona actual

    public List<Creature> Enemies ; // almacena los enemigos en la zona

    public Place( string nm , string desc)
    {
        this.Name = nm ;
        this.Desc = desc ;
    }

    public void AddSub(Place subzone)
    {
        // Añade una subzona a la zona actual y marca esta como padre de la subzona
        this.Sub.Add(subzone) ;
        subzone.Father = this ;
    }

    public void AddAdy(Place adyzone)
    {
        // Añade una zona como adyacente a la actual y añade la actual como adyacente de la otra(si no está ya añadida)
        this.Ady.Add(adyzone) ;

        if(! adyzone.Ady.Contains(this))
        {
            adyzone.Ady.Add(this);
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine(this.Name + "\n");
        Console.WriteLine(this.Desc  + "\n");

        if(this.Father != null)
        {
            Console.WriteLine(Father.Name) ;
        }
        
        Console.WriteLine("Subzonas");
        for (int i = 0; i < this.Sub.Count ; i++)
        {
            Console.WriteLine(this.Sub[i].Name);
        }
        Console.WriteLine();


        Console.WriteLine("Zonas Adyacentes");
        for (int i = 0; i < this.Ady.Count ; i++)
        {
            Console.WriteLine(this.Ady[i].Name);
        }
    
        Console.WriteLine("---------------------------------------");
    }
}