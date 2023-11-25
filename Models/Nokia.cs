namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Adicionando propriedade específica do Nokia
        public string Modelo { get; set; }

        // Construtor que recebe parâmetros específicos do Nokia
        public Nokia(string numero, string modelo) : base(numero)
        {
            Modelo = modelo;
        }

        // Sobrescrevendo o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia {Modelo}");
        }

        // Outros métodos específicos do Nokia, se necessário
    }
}
