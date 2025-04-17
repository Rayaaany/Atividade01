using Atividade01.Interfaces;
using Atividade01.Models;
using Atividade01.DAO;

namespace Atividade01.Services
{
    public class ClienteService : IClienteService
    {
        private ClienteDAO _clienteDAO;

        public ClienteService(string connectionString)
        {
            _clienteDAO = new ClienteDAO(connectionString);
        }

        public void AdicionarCliente(string Nome, string Email)
        {
            _clienteDAO.incluir(Nome, Email);
        }

        public List<Cliente> ListarClientes()
        {
            return _clienteDAO.ListarTodos();
        }

        public Cliente BuscarCliente(int Id)
        {
            return _clienteDAO.BuscarPorId(Id);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            _clienteDAO.Atualizar(cliente);
        }

        public void RemoverCliente(int Id)
        {
            _clienteDAO.Deletar(Id);
        }
    }
}

