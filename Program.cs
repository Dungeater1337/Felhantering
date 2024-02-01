using System; 
class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            int result;
            if(!TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Skriv en siffra!");
            }
            else
            {
                Console.WriteLine(result); 
            }

            static bool TryParse(string s, out int result)
            {

                try
                {
                    result = int.Parse(s);
                    return true; 
                }

                catch
                {
                    result = -1;
                    return false;                  
                }
            }
        }
    }
}
