namespace FactoryMethod
{
    public class SqlFactory : DbFactory
    {
        public override DbConnector CreateConnection(string connectionString)
        {
            return new SqlServerConnection(connectionString);
        }
    }
}