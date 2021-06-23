namespace Composite
{
    public class DomainMessage : IMessage
    {
        public string Nome {get; set;}
        
        public DomainMessage(string nome)
        {
            Nome = nome;
        }

        public void ExibirMensagens(int sub)
        {
            System.Console.WriteLine(new string('-', sub) + Nome);
        }
    }
}