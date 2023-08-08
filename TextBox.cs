public class TextBox
{
    /* esta clase contiene los mensajes que aparecen durante el juego para no tener que estar 
    poniendolos en el principal(ademas si quiero que el usuario elija el idioma es mas facil para cambiar
    los textos)*/


    // mensajes
    public string start ;
    public string intro ;
    public string intro2 ;

    // constructor
    public TextBox()
    {
        this.start = @"Bienvenido a Day-Z, un juego de rol de consola ambientado en un apocalipsis zombie 
        (No es una copia de TWD). Pulse Enter para comenzar... " ;

        this.intro = @"Tras varias semanas inconsciente en el hospital de la ciudad, despiertas en el peor momento posible.
        Escuchas gritos y pasos precipitados, además de gruñidos que te hacen percatarte de que algo no anda bien."

        this.intro2 = @"De momento no he hecho nada de la historia y solo tienes que enfrentarte a un Hermito salvaje. Buena Suerte!
        (Pulse Enter para continuar)" ;
    }
}