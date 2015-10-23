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
    class CrudServico
    {
        public void inserirServico(Servico servico)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "insert into SERVICO (ID_SERVICO, DESCRICAO, PRECO) values(?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);
                                
                command.Parameters.AddWithValue("@DESCRICAO", servico.descricao);
                command.Parameters.AddWithValue("@PRECO", servico.preco);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaServico(string sql)
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

        public void alteraServico(Servico servico)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update SERVICO set DESCRICAO = ?, PRECO = ? where ID_SERVICO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@DESCRICAO", servico.descricao);
                command.Parameters.AddWithValue("@PRECO", servico.preco);
                command.Parameters.AddWithValue("@ID_SERVICO", servico.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiServico(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete SERVICO where ID_SERVICO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_SERVICO", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
