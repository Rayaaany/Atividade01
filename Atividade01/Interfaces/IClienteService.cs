namespace Atividade01.Interfaces
{
    public interface IClienteService
    {
        void AdicionarCliente(string nome, string email);  // Adiciona um novo cliente
        List<Cliente> ListarClientes();  // Lista todos os clientes
        Cliente BuscarCliente(int id);  // Busca um cliente por ID
        void AtualizarCliente(Cliente cliente);  // Atualiza um cliente
        void RemoverCliente(int id);  // Remove um cliente
    }
}