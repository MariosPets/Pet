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
    class CrudLaboratorio: CrudPessoaJuridica
    {
        public void inserirLaboratorio(Laboratorio laboratorio)
        {
            inserirPessoaJuridica(laboratorio);
            laboratorio.id = Convert.ToInt32(consultaPessoaJuridica("select top 1 ID_PESSOA_JURIDICA from PESSOA_JURIDICA order by ID_PESSOA_JURIDICA desc").Rows[0][0].ToString());

            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

            }
        }

        public DataTable consultaLaboratorio(string sql)
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

        public void alteraLaboratorio(Laboratorio laboratorio)
        {
            alteraPessoaJuridica(laboratorio);
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

            }
        }

        public void excluiLaboratorio(int codigo)
        {
            excluiPessoaJuridica(codigo);
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                
            }
        }
    }
}
