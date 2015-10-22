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
    class CrudProduto
    {
        public void inserirProduto(Produto produto)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "insert into PRODUTO (ID_PRODUTO, DESCRICAO, SETOR, ID_FORNECEDOR, FABRICANTE, VENCIMENTO, QUANTIDADE, UNIDADE, VALOR_CUSTO, VALOR_VENDA, LUCRO, TRIBUTACAO, MINIMO_EM_ESTOQUE, MAXIMO_EM_ESTOQUE, CODIGO_BARRAS) values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PRODUTO", produto.id);
                command.Parameters.AddWithValue("@DESCRICAO", produto.descricao);
                command.Parameters.AddWithValue("@SETOR", produto.setor);
                command.Parameters.AddWithValue("@ID_FORNECEDOR", produto.idFornecedor);
                command.Parameters.AddWithValue("@FABRICANTE", produto.fabricante);
                command.Parameters.AddWithValue("@VENCIMENTO", produto.vencimento);
                command.Parameters.AddWithValue("@QUANTIDADE", produto.quantidade);
                command.Parameters.AddWithValue("@UNIDADE", produto.unidade);
                command.Parameters.AddWithValue("@VALOR_CUSTO", produto.valorCusto);
                command.Parameters.AddWithValue("@VALOR_VENDA", produto.valorVenda);
                command.Parameters.AddWithValue("@LUCRO", produto.lucro);
                command.Parameters.AddWithValue("@TRIBUTACAO", produto.tributacao);
                command.Parameters.AddWithValue("@MINIMO_EM_ESTOQUE", produto.minimoEmEstoque);
                command.Parameters.AddWithValue("@MAXIMO_EM_ESTOQUE", produto.maximoEmEstoque);
                command.Parameters.AddWithValue("@CODIGO_BARRAS", produto.codigoBarras);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaProduto(string sql)
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

        public void alteraProduto(Produto produto)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update PRODUTO set DESCRICAO = ?, SETOR = ?, ID_FORNECEDOR = ?, FABRICANTE = ?, VENCIMENTO = ?, QUANTIDADE = ?, UNIDADE = ?, VALOR_CUSTO = ?, VALOR_VENDA = ?, LUCRO = ?, TRIBUTACAO = ?, MINIMO_EM_ESTOQUE = ?, MAXIMO_EM_ESTOQUE = ?, CODIGO_BARRAS = ? where ID_PRODUTO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@DESCRICAO", produto.descricao);
                command.Parameters.AddWithValue("@SETOR", produto.setor);
                command.Parameters.AddWithValue("@ID_FORNECEDOR", produto.idFornecedor);
                command.Parameters.AddWithValue("@FABRICANTE", produto.fabricante);
                command.Parameters.AddWithValue("@VENCIMENTO", produto.vencimento);
                command.Parameters.AddWithValue("@QUANTIDADE", produto.quantidade);
                command.Parameters.AddWithValue("@UNIDADE", produto.unidade);
                command.Parameters.AddWithValue("@VALOR_CUSTO", produto.valorCusto);
                command.Parameters.AddWithValue("@VALOR_VENDA", produto.valorVenda);
                command.Parameters.AddWithValue("@LUCRO", produto.lucro);
                command.Parameters.AddWithValue("@TRIBUTACAO", produto.tributacao);
                command.Parameters.AddWithValue("@MINIMO_EM_ESTOQUE", produto.minimoEmEstoque);
                command.Parameters.AddWithValue("@MAXIMO_EM_ESTOQUE", produto.maximoEmEstoque);
                command.Parameters.AddWithValue("@CODIGO_BARRAS", produto.codigoBarras);
                command.Parameters.AddWithValue("@ID_PRODUTO", produto.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiProduto(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete PRODUTO where ID_PRODUTO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_PRODUTO", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
