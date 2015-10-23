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
    class CrudMedicamento
    {
        public void inserirMedicamento(Medicamento medicamento)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "insert into MEDICAMENTO (DESCRICAO, QUANTIDADE, MINIMO_EM_ESTOQUE, MAXIMO_EM_ESTOQUE) values(?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@DESCRICAO", medicamento.descricao);            
                command.Parameters.AddWithValue("@QUANTIDADE", medicamento.quantidade); 
                command.Parameters.AddWithValue("@MINIMO_EM_ESTOQUE", medicamento.minimoEmEstoque); 
                command.Parameters.AddWithValue("@MAXIMO_EM_ESTOQUE", medicamento.maximoEmEstoque); 

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaMedicamento(string sql)
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

        public void alteraMedicamento(Medicamento medicamento)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update MEDICAMENTO set DESCRICAO = ?, QUANTIDADE = ?, MINIMO_EM_ESTOQUE = ?, MAXIMO_EM_ESTOQUE = ? where ID_MEDICAMENTO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@DESCRICAO", medicamento.descricao);
                command.Parameters.AddWithValue("@QUANTIDADE", medicamento.quantidade);
                command.Parameters.AddWithValue("@MINIMO_EM_ESTOQUE", medicamento.minimoEmEstoque);
                command.Parameters.AddWithValue("@MAXIMO_EM_ESTOQUE", medicamento.maximoEmEstoque);
                command.Parameters.AddWithValue("@ID_MEDICAMENTO", medicamento.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiMedicamento(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete MEDICAMENTO where ID_MEDICAMENTO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_MEDICAMENTO", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
