using System.Text;

namespace ConsoleApp2;

public class Program
{
    public static void Main(string[] args)
    {
        var str = GetNextDocumentNumber("BL-5000");
        Console.WriteLine(str  );
    }
    
    public static string GetNextDocumentNumber(string documentNumber)
    {
        var splitted = documentNumber.Split("-");

        int a = Encoding.ASCII.GetBytes(splitted[0][0].ToString())[0];
        var b = Encoding.ASCII.GetBytes(splitted[0][1].ToString())[0];
        
        
        int number = int.Parse("1"+splitted[1]);

        if ((number == 19999))
        {
            if (a == 90 && b == 90)
            {
                return "AA-0000";
            }
            else if (splitted[0][1] == 'Z')
            {
                a++;
                number = 10000;
            }
            else
            {
                b++;
                number = 10000;
            }
        }
        else
        {
            number++;
        }

        char A = (char)a;
        char B = (char)b;
            
        return $"{A}{B}-{number.ToString().Substring(1)}";
    }
}