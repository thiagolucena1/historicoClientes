namespace classes.models;

using Pessoas.Models;

public class GerenciadorCliente
{
    public string nome { get; set; }
    public List<Pessoa> clientes { get; set; } // Instacimos a lista e clientes pelo construtor da classe pessoa 

    public void adicionarCliente(Pessoa client)
    {
        clientes.Add(client);
    }

    int quantidadeClientes()
    {

        int quantidade = clientes.Count;
        return quantidade;
    }

    public void removerCliente(Pessoa client)
    {
        clientes.Remove(client);
    }

    public void listarCliente()
    {
        foreach (Pessoa client in clientes)
        {
            Console.WriteLine($"Nome: {client.GetFullName()}");
        }
    }
}