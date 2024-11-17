# FazendaUrbana - Sistema de Gestão de Fazenda

## Descrição
Este é um projeto acadêmico desenvolvido como parte da disciplina do 4º semestre do curso de Análise e Desenvolvimento de Sistemas. O sistema tem como objetivo gerenciar informações sobre produtos, funcionários e vendas em uma fazenda, utilizando um banco de dados SQL Server para armazenar os dados e oferecendo funcionalidades CRUD (Criar, Ler, Atualizar e Excluir) através de uma interface de usuário com formulários em Windows Forms.

## Funcionalidades
- **Gestão de Produtos:** Cadastro de produtos como legumes, frutas e grãos, com informações sobre nome, categoria, preço e quantidade em estoque.
- **Gestão de Funcionários:** Cadastro de funcionários da fazenda com nome, cargo e salário.
- **Histórico de Vendas:** Registro e consulta das vendas realizadas, associando produtos, quantidade e preço com a data da venda.
- **Filtros e Ordenação:** Possibilidade de filtrar e ordenar os registros de vendas por diferentes critérios, como data, nome do produto, quantidade e preço.

## Tecnologias Utilizadas
- **Linguagem:** C# (.NET Framework)
- **Interface de Usuário:** Windows Forms
- **Banco de Dados:** SQL Server
- **IDE:** Visual Studio
- **Autenticação:** Autenticação do Windows para conexão com o banco de dados SQL Server.

## Estrutura do Banco de Dados
O banco de dados `FazendaUrbanaDB` contém três tabelas principais:

- **Produtos:** Armazena os dados dos produtos disponíveis na fazenda, como nome, categoria, preço e quantidade.
- **Funcionarios:** Armazena os dados dos funcionários da fazenda, como nome, cargo e salário.
- **Vendas:** Armazena os registros de vendas realizadas, associando os produtos vendidos, a quantidade e o preço.

### Exemplo de Tabelas no Banco de Dados:

**Produtos**
- ProdutoID (PK)
- Nome
- Categoria
- Preço
- Quantidade

**Funcionarios**
- FuncionarioID (PK)
- Nome
- Cargo
- Salário

**Vendas**
- VendaID (PK)
- Data
- ProdutoID (FK)
- Quantidade
- Preço

## Como Executar o Projeto

### Configuração do Banco de Dados
1. Certifique-se de ter o SQL Server instalado e configurado em seu ambiente.
2. Crie o banco de dados `FazendaUrbanaDB` utilizando o script fornecido.
3. Verifique a conexão com o banco de dados no Visual Studio e ajuste a string de conexão, se necessário.

### Executar o Projeto
1. Abra o projeto no Visual Studio.
2. Compile e execute o projeto para ver a interface de usuário e interagir com o sistema.

### Usabilidade
- Utilize os formulários para cadastrar produtos, funcionários e registrar vendas.
- Use a tela de "Histórico de Vendas" para visualizar as vendas realizadas e aplicar filtros.

## Considerações
Este projeto foi desenvolvido como parte do aprendizado em C# e SQL Server, com o objetivo de entender melhor como criar sistemas integrados com banco de dados e interfaces de usuário. A implementação foi realizada com o intuito de ser simples e funcional para o gerenciamento de informações de uma fazenda.
