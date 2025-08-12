using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ExemploExcecao
    {
        public void Metodo1() // Método que chama outro método que lança uma exceção
        {
            Metodo2(); // Chama o método que pode lançar uma exceção
        }

        public void Metodo2() // Método que chama outro método que pode lançar uma exceção
        {
            Metodo3(); // Chama o método que pode lançar uma exceção
        }
        public void Metodo3() // Método que chama outro método que pode lançar uma exceção
        {
            try // Bloco de tentativa
            {
                Metodo4(); // Chama o método que lança a exceção
            }
            catch (Exception ex) // Exceção genérica
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}"); // Exibe mensagem de erro
            }
            finally // Bloco de finalização
            {
                Console.WriteLine("Execução finalizada. ou Chegou até aqui"); // Mensagem de finalização
            }
            
        }
        public void Metodo4() // Método que lança uma exceção
        {
          throw new Exception("Ocorreu uma Exceção"); // Lança uma exceção personalizada
        }
    }
}