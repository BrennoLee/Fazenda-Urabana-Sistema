namespace FazendoUrbanaCRUD.BackEnd
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        // Construtor
        public Funcionario(int id, string nome, string cargo, decimal salario)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        // Construtor adicional sem parâmetros (necessário para manipulação em métodos de CRUD)
        public Funcionario() { }
    }
}
