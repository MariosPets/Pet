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
    class CrudFoto
    {
        public void inserirFoto(Foto foto)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {

                string sql = "insert into FOTO (ID_ANIMAL, FOTO) values(?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", foto.idAnimal);
                command.Parameters.AddWithValue("@FOTO", foto.foto);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaFoto(string sql)
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

        public void alteraFoto(Foto foto)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update FOTO set ID_ANIMAL = ?, FOTO = ? where ID_FOTO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", foto.idAnimal);
                command.Parameters.AddWithValue("@FOTO", foto.foto);
                command.Parameters.AddWithValue("@ID_FOTO", foto.id);


                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiFoto(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete FOTO where ID_FOTO = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_FOTO", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
