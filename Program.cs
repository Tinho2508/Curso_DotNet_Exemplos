 using ExemploExplorando.Models;
using System.Collections;
using System.Globalization;
using Newtonsoft.Json;


string conteudoArquivo = File.ReadAllText("Arquivos/venda.json"); // Lê o conteúdo do arquivo JSON

List<Venda1Deserializando> vendas = JsonConvert.DeserializeObject<List<Venda1Deserializando>>(conteudoArquivo); // Deserializa o JSON em uma lista de objetos Venda

foreach (var venda in vendas) // Itera sobre cada venda na lista
{
    Console.WriteLine($"ID: {venda.Id}"); // Exibe o ID da venda
    Console.WriteLine($"Produto: {venda.Produto}"); // Exibe o nome do produto
    Console.WriteLine($"Preço: {venda.Preco.ToString("C", CultureInfo.CurrentCulture)}"); // Exibe o preço formatado como moeda
    Console.WriteLine($"Data da Venda: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}"); // Exibe a data da venda formatada
    Console.WriteLine("-------------------------"); // Exibe uma linha separadora
}



















// DateTime dataAtual = DateTime.Now; // Obtém a data e hora atual

// List<Venda> listavendas = new List<Venda>(); // Cria uma lista de objetos Venda

// Venda v1 = new Venda(1, "Material de Escritorio", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Material de Limpeza", 15.00M, dataAtual);
// Venda v3 = new Venda(3, "Material de Informatica", 199.00M, dataAtual);

// listavendas.Add(v1);
// listavendas.Add(v2);
// listavendas.Add(v3);

// string serializado = JsonConvert.SerializeObject(listavendas, Formatting.Indented); // Serializa a lista de objetos Venda para JSON

// File.WriteAllText("Arquivos/venda.json", serializado); // Salva o JSON em um arquivo

// Console.WriteLine(serializado); // Exibe o JSON serializado























// // IF TERNÁRIO

// int numero = 10; // Exemplo de número para verificar se é par ou ímpar
// bool ehpar = false; // Variável para armazenar se o número é par ou ímpar

// ehpar = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é {(ehpar ? "par" : "ímpar")}."); // Exibe se o número é par ou ímpar

// int numero = 15; // Exemplo de número para verificar se é par ou ímpar

// if (numero % 2 == 0) // Verifica se o número é par
// {
//     Console.WriteLine($"O número {numero} é par."); // Exibe que o número é par
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar."); // Exibe que o número é ímpar
// }



















// Pessoa P1 = new Pessoa("Ailton", "Silva", 30);

// (string nome, string sobrenome, int idade) = P1; // Desestruturação da instância de Pessoa



// Console.WriteLine($"Nome: {nome}");
// Console.WriteLine($"Sobrenome: {sobrenome}");
// Console.WriteLine($"Idade: {idade}");

// Console.WriteLine("-----------");

// Console.WriteLine($"{nome} {sobrenome} tem {idade} anos.");










// LeituraArquivo arquivo = new LeituraArquivo(); // Cria uma instância da classe LeituraArquivo

// var  (sucesso, linhasArquivo, quantidadeLinhas) =arquivo.LerArquivo("Arquivos/arquivoTexto.txt"); // Lê o arquivo de texto e exibe o conteúdo

// if (sucesso)
// {
//     Console.WriteLine($"Quantidade de linhas lidas: {quantidadeLinhas}");
//     foreach (var linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Erro ao ler o arquivo.");
// }





















// (int, string, string, decimal) tupla = (1, "Ailtom", "Silva", 1.70m); // Cria uma tupla com quatro elementos

// //ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Ailtom", "Silva", 1.70m);// Cria uma segunda tupla com quatro elementos

// //var outroExemploTuplaCreate = Tuple.Create(1, "Ailtom", "Silva", 1.70m); // Cria uma tupla usando o método Create

// Console.WriteLine($"Id:({tupla.Item1})");
// Console.WriteLine($"Nome:({tupla.Item2})");
// Console.WriteLine($"Sobrenome:({tupla.Item3})");
// Console.WriteLine($"Altura:({tupla.Item4})");









// Dictionary<string, string> estados = new Dictionary<string, string>(); // Cria um dicionário de strings

// estados.Add("SP", "São Paulo");
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("MG", "Minas Gerais");
// estados.Add("RS", "Rio Grande do Sul");

// Console.WriteLine(estados["SP"]); // São Paulo

// foreach (var estado in estados) // Itera sobre cada estado no dicionário
// {
//     Console.WriteLine($"Sigla: {estado.Key}, Estado: {estado.Value}"); // 
// }

// Console.WriteLine("------------------"); // Linha separadora

// estados.Remove("RS"); // Remove o estado "Rio Grande do Sul"

// foreach (var estado in estados) // Itera sobre cada estado no dicionário
// {
//     Console.WriteLine($"Sigla: {estado.Key}, Estado: {estado.Value}"); // 
// }

// string sigla = "SP"; // Sigla do estado a ser verificado

// Console.WriteLine($" Verificando o elemento: {sigla}"); // Verifica se a sigla existe no dicionário

// if (estados.ContainsKey(sigla)) // Verifica se a sigla existe no dicionário
// {
//     Console.WriteLine($"Estado encontrado: {estados[sigla]}"); // Exibe o estado correspondente à sigla
// }
// else // Se a sigla não existir no dicionário
// {
//     Console.WriteLine("Estado não encontrado."); // Mensagem de estado não encontrado
// }






// Stack<int> pilha = new Stack<int>(); // Cria uma pilha de inteiros

// pilha.Push(1); // Adiciona o elemento 1 à pilha
// pilha.Push(3); // Adiciona o elemento 3 à pilha
// pilha.Push(5); // Adiciona o elemento 5 à pilha
// pilha.Push(7); // Adiciona o elemento 7 à pilha

// foreach (int item in pilha) // Itera sobre cada item na pilha
// {
//     Console.WriteLine(item); // Exibe o item atual da pilha
// }
// //pilha.Pop(); // Remove o elemento do topo da pilha (7)

// Console.WriteLine($"Removendo o elemento do topo da pilha: {pilha.Pop()}"); // Exibe o elemento removido







// Queue<int> fila = new Queue<int>(); // Cria uma fila de inteiros

// fila.Enqueue(2); // Adiciona o elemento 2 à fila
// fila.Enqueue(4); // Adiciona o elemento 4 à fila
// fila.Enqueue(6); // Adiciona o elemento 6 à fila
// fila.Enqueue(8); // Adiciona o elemento 8 à fila

// foreach (int item in fila) // Itera sobre cada item na fila
// {
//     Console.WriteLine(item); // Exibe o item atual da fila
// }

// //fila.Dequeue(); // Remove o primeiro elemento da fila (2)

// Console.WriteLine($"Removendo o elemento da fila:{fila.Dequeue()}"); // Exibe o elemento removido

// foreach (int item in fila) // Itera sobre cada item na fila
// {
//     Console.WriteLine(item); // Exibe o item atual da fila
// }













//new ExemploExcecao().Metodo1(); // Chama o método que lança a exceção








// try // Bloco de tentativa
// {


//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_Texto.txt"); // Lê todas as linhas do arquivo de texto

//     foreach (string linha in linhas) // Itera sobre cada linha do arquivo
//     {
//         Console.WriteLine(linha); // Exibe o conteúdo da linha
//     }



// }
// catch (FileNotFoundException ex) // Exceção para arquivo não encontrado
// {
//     Console.WriteLine($"Arquivo não encontrado: {ex.Message}"); // Exibe mensagem de erro
// }
// catch (DirectoryNotFoundException ex) // Exceção para diretório não encontrado
// {
//     Console.WriteLine($"Pasta não encontrada: {ex.Message}"); // Exibe mensagem de erro
// }

// catch (Exception ex) // Exceção genérica
// {
//     Console.WriteLine($"Ocorreu um erro: {ex.Message}"); // Exibe mensagem de erro
// }
// finally // Bloco de finalização
// {
//     Console.WriteLine("Execução finalizada. ou Chegou até aqui"); // Mensagem de finalização
// }
















// string dataString = "2025-04-17 19:01";

// bool sucesso =DateTime.TryParseExact(dataString,"yyyy-MM-dd HH:mm",CultureInfo.InvariantCulture,DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com Sucesso! Data: {data}");

// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida.");
// }

//Console.WriteLine(data); // Exibe a data formatada corretamente








// DateTime data = DateTime.Now;

// Console.WriteLine(data);









// using System.Globalization; // Adicionando suporte a formatação de cultura
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); // Definindo a cultura padrão
// decimal ValorMontario = 82.40m;

// //Console.WriteLine($" {ValorMontario:C}"); // Exibe o valor formatado como moeda

// Console.WriteLine($" {ValorMontario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}"); // Exibe o valor formatado como moeda na cultura atual especificada pelo ususario


// double porcentagem = .3421;

// Console.WriteLine($" {porcentagem:P}"); // Exibe a porcentagem formatada
// Console.WriteLine($" {porcentagem.ToString("P")}"); // Exibe a porcentagem formatada na cultura atual especificada pelo ususario











// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2; // Concatenação de strings

// Console.WriteLine(resultado);

























// Pessoa p1 = new Pessoa(nome:"Jose Ailtom", sobrenome:"Silva", idade:42);

// Pessoa p2 = new Pessoa(nome:"Maria Clara", sobrenome:"Oliveira", idade:25);





// Curso curso = new Curso();
// curso.Nome = "Curso de Programação";
// curso.Alunos = new List<Pessoa>();

// curso.AdicionarAluno(p1);
// curso.AdicionarAluno(p2);
// curso.ListarAlunos();