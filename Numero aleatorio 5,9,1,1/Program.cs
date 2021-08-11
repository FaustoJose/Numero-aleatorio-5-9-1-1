using System;

namespace Numero_aleatorio_5_9_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            aleatorio();
        }
        public static void aleatorio()
        {
            Random r = new Random();
            int aleatorio = r.Next(1,100);
            int oportunidad = 0;
            int contesta = 0;
            int intento = 0;
            Console.WriteLine("Introduce un numero entre 1 y 100, tratando de acertar el numero aleatoreo ");
            do
            {
                intento++;
                oportunidad = 6 - intento;
                
                contesta = Convert.ToInt32(Console.ReadLine());
                if (contesta == aleatorio)
                {
                    Console.WriteLine("El numero que introduciste es: " + contesta);
                    Console.WriteLine(" y el numero a la azar es: " + aleatorio);
                    Console.WriteLine("Has acertado con " + intento + " Intentos");
                }
                else
                {
                    Console.WriteLine("El numero que introduciste es: " + contesta);
                    //Console.WriteLine(" y el numero a la azar es: " + aleatorio);
                    Console.WriteLine("No has acertado te quedan " + oportunidad + " Intentos");
                    Console.WriteLine("");
                    Console.WriteLine(" ");
                    
                }
                if (intento==6)
                {
                    Console.WriteLine("Has Fracasado "+oportunidad+" Intentos ");
                    Console.WriteLine("El numero al Azar es: "+aleatorio);
                }
                else
                {
                    Console.WriteLine("Intentalo de nuevo ");
                }




            } while ((contesta != aleatorio) && (intento != 6));

        }
    }
}
