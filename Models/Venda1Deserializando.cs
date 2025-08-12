using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace ExemploExplorando.Models
{
    public class Venda1Deserializando
    {
        public int Id { get; set; } // Propriedade para armazenar o ID da venda
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; } // Propriedade para armazenar o nome do produto
        public decimal Preco { get; set; } // Propriedade para armazenar o preço do produto
        public DateTime DataVenda { get; set; } // Propriedade para armazenar a data da venda
    }
}