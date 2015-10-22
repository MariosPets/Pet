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
    class CrudPessoaJuridica
    {
        public void inserirPessoaJuridica(PessoaJuridica pessoajuridica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into PESSOA_JURIDICA (RAZAO_SOCIAL, CNPJ, ID_ENDERECO, EMAIL1, EMAIL2, TELEFONE1, TELEFONE2) values(?,?,?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@RAZAO",pessoajuridica.razaoSocial);
                command.Parameters.AddWithValue("@CNPJ", pessoajuridica.cnpj);
                command.Parameters.AddWithValue("@ID_ENDERECO", pessoajuridica.idEndereco);
                command.Parameters.AddWithValue("@EMAIL1", pessoajuridica.email1);
                command.Parameters.AddWithValue("@EMAIL2", pessoajuridica.email2);
                command.Parameters.AddWithValue("@TELEFONE1", pessoajuridica.telefone1);
                command.Parameters.AddWithValue("@TELEFONE2", pessoajuridica.telefone2);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaPessoaJuridica(string sql)
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

        public void alteraPessoaJuridica(PessoaJuridica pessoajuridica)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update PESSOA_JURIDICA set RAZAO_SOCIAL = ?, CNPJ = ?, ID_ENDERECO = ?, EMAIL1 = ?, EMAIL2 = ?, TELEFONE1 = ?, TELEFONE2 = ? where ID_PESSOA_JURIDICA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                
                command.Parameters.AddWithValue("@RAZAO_SOCIAL", pessoajuridica.razaoSocial);
                command.Parameters.AddWithValue("@CNPJ", pessoajuridica.cnpj);
                command.Parameters.AddWithValue("@ID_ENDERECO", pessoajuridica.idEndereco);
                command.Parameters.AddWithValue("@EMAIL1", pessoajuridica.email1);
                command.Parameters.AddWithValue("@EMAIL2", pessoajuridica.email2);
                command.Parameters.AddWithValue("@TELEFONE1", pessoajuridica.telefone1);
                command.Parameters.AddWithValue("@TELEFONE2", pessoajuridica.telefone2);
                command.Parameters.AddWithValue("@ID_PESSOA_JURIDICA", pessoajuridica.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiPessoaJuridica(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete PESSOA_JURIDICA where ID_PESSOA_JURIDICA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA_JURIDICA", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
