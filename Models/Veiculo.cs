using System.Text;

namespace GeradorDeDados.Models
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Renavam { get; set; }
        public string Cor { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Veiculo");
            sb.AppendLine($"Placa: {Placa}");
            sb.AppendLine($"Marca: {Marca}");
            sb.AppendLine($"Modelo: {Modelo}");
            sb.AppendLine($"Ano: {Ano}");

            return sb.ToString();
        }
    }
}

