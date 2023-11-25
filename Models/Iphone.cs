namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Adicionando propriedades específicas do iPhone
        public string Modelo { get; set; }
        public string SistemaOperacional { get; set; }

        // Construtor que recebe parâmetros específicos do iPhone
        public Iphone(string numero, string modelo, string sistemaOperacional) : base(numero)
        {
            Modelo = modelo;
            SistemaOperacional = sistemaOperacional;
        }

        // Sobrescrevendo o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no iPhone {Modelo} com SO {SistemaOperacional}");
        }

        // Outros métodos específicos do iPhone, se necessário
    }
}
