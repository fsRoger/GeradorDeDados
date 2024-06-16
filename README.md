
# Gerador de Dados

Bem-vindo ao projeto **Gerador de Dados**! Esta aplicação permite a geração de dados fictícios de pessoas e veículos utilizando a API do site [4devs](https://www.4devs.com.br/). Os dados gerados incluem informações pessoais, como nome e CPF, e detalhes de veículos, como marca e modelo. Este projeto foi desenvolvido em C# e utiliza a biblioteca `RestSharp` para realizar as requisições HTTP e `HtmlAgilityPack` para parsing de HTML.

## Funcionalidades

- Geração de uma lista de pessoas com dados fictícios.
- Cada pessoa gerada tem associada um veículo fictício.
- Exibição dos dados gerados no console.

## Pré-requisitos

Para rodar esta aplicação, você precisará ter:

- [.NET SDK](https://dotnet.microsoft.com/download) instalado em sua máquina.
- Um editor de código, como [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/).
- [Git](https://git-scm.com/) para clonar o repositório (opcional, mas recomendado).

## Instalação

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/fsRoger/gerador-de-dados.git
   ```

2. **Navegue até o diretório do projeto:**

   ```bash
   cd gerador-de-dados
   ```

3. **Restaure as dependências do projeto:**

   ```bash
   dotnet restore
   ```

4. **Construa o projeto:**

   ```bash
   dotnet build
   ```

## Como Executar

1. **Execute o projeto:**

   ```bash
   dotnet run
   ```

2. **Interaja com a aplicação:**

   - Ao iniciar a aplicação, você será solicitado a informar o número de pessoas que deseja gerar.
   - Digite o número desejado e pressione `Enter`.
   - A aplicação irá gerar a lista de pessoas e veículos e exibirá os resultados no console.

## Testando a Aplicação

### Teste Básico

1. **Inicie a aplicação:**

   ```bash
   dotnet run
   ```

2. **Digite o número de pessoas que deseja gerar:**

   - Exemplo: `5` para gerar 5 pessoas e veículos.

3. **Verifique a saída no console:**

   - A aplicação exibirá os dados das pessoas e seus respectivos veículos.
   - Confira se todas as informações foram geradas corretamente.

### Teste com Diferentes Quantidades

1. **Execute novamente a aplicação:**

   ```bash
   dotnet run
   ```

2. **Informe diferentes quantidades de pessoas:**

   - Teste com 1, 10, 50 ou qualquer outro número para validar a escalabilidade da aplicação.

3. **Verifique a resposta:**

   - Certifique-se de que a aplicação não falhe e que os dados sejam exibidos conforme esperado.

## Estrutura do Projeto

- **Program.cs:** Ponto de entrada da aplicação que chama o serviço de geração de lista.
- **GeradorListaService.cs:** Serviço que gera uma lista de pessoas com veículos.
- **PessoaService.cs:** Serviço que faz a requisição para gerar dados de pessoas.
- **VeiculoService.cs:** Serviço que faz a requisição e extrai dados de veículos.
- **Models/Pessoa.cs:** Classe que representa uma pessoa.
- **Models/Veiculo.cs:** Classe que representa um veículo.

## Como Funciona

- A aplicação faz uma requisição para a API do 4devs para gerar dados fictícios de pessoas e veículos.
- Os dados recebidos são processados e exibidos no console.
- O serviço `PessoaService` realiza a requisição para gerar pessoas e o serviço `VeiculoService` faz o parsing do HTML para extrair os dados dos veículos.

## Problemas Comuns e Soluções

- **Erro de conexão com a API:**
  - Verifique se você tem acesso à internet.
  - Verifique se o site do 4devs está acessível no momento.

- **Dados não são gerados:**
  - Certifique-se de que os parâmetros de requisição estão corretos.
  - Confira se a API do 4devs está respondendo adequadamente.

## Contribuindo

1. Faça um fork do repositório.
2. Crie uma branch para suas alterações (`git checkout -b minha-feature`).
3. Commit suas mudanças (`git commit -am 'Adicionei uma nova feature'`).
4. Faça um push para a branch (`git push origin minha-feature`).
5. Crie um novo Pull Request.

## Contato

Para mais informações ou dúvidas, entre em contato pelo email: `fsroger@outlook.com`.

---

Muito obrigado por conferir nosso projeto! Se você encontrou alguma dificuldade ou tem sugestões, sinta-se à vontade para abrir uma issue no GitHub. Divirta-se gerando dados! 🚀

---

**Observação:** Este projeto é apenas para fins educacionais e os dados gerados são fictícios. Não utilize os dados gerados para fins que envolvam informações pessoais reais.

---

**Links úteis:**
- [Documentação do .NET](https://docs.microsoft.com/pt-br/dotnet/)
- [HtmlAgilityPack](https://html-agility-pack.net/)
- [RestSharp](https://restsharp.dev/)

---

**Desenvolvedor:** Roger Ferreira - [fsRoger](https://github.com/fsRoger)

---

**Clone o projeto no GitHub:** [Link para o repositório](https://github.com/fsRoger/GeradorDeDados)

---

**Portfólio:** [Link para o portfólio](https://portifoliorfs.vercel.app/)

Espero que este guia seja útil para iniciar e testar a aplicação. Se tiver alguma dúvida ou sugestão, sinta-se à vontade para contribuir ou entrar em contato!

