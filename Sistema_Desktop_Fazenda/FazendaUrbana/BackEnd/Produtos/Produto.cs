using System;

namespace FazendoUrbanaCRUD.BackEnd
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        // Construtor completo
        public Produto(int id, string nome, string categoria, decimal preco, int quantidade)
        {
            Id = id;
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Construtor simplificado
        public Produto(string nome, string categoria, decimal preco, int quantidade)
        {
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Construtor sem parâmetros (necessário para integração com banco de dados)
        public Produto() { }
    }
}
