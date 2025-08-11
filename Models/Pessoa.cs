using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa() // Construtor padrão
        {
          
        }
        public Pessoa(string nome, string sobrenome, int idade) // Construtor com parâmetros
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        private string _Nome; // Campo privado para armazenar o nome
        private int _Idade; // Campo privado para armazenar a idade
        public string Nome // Propriedade pública para acessar o nome
        {
            get  // ou seria mais elegante usar o comando get => _Nome.ToUpper();
            {
                return _Nome.ToUpper(); // Retorna o nome em letras maiúsculas

            }


            set
            {
                if (value == "") // Verifica se o nome está vazio
                {
                    throw new ArgumentException("O nome não pode ser vazio"); // Lança uma exceção se o nome for vazio
                }


                _Nome = value; // Atribui o valor à variável privada

            }
        }
        public string Sobrenome { get; set; } // Propriedade automática para o sobrenome
        public string NomeCompleto // Propriedade somente leitura para o nome completo
        {
            get => $"{Nome} {Sobrenome}".ToUpper(); // Retorna o nome completo em letras maiúsculas
        }
        public int Idade // Propriedade pública para acessar a idade
        {
            get => _Idade; // Retorna a idade

            set
            {
                if (value < 0) // Verifica se a idade é negativa
                {
                    throw new ArgumentException("A idade não pode ser menor que Zero"); // Lança uma exceção se a idade for negativa
                }

                _Idade = value; // Atribui o valor à variável privada
            }

        } 

        public void Apresentar() // Método para apresentar a pessoa
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos."); // Apresenta o nome e a idade
        }
    }
}