using GeradorDeDados.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;

namespace GeradorDeDados.Services
{
    public class PessoaService
    {
        private static readonly string _hostUrl = "https://www.4devs.com.br/";
        
        public static async Task<Pessoa> RequestPessoa()
        {
            var client = new RestClient(_hostUrl);
            var request = new RestRequest("ferramentas_online.php", Method.Post);

            request.AddParameter("acao", "gerar_pessoa");
            request.AddParameter("sexo", "I");
            request.AddParameter("pontuacao", "S");
            request.AddParameter("idade", "18");
            request.AddParameter("txt_qtde", "1");
            request.AddParameter("cep_estado", "");

            try
            {
                RestResponse response = await client.ExecuteAsync(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Console.WriteLine("Falha ao acessar a API de geração de pessoas.");
                    return null;

                }

                if (string.IsNullOrEmpty(response.Content))
                {
                    Console.WriteLine("Falha em trazer dados da api");
                    return null;
                }

                Pessoa dadosDeserializados = JsonConvert.DeserializeObject<Pessoa[]>(response.Content)[0];

               return dadosDeserializados;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar dados da pessoa: {ex.Message}");
                return null;
            }
        }
    }
}
