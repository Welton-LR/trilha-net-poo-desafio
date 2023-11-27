namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Nokia : Smartphone
    {
         // Construtor que recebe parâmetros específicos do Nokia
        public Nokia(string numero, string modelo, string imei, string memoria) : base(numero)
        {
            Modelo = modelo;
            Numero = numero;
            IMEI = imei;
            Memoria = memoria;
            
            
        }

        // Sobrescrevendo o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia {Modelo}");
        }

        
    }
}
