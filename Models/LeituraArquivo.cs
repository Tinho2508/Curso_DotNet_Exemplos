using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        public (bool sucesso, string[] Linhas, int QuantidadesLinhas) LerArquivo(string caminho)
        {
            try {

                string[] linhas = File.ReadAllLines(caminho); // Lê todas as linhas do arquivo de texto

                return (true, linhas, linhas.Count());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                return (false, new string[0], 0);
            }
        }
    }
}