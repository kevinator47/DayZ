namespace DayZ;

public class Tools
{
    public static string GetLetter(int num)
    {
        if(num > 9)
        {
            char letter = (char)('A' + (num - 10));
            return letter.ToString() ;
        }
        return num.ToString();
            
        
    }
}