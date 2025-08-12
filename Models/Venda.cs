using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Venda

    {
        public Venda(int id, string produto, decimal valor, DateTime dataVenda)
        {
            Id = id; // Inicializa o ID da venda
            Produto = produto; // Inicializa o nome do produto vendido
            Valor = valor; // Inicializa o valor da venda
            DataVenda = dataVenda; // Inicializa a data da venda
        }

        public int Id { get; set; } // Propriedade para armazenar o ID da venda
        public string Produto { get; set; } // Propriedade para armazenar o nome do produto vendido
        public decimal Valor { get; set; } // Propriedade para armazenar o valor da venda
        public DateTime DataVenda { get; set; } // Propriedade para armazenar a data da venda
    }

}

// ISO 8601  REPRESENTA O FORMATO PADRÃO INTERNACIONAL PARA DATA E HORA