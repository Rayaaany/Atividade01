using Atividade01.Models; 
namespace Atividade01.Interfaces
{
    public interface IClienteService
    {
        void AdicionarCliente(string Nome, string Email);// Adiciona um novo cliente

        List<Cliente> ListarClientes();  // Lista todos os clientes
        void AtualizarCliente(Cliente cliente);  // Atualiza um cliente
        void RemoverCliente(int Id);  
            Cliente // Remove um cliente
    }
}