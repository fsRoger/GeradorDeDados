
using GeradorDeDados.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeradorDeDados.Services
{
    public class GeradorListaService
    {
        private static readonly List<Pessoa> _pessoas = new List<Pessoa>();

        public static async Task GerarLista()
        {
            try
            {
                Console.WriteLine("Digite o número de pessoas que deseja gerar:");
                int quantidade;
                if (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                    return;
                }

                while (_pessoas.Count < quantidade)
                {
                    try
                    {
                        Pessoa pessoa = await PessoaService.RequestPessoa();
                        if (pessoa == null)
                        {
                            Console.WriteLine("Falha ao gerar pessoa.");
                            continue;
                        }

                        pessoa.Veiculo = await VeiculoService.RequestVeiculo(pessoa.Estado);
                        if (pessoa.Veiculo == null)
                        {
                            Console.WriteLine("Falha ao gerar veículo.");
                            continue;
                        }

                        _pessoas.Add(pessoa);
                  
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao gerar pessoa/veículo: {ex.Message}");
                    }
                }
                MostrarLista();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }

        public static void MostrarLista()
        {
            foreach (Pessoa pessoa in _pessoas)
            {
                Console.WriteLine(pessoa.ToString());
            }
        }
    }
}
