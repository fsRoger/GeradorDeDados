using GeradorDeDados.Models;
using HtmlAgilityPack;
using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;

namespace GeradorDeDados.Services
{
    public class VeiculoService
    {
        private static readonly string _hostUrl = "https://www.4devs.com.br/";

        public static async Task<Veiculo> RequestVeiculo(string estado)
        {
            var client = new RestClient(_hostUrl);
            var request = new RestRequest("ferramentas_online.php", Method.Post);
            request.AddParameter("acao", "gerar_veiculo");
            request.AddParameter("estado", estado);

            var response = await client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine("Falha ao acessar a API de geração de veículos.");
                return null;
            }

            try
            {
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(response.Content);

                Veiculo veiculo = new Veiculo();

                veiculo.Marca = ExtractValue(doc, "marca");
                veiculo.Modelo = ExtractValue(doc, "modelo");
                veiculo.Ano = ExtractValue(doc, "ano");
                veiculo.Renavam = ExtractValue(doc, "renavam");
                veiculo.Placa = ExtractValue(doc, "placa_veiculo");
                veiculo.Cor = ExtractValue(doc, "cor");

                return veiculo;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar dados do veículo: {ex.Message}");
                return null;
            }
        }

        private static string ExtractValue(HtmlDocument doc, string id)
        {
            var node = doc.GetElementbyId(id);
            return node != null ? node.GetAttributeValue("value", string.Empty) : string.Empty;
        }
    }
}
