using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RentalApplicationJanuardi
{
    public class Connection : IDisposable
    {
        private const string ConnectionString = @"Data Source=DESKTOP-ID1NRPQ\SQLEXPRESS; Initial Catalog=db_rental_januardi; Integrated Security=true";

        private SqlConnection sqlConnection;

        public Connection()
        {
            sqlConnection = new SqlConnection(ConnectionString);
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }

        public void Dispose()
        {
            if (sqlConnection != null)
            {
                sqlConnection.Dispose();

                sqlConnection = null;
            }
        }
    }
}
