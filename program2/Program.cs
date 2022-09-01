using System; 

namespace uri1044
{
    class Program2
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("digite dois números: ");

            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);  

            if (x % y == 0 || y % x == 0){
                Console.WriteLine("Sao multiplos");
            }
            else { 
                Console.WriteLine("Nao sao multiplos");
            } 
        }
    }
}