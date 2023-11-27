namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public string SistemaOperacional { get; set; }

        // Construtor que recebe parâmetros específicos do iPhone
        public Iphone (string numero, string modelo, string imei, string memoria, string sistema) : base(numero)
        {
            Modelo = modelo;
            Numero = numero;
            IMEI = imei;
            Memoria = memoria;
            SistemaOperacional = sistema;
            
            
        }

        // Sobrescrevendo o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no iPhone {Modelo} com Sistema Operacional {SistemaOperacional}");
        }

        // Outros métodos específicos do iPhone, se necessário
    }
}
