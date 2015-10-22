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
    class CrudMedicamentoFichaClinica
    {
        public void inserirMedicamentoFichaClinica(MedicamentoFichaClinica medicamentoFichaClinica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "insert into MEDICAMENTO_FICHA_CLINICA (ID_MEDICAMENTO_FICHA_CLINICA, ID_FICHA_CLINICA, ID_MEDICAMENTO) values(?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_MEDICAMENTO_FICHA_CLINICA", medicamentoFichaClinica.id);
                command.Parameters.AddWithValue("@ID_FICHA_CLINICA", medicamentoFichaClinica.idFichaClinica);
                command.Parameters.AddWithValue("@ID_MEDICAMENTO", medicamentoFichaClinica.idMedicamento);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaMedicamentoFichaClinica(string sql)
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

        public void alteraMedicamentoFichaClinica(MedicamentoFichaClinica medicamentoFichaClinica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update MEDICAMENTO_FICHA_CLINICA set ID_FICHA_CLINICA = ?, ID_MEDICAMENTO = ? where ID_MEDICAMENTO_FICHA_CLINICA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_FICHA_CLINICA", medicamentoFichaClinica.idFichaClinica);
                command.Parameters.AddWithValue("@ID_MEDICAMENTO", medicamentoFichaClinica.idMedicamento);
                command.Parameters.AddWithValue("@ID_MEDICAMENTO_FICHA_CLINICA", medicamentoFichaClinica.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiMedicamentoFichaClinica(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete MEDICAMENTO_FICHA_CLINICA where ID_MEDICAMENTO_FICHA_CLINICA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_MEDICAMENTO_FICHA_CLINICA", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
