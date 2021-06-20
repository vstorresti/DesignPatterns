namespace FactoryMethod
{
    public class OracleFactory : DbFactory
    {
        public override DbConnector CreateConnection(string connectionString)
        {
            return new OracleDbConnection(connectionString);
        }
    }
}