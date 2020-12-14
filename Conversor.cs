namespace Classes_Metodos_Atributos_Estaticos
{
    public class Conversor
    {
        private static float cotacaoDolar = 5.07f;

        private static float cotacaoEuro = 6.17f;

        public static float RealParaDolar(float valorRS){
            return valorRS / cotacaoDolar;
        }

        public static float DolarParaReal(float valorDolar){
            return valorDolar * cotacaoDolar;
        }

        public static float EuroParaReal(float valorEuro ){
             return valorEuro * cotacaoEuro;

        }

        
        public static float RealParaEuro(float valorRS){
            return valorRS / cotacaoEuro;

        

        }
    }
}