namespace FactoryMethod
{
    public class Connection
    {
        public string ConnectionString { get; set;}
        public bool Opened {get; set;}

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void ExecuteCommand(string command)
        {
            System.Console.WriteLine("Executando comando: " + command);
        }

        public void Open()
        {
            Opened = true;
            System.Console.WriteLine("Conexão aberta");
        }

        public void Close()
        {
            System.Console.WriteLine("Conexão fechada");
        }
    }
}