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
    class CrudVermifugo
    {
        public void inserirVermifugo(Vermifugo vermifugo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "insert into VERMIFUGO (ID_VERMIFUGO, ID_FICHA_CLINICA, ID_MEDICAMENTO, DATA_INICIO, DATA_FIM) values(?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_VERMIFUGO", vermifugo.idVermifugo);
                command.Parameters.AddWithValue("@ID_FICHA_CLINICA", vermifugo.idFichaClinica);
                command.Parameters.AddWithValue("@ID_MEDICAMENTO", vermifugo.idMedicamento);
                command.Parameters.AddWithValue("@DATA_INICIO", vermifugo.dataInicio);
                command.Parameters.AddWithValue("@DATA_FIM", vermifugo.dataFim);
                
                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaVermifugo(string sql)
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

        public void alteraVermifugo(Vermifugo vermifugo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update VERMIFUGO set ID_FICHA_CLINICA = ?, ID_MEDICAMENTO = ?, DATA_INICIO = ?, DATA_FIM = ? where ID_VERMIFUGO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_FICHA_CLINICA", vermifugo.idFichaClinica);
                command.Parameters.AddWithValue("@ID_MEDICAMENTO", vermifugo.idMedicamento);
                command.Parameters.AddWithValue("@DATA_INICIO", vermifugo.dataInicio);
                command.Parameters.AddWithValue("@DATA_FIM", vermifugo.dataFim);
                command.Parameters.AddWithValue("@ID_VERMIFUGO", vermifugo.idVermifugo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiVermifugo(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete VERMIFUGO where ID_VERMIFUGO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_VERMIFUGO", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
