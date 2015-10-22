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
    class CrudVeterinario: CrudFuncionario
    {
        public void inserirVeterinario(Veterinario veterinario)
        {
            inserirFuncionario(veterinario);
            veterinario.id = Convert.ToInt32(consultaPessoa("select top 1 ID_PESSOA from PESSOA order by ID_PESSOA desc").Rows[0][0].ToString());
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into VETERINARIO (ID_FUNCIONARIO, CRMV_VETERINARIO) values(?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_FUNCIONARIO", veterinario.id);
                command.Parameters.AddWithValue("@CRMV_VETERINARIO", veterinario.crmv);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaVeterinario(string sql)
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

        public void alteraVeterinario(Veterinario veterinario)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update VETERINARIO set CRMV_VETERINARIO = ? where ID_FUNCIONARIO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@CRMV_VETERINARIO", veterinario.crmv);
                command.Parameters.AddWithValue("@ID_FUNCIONARIO", veterinario.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiVeterinario(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete VETERINARIO where ID_FUNCIONARIO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_FUNCIONARIO", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
