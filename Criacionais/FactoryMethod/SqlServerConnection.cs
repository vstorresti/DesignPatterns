namespace FactoryMethod
{
    public class SqlServerConnection : DbConnector
    {
        public SqlServerConnection(string connectionString) : base (connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            System.Console.WriteLine("Conenctando ao banco SQL Server...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}