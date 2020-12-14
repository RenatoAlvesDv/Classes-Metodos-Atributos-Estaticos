using System;

namespace Classes_Metodos_Atributos_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamamos nossa classe estática, sem precisar enstanciar
            Console.WriteLine( Conversor.DolarParaReal(4F)) ;
            Console.WriteLine ( Conversor.RealParaDolar(50f) );

            Console.WriteLine( Conversor.EuroParaReal(4F)) ;
            Console.WriteLine ( Conversor.RealParaEuro(50f) );


            //Exemplo: classe
            Console.WriteLine ( Math.Pow(2 , 4) );

        }
    }
}
