using System.Data.Odbc;
using System.Text;

namespace MariosPet.Classes
{
    class ConexaoPadrao
    {
        public static OdbcConnection createConnection()
        {
            // Mudar para o nome do seu servidor
            // string server = @"./";
            // string server = @".\MSERVERSQL";
            //string server = @".\.";        
            //string server = @".\SQLSERVER";
            //string server = @"LOCALHOST\SQL";

            string server = @"LOCALHOST\SQL";
            string driver = @"SQL Server";            
            string dataBase = @"MARIOS_PET";

            StringBuilder stringConnection = new StringBuilder();

            stringConnection.Append("driver=");
            stringConnection.Append(driver);
            stringConnection.Append(";server=");
            stringConnection.Append(server);
            stringConnection.Append(";database=");
            stringConnection.Append(dataBase);


            return new OdbcConnection(stringConnection.ToString());
        }
    }
}