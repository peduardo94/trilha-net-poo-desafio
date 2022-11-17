namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar(string numero)
        {
            Console.WriteLine($"Ligando para o numero {numero}..");
        }

        public void ReceberLigacao(string numero)
        {
            Console.WriteLine($"Recebendo ligação do numero {numero}..");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}