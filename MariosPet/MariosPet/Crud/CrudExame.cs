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
    class CrudExame
    {
        public void inserirExame(Exame exame)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {



                string sql = "insert into EXAME (ID_EXAME, ID_ANIMAL, ID_VETERINARIO, ID_LABORATORIO, DATA, EXAME) values(?,?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_EXAME", exame.id);
                command.Parameters.AddWithValue("@ID_ANIMAL", exame.idAnimal);
                command.Parameters.AddWithValue("@ID_VETERINARIO", exame.idVeterinario);
                command.Parameters.AddWithValue("@ID_LABORATORIO", exame.idLaboratorio);
                command.Parameters.AddWithValue("@DATA", exame.data);
                command.Parameters.AddWithValue("@EXAME", exame.exame);              
                
                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaExame(string sql)
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

        public void alteraExame(Exame exame)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update EXAME set ID_ANIMAL = ?, ID_VETERINARIO = ?, ID_LABORATORIO = ?, DATA = ?, EXAME = ? where ID_EXAME = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", exame.idAnimal);                     
                command.Parameters.AddWithValue("@ID_VETERINARIO", exame.idVeterinario);
                command.Parameters.AddWithValue("@ID_LABORATORIO", exame.idLaboratorio);
                command.Parameters.AddWithValue("@DATA", exame.data);
                command.Parameters.AddWithValue("@EXAME", exame.exame);
                command.Parameters.AddWithValue("@ID_EXAME", exame.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiExame(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete EXAME where ID_EXAME = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_EXAME", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
