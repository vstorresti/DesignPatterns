namespace FactoryMethod
{
    public class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var sqlCn = DbFactory.Database(DataBase.SqlServer)
                                    .CreateConnection("connectionString")
                                    .Connect();

            sqlCn.ExecuteCommand("select * from tabelaSql");
            sqlCn.Close();

            System.Console.WriteLine();

            var oracleCn = DbFactory.Database(DataBase.Oracle)
                                    .CreateConnection("connectionString")
                                    .Connect();

            oracleCn.ExecuteCommand("select * from tabelaOracle");
            oracleCn.Close();
        }
    }
}