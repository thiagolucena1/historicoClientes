using Pessoas.Models;
using classes.models;


Pessoa p = new Pessoa();

p.FirstName = "Thiago";
p.LastName = "Lucena";

Pessoa p2 = new Pessoa();
p2.FirstName = "Lucas";
p2.LastName = "Lima";

GerenciadorCliente clientes2025 = new GerenciadorCliente();
clientes2025.nome = "Ano 2025";
clientes2025.clientes = new List<Pessoa>(); // Instacimos a lista e clientes pelo construturo pessoa 

clientes2025.adicionarCliente(p);
clientes2025.adicionarCliente(p2);
clientes2025.listarCliente();
clientes2025.removerCliente(p);
clientes2025.listarCliente();