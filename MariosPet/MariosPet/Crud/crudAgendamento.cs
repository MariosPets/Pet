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
    class CrudAgendamento
    {

        public void inserirAgendamento(Agendamento agendamento)
        {
            /**/
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into AGENDAMENTO (ID_AGENDAMENTO, ID_CLIENTE, ID_FUNCIONARIO, ID_SERVICO, HORA, ATENDIDO) values(?,?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_AGENDAMENTO", agendamento.id);
                command.Parameters.AddWithValue("@ID_CLIENTE", agendamento.idCliente);                
                command.Parameters.AddWithValue("@ID_FUNCIONARIO", agendamento.idFuncionario);
                command.Parameters.AddWithValue("@ID_SERVICO", agendamento.idServico);
                command.Parameters.AddWithValue("@HORA", agendamento.hora);
                command.Parameters.AddWithValue("@ATENDIDO", agendamento.atendido);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaAgendamento(string sql)
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

        public void alteraAgendamento(Agendamento agendamento)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update AGENDAMENTO set ID_CLIENTE = ?, ID_FUNCIONARIO = ?, ID_SERVICO = ?, HORA = ?, ATENDIDO = ? where ID_AGENDAMENTO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_CLIENTE", agendamento.idCliente);                
                command.Parameters.AddWithValue("@ID_FUNCIONARIO", agendamento.idFuncionario);
                command.Parameters.AddWithValue("@ID_SERVICO", agendamento.idServico);
                command.Parameters.AddWithValue("@HORA", agendamento.hora);
                command.Parameters.AddWithValue("@ATENDIDO", agendamento.atendido);
                command.Parameters.AddWithValue("@ID_AGENDAMENTO", agendamento.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiAgendamento(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete AGENDAMENTO where ID_AGENDAMENTO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_AGENDAMENTO", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
