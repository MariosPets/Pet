using MariosPet.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Crud
{
    class CrudCliente : CrudPessoa
    {
        public void inserirCliente(Cliente cliente)
        {
            inserirPessoa(cliente);
            cliente.id = Convert.ToInt32(consultaPessoa("select top 1 ID_PESSOA from PESSOA order by ID_PESSOA desc").Rows[0][0].ToString());

            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "insert into CLIENTE (ID_PESSOA) values(?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA", cliente.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaCliente(string sql)
        {
            DataTable tabela = new DataTable();
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                conexao.Open();
                OdbcDataAdapter data = new OdbcDataAdapter(sql, conexao);
                OdbcCommand command = new OdbcCommand(sql, conexao);
                data.Fill(tabela);
                return tabela;
            }
        }

        public void alteraCliente(Cliente cliente)
        {
            alteraPessoa(cliente);

            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

            }
        }

        public void excluiCliente(int codigo)
        {
            excluiPessoa(codigo);

            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

            }
        }
    }
}
