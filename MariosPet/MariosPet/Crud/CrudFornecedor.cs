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
    class CrudFornecedor: CrudPessoaJuridica
    {
        public void inserirFornecedor(Fornecedor fornecedor)
        {
            inserirPessoaJuridica(fornecedor);
            fornecedor.id = Convert.ToInt32(consultaPessoaJuridica("select top 1 ID_PESSOA_JURIDICA from PESSOA_JURIDICA order by ID_PESSOA_JURIDICA desc").Rows[0][0].ToString());

            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into FORNECEDOR (ID_PESSOA_JURIDICA, RAMO_ATIVIDADE, NOME_CONTATO) values(?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA_JURIDICA", fornecedor.id);
                command.Parameters.AddWithValue("@RAMO_ATIVIDADE", fornecedor.ramoAtividade);
                command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.nomeContato);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaFornecedor(string sql)
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

        public void alteraFornecedor(Fornecedor fornecedor)
        {
            alteraPessoaJuridica(fornecedor);
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update FORNECEDOR set RAMO_ATIVIDADE = ?, NOME_CONTATO = ? where ID_PESSOA_JURIDICA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@RAMO_ATIVIDADE", fornecedor.ramoAtividade);
                command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.nomeContato);
                command.Parameters.AddWithValue("@ID_PESSOA_JURIDICA", fornecedor.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiFornecedor(int codigo)
        {
            excluiPessoaJuridica(codigo);
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete FORNECEDOR where ID_PESSOA_JURIDICA = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PESSOA_JURIDICA", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
