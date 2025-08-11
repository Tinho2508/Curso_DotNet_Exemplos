using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {

            Alunos.Add(aluno);
        }

        public int ObterNumerosdeAlunosMatriculados()
        {
            int quantidade = Alunos.Count; // Conta o número de alunos matriculados
            return quantidade; // Retorna a quantidade de alunos
        }

        public bool RemoverAluno(Pessoa aluno) // Método para remover um aluno
        {
            return Alunos.Remove(aluno); // Remove o aluno da lista e retorna o resultado
        }

        public void ListarAlunos() // Método para listar os alunos
    
        {
            Console.WriteLine($"Alunos matriculados no curso {Nome}:"); // Exibe a lista de alunos matriculados

            for (int Count = 0; Count < Alunos.Count; Count++) // Itera sobre cada aluno na lista
            {
                // string texto = "Nº " + Count + " - " + Alunos[Count].NomeCompleto; // Formata o texto com o número e o nome completo do aluno
                int exibicao = Count + 1; // Exibe o número do aluno + um, soma 0 +1 e da o resultado
                string texto = $"Nº {exibicao} - {Alunos[Count].NomeCompleto}"; // Usa interpolação de strings para formatar o texto
                Console.WriteLine(texto); // Exibe o texto formatado
            }
        }
    }
}