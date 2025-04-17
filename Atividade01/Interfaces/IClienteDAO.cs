using Atividade01.Models;

namespace Atividade01.Interfaces
{
    internal interface IClienteDAO
    {
        public void incluir(string Nome, string Email);
        public List<Cliente> ListarTodos ();
        public Cliente BuscarPorId(int Id);
        public void Atualizar(Cliente Cliente);
        public void Deletar(int Id);
    }
}
