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
    class CrudFuncionario: CrudPessoa
    {
        public void inserirFuncionario(Funcionario funcionario)
        {
            inserirPessoa(funcionario);
            funcionario.id = Convert.ToInt32(consultaPessoa("select top 1 ID_PESSOA from PESSOA order by ID_PESSOA desc").Rows[0][0].ToString());

            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into FUNCIONARIO (ID_PESSOA, TIPO_FUNCIONARIO, APELIDO, SENHA) values(?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA", funcionario.id);
                command.Parameters.AddWithValue("@TIPO_FUNCIONARIO", funcionario.tipo);
                command.Parameters.AddWithValue("@APELIDO", funcionario.apelido);
                command.Parameters.AddWithValue("@SENHA", funcionario.senha);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaFuncionario(string sql)
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

        public void alteraFuncionario(Funcionario funcionario)
        {
            alteraPessoa(funcionario);

            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update FUNCIONARIO set TIPO = ?, APELIDO = ?, SENHA = ? where ID_PESSOA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                
                command.Parameters.AddWithValue("@TIPO_FUNCIONARIO", funcionario.tipo);
                command.Parameters.AddWithValue("@APELIDO", funcionario.apelido);
                command.Parameters.AddWithValue("@SENHA", funcionario.senha);
                command.Parameters.AddWithValue("@ID_PESSOA", funcionario.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiFuncionario(int codigo)
        {
            excluiPessoa(codigo);
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete FUNCIONARIO where ID_PESSOA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
