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
    class CrudEndereco
    {
        public void inserirEndereco(Endereco endereco)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into ENDERECO (RUA, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, UF, CEP) values(?,?,?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@RUA", endereco.rua);
                command.Parameters.AddWithValue("@NUMERO", endereco.numero);
                command.Parameters.AddWithValue("@COMPLEMENTO", endereco.complemento);
                command.Parameters.AddWithValue("@BAIRRO", endereco.bairro);
                command.Parameters.AddWithValue("@CIDADE", endereco.cidade);
                command.Parameters.AddWithValue("@UF", endereco.uf);
                command.Parameters.AddWithValue("@CEP", endereco.cep);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaEndereco(string sql)
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

        public void alteraEndereco(Endereco endereco)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update ENDERECO set RUA = ?, NUMERO = ?, COMPLEMENTO = ?, BAIRRO = ?, CIDADE = ?, UF = ?, CEP = ? where ID_ENDERECO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@RUA", endereco.rua);
                command.Parameters.AddWithValue("@NUMERO", endereco.numero);
                command.Parameters.AddWithValue("@COMPLEMENTO", endereco.complemento);
                command.Parameters.AddWithValue("@BAIRRO", endereco.bairro);
                command.Parameters.AddWithValue("@CIDADE", endereco.cidade);
                command.Parameters.AddWithValue("@UF", endereco.uf);
                command.Parameters.AddWithValue("@CEP", endereco.cep);
                command.Parameters.AddWithValue("@ID_ENDERECO", endereco.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiEndereco(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete ENDERECO where ID_ENDERECO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ENDERECO", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
