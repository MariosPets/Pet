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
    class CrudAnamnese
    {
        public void inserirAnamnese(Anamnese anamnese)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "insert into ANAMNESE (D_ANIMAL, ID_VETERINARIO, VACINADO, DOENCAS, TRATAMENTOS, SISTEMA_DIGESTORIO, SISTEMA_CARDIO_RESPIRATORIO, SISTEMA_GENITO_URINARIO, SISTEMA_NERVOSO_LOCOMOTOR, PELES_ANEXOS, MANEJO, DATA) values(?,?,?,?,?,?,?,?,?,?,?,?)";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", anamnese.idAnimal);
                command.Parameters.AddWithValue("@ID_VETERINARIO", anamnese.idVeterinario);
                command.Parameters.AddWithValue("@VACINADO", anamnese.vacinado);
                command.Parameters.AddWithValue("@DOENCAS", anamnese.doencas);
                command.Parameters.AddWithValue("@TRATAMENTOS", anamnese.tratamentos);
                command.Parameters.AddWithValue("@SISTEMA_DIGESTORIO", anamnese.sistemaDigestorio);
                command.Parameters.AddWithValue("@SISTEMA_CARDIO_RESPIRATORIO", anamnese.sistemaCardioRespiratorio);
                command.Parameters.AddWithValue("@SISTEMA_GENITO_URINARIO", anamnese.sistemaGenitoUrinario);
                command.Parameters.AddWithValue("@SISTEMA_NERVOSO_LOCOMOTOR", anamnese.sistemaNervosoLocomotor);
                command.Parameters.AddWithValue("@PELES_ANEXOS", anamnese.pelesAnexos);
                command.Parameters.AddWithValue("@MANEJO", anamnese.manejo);
                command.Parameters.AddWithValue("@DATA", anamnese.data);
                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable consultaAnamnese(string sql)
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

        public void alteraAnamnese(Anamnese anamnese)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "update ANAMNESE set ID_ANIMAL = ?, ID_VETERINARIO = ?,VACINADO = ?, DOENCAS = ?, TRATAMENTOS = ?, SISTEMA_DIGESTORIO = ?, SISTEMA_CARDIO_RESPIRATORIO = ?, SISTEMA_GENITO_URINARIO = ?, SISTEMA_NERVOSO_LOCOMOTOR = ?, PELES_ANEXOS = ?, MANEJO = ?, DATA = ?, where ID_ANAMNESE = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANIMAL", anamnese.idAnimal);
                command.Parameters.AddWithValue("@ID_AVETERINARIO", anamnese.idVeterinario);
                command.Parameters.AddWithValue("@VACINADO", anamnese.vacinado);
                command.Parameters.AddWithValue("@DOENCAS", anamnese.doencas);
                command.Parameters.AddWithValue("@TRATAMENTOS", anamnese.tratamentos);
                command.Parameters.AddWithValue("@SISTEMA_DIGESTORIO", anamnese.sistemaDigestorio);
                command.Parameters.AddWithValue("@SISTEMA_CARDIO_RESPIRATORIO", anamnese.sistemaCardioRespiratorio);
                command.Parameters.AddWithValue("@SISTEMA_GENITO_URINARIO", anamnese.sistemaGenitoUrinario);
                command.Parameters.AddWithValue("@SISTEMA_NERVOSO_LOCOMOTOR", anamnese.sistemaNervosoLocomotor);
                command.Parameters.AddWithValue("@PELES_ANEXOS", anamnese.pelesAnexos);
                command.Parameters.AddWithValue("@MANEJO", anamnese.manejo);
                command.Parameters.AddWithValue("@DATA", anamnese.data);
                command.Parameters.AddWithValue("@ID_ANAMNESE", anamnese.id);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        public void excluiAnamnese(int codigo)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "delete ANAMNESE where ID_ANAMNESE = ?";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                command.Parameters.AddWithValue("@ID_ANAMNESE", codigo);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
