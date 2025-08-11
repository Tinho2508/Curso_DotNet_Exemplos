 using ExemploExplorando.Models;
using System.Globalization;


string dataString = "2025-04-17 19:01";

bool sucesso =DateTime.TryParseExact(dataString,"yyyy-MM-dd HH:mm",CultureInfo.InvariantCulture,DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com Sucesso! Data: {data}");

}
else
{
    Console.WriteLine($"{dataString} não é uma data válida.");
}

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