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
    class CrudAnimal
    {
        public void inserirAnimal(Animal animal)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "insert into ANIMAL (CARTEIRINHA, NOME, ID_CLIENTE, RACA_PORTE, SEXO, PELAGEM_COR, NASCIMENTO, ID_VETERINARIO ) values(?,?,?,?,?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@CARTEIRINHA", animal.carteirinha);
                command.Parameters.AddWithValue("@NOME", animal.nome);                
                command.Parameters.AddWithValue("@ID_CLIENTE", animal.idCliente);
                command.Parameters.AddWithValue("@RACA_PORTE", animal.racaPorte);
                command.Parameters.AddWithValue("@SEXO", animal.sexo);
                command.Parameters.AddWithValue("@PELAGEM_COR", animal.pelagemCor);
                command.Parameters.AddWithValue("@NASCIMENTO", animal.nascimento);
                command.Parameters.AddWithValue("@ID_VETERINARIO", animal.idVeterinario);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaAnimal(string sql)
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

        public void alteraAnimal(Animal animal)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update ANIMAL set NOME = ?, CARTEIRINHA = ?, ID_CLIENTE = ?, RACA_PORTE = ?, SEXO = ?, PELAGEM_COR = ?, NASCIMENTO = ?, ID_VETERINARIO = ?,  where ID_ANIMAL = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@NOME", animal.nome);
                command.Parameters.AddWithValue("@CARTEIRINHA", animal.carteirinha);
                command.Parameters.AddWithValue("@ID_CLIENTE", animal.idCliente);
                command.Parameters.AddWithValue("@RACA_PORTE", animal.racaPorte);
                command.Parameters.AddWithValue("@SEXO", animal.sexo);
                command.Parameters.AddWithValue("@PELAGEM_COR", animal.pelagemCor);
                command.Parameters.AddWithValue("@NASCIMENTO", animal.nascimento);
                command.Parameters.AddWithValue("@ID_VETERINARIO", animal.idVeterinario);
                command.Parameters.AddWithValue("@ID_ANIMAL", animal.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiCliente(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete ANIMAL where ID_ANIMAL = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
