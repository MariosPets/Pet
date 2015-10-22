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
    class CrudPessoa
    {
        public void inserirPessoa(Pessoa pessoa)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into PESSOA (NOME, CPF, RG, NASCIMENTO, ID_ENDERECO, EMAIL, TELEFONE1, TELEFONE2, TELEFONE3) values(?,?,?,?,?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@NOME", pessoa.nome);
                command.Parameters.AddWithValue("@CPF", pessoa.cpf);
                command.Parameters.AddWithValue("@RG", pessoa.rg);
                command.Parameters.AddWithValue("@NASCIMENTO", pessoa.nascimento);
                command.Parameters.AddWithValue("@ID_ENDERECO", pessoa.idEndereco);
                command.Parameters.AddWithValue("@EMAIL", pessoa.email);
                command.Parameters.AddWithValue("@TELEFONE1", pessoa.telefone1);
                command.Parameters.AddWithValue("@TELEFONE2", pessoa.telefone2);
                command.Parameters.AddWithValue("@TELEFONE3", pessoa.telefone3);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaPessoa(string sql)
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

        public void alteraPessoa(Pessoa pessoa)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update PESSOA set NOME = ?, CPF = ?, RG = ?, NASCIMENTO = ?, ID_ENDERECO=?, EMAIL=?, TELEFONE1=?, TELEFONE2=?, TELEFONE3=? where ID_PESSOA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@NOME", pessoa.nome);
                command.Parameters.AddWithValue("@CPF", pessoa.cpf);
                command.Parameters.AddWithValue("@RG", pessoa.rg);
                command.Parameters.AddWithValue("@NASCIMENTO", pessoa.nascimento);
                command.Parameters.AddWithValue("@ID_ENDERECO", pessoa.idEndereco);
                command.Parameters.AddWithValue("@EMAIL", pessoa.email);
                command.Parameters.AddWithValue("@TELEFONE1", pessoa.telefone1);
                command.Parameters.AddWithValue("@TELEFONE2", pessoa.telefone2);
                command.Parameters.AddWithValue("@TELEFONE3", pessoa.telefone3);
                command.Parameters.AddWithValue("@ID_PESSOA", pessoa.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiPessoa(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete PESSOA where ID_PESSOA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
