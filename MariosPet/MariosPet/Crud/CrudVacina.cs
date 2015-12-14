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
    class CrudVacina
    {
        public void inserirVacina(Vacina vacina)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "insert into VACINA (ID_VACINA, ID_ANIMAL, ID_MEDICAMENTO, DATA) values(?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_VACINA", vacina.idVacina);             
                command.Parameters.AddWithValue("@ID_ANIMAL", vacina.idAnimal);
                command.Parameters.AddWithValue("@ID_MEDICAMENTO", vacina.idMedicamento);
                command.Parameters.AddWithValue("@DATA", vacina.data);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaVacina(string sql)
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

        public void alteraVacina(Vacina vacina)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update VACINA set ID_ANIMAL = ?, ID_MEDICAMENTO = ?, DATA = ?, where ID_VACINA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);
               
                command.Parameters.AddWithValue("@ID_ANIMAL", vacina.idAnimal);
                command.Parameters.AddWithValue("@ID_MEDICAMENTO", vacina.idMedicamento);
                command.Parameters.AddWithValue("@DATA", vacina.data);
                command.Parameters.AddWithValue("@ID_VACINA", vacina.idVacina);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiVacina(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete VACINA where ID_VACINA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_VACINA", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
