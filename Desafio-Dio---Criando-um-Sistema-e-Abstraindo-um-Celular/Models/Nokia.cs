
    // TODO: Herdar da classe "Smartphone"  

     // TODO: Sobrescrever o método "InstalarAplicativo"
    
namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia.");
        }
    }
}
