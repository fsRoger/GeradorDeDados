using Newtonsoft.Json;
using System.Text;

namespace GeradorDeDados.Models
{
    public class Pessoa
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("idade")]
        public int Idade { get; set; }

        [JsonProperty("cpf")]
        public string CPF { get; set; }

        [JsonProperty("rg")]
        public string RG { get; set; }

        [JsonProperty("data_nasc")]
        public string DataNascimento { get; set; }

        [JsonProperty("sexo")]
        public string Sexo { get; set; }

        [JsonProperty("signo")]
        public string Signo { get; set; }

        [JsonProperty("mae")]
        public string Mae { get; set; }

        [JsonProperty("pai")]
        public string Pai { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("senha")]
        public string Senha { get; set; }

        [JsonProperty("cep")]
        public string CEP { get; set; }

        [JsonProperty("endereco")]
        public string Endereco { get; set; }

        [JsonProperty("numero")]
        public int Numero { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("cidade")]
        public string Cidade { get; set; }

        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonProperty("telefone_fixo")]
        public string TelefoneFixo { get; set; }

        [JsonProperty("celular")]
        public string Celular { get; set; }

        [JsonProperty("altura")]
        public string Altura { get; set; }

        [JsonProperty("peso")]
        public int Peso { get; set; }

        [JsonProperty("tipo_sanguineo")]
        public string TipoSanguineo { get; set; }

        [JsonProperty("cor")]
        public string Cor { get; set; }

        [JsonProperty("veiculo")]
        public Veiculo Veiculo { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("-------------------------------------------------------------------------");
            sb.AppendLine();
            sb.AppendLine("Pessoa");
            sb.AppendLine($"Nome: {Nome}");
            sb.AppendLine($"CPF: {CPF}");
            sb.AppendLine($"Data de Nascimento: {DataNascimento}");
            sb.AppendLine($"Estado: {Estado}");
            sb.AppendLine($"Telefone: {TelefoneFixo}");

            sb.AppendLine();
            sb.AppendLine(Veiculo.ToString());

            return sb.ToString();
        }
    }
}
