namespace FactoryMethod
{
    public class OracleDbConnection : DbConnector
    {
        public OracleDbConnection(string connectionString) : base (connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            System.Console.WriteLine("Conenctando ao banco Oracle...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}