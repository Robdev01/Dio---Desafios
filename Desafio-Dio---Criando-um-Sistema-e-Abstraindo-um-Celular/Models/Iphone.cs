namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public string Senha { get; set; }

        public Iphone(string numero, string modelo, string imei, int memoria, string senha) 
            : base(numero, modelo, imei, memoria)
        {
            Senha = senha;
        }

        // Sobrescrevendo o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Para instalar {nomeApp}, insira sua senha: {Senha}");
        }
    }
}
