using System;

namespace FactoryMethod
{
    public abstract class DbFactory
    {
        public abstract DbConnector CreateConnection(string connectionString);

        public static DbFactory Database(DataBase dataBase)
        {
            if(dataBase == DataBase.SqlServer)
                    return new SqlFactory();
            if(dataBase == DataBase.Oracle)
                    return new OracleFactory();
            else 
                throw new ApplicationException("Banco de dados não encontrado");
            }
        }
}