using Atividade01.Interfaces;
using Atividade01.Models;
using Microsoft.Data.SqlClient;

namespace Atividade01.DAO
{
    internal class ClienteDAO : IClienteDAO
    {
        private string _connectionString;

        public ClienteDAO(string connectionString)
        {
            _connectionString = connectionString;

        }

        public void Atualizar(Cliente Cliente)
        {
           using(SqlConnection con = new SqlConnection (_connectionString))
            {
                string query = "UPDATE Clientes SET Nome = @Nome, Email = @EMAIL WHERE id = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nome", Cliente.Nome);
                cmd.Parameters.AddWithValue("@Email", Cliente.Email);
                cmd.Parameters.AddWithValue("@Id", Cliente.Id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public Cliente BuscarPorId(int Id)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Cliente WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand (query, con);
                cmd.Parameters.AddWithValue ("@Id", Id);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Cliente() 
                    { 
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Email = reader.GetString(2),
                    };
                }
                else
                {
                    return null;
                }
            }
        }
        public void Deletar(int Id)
        {
            throw new NotImplementedException();
        }

        public void incluir(string Nome, string Email)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
