namespace Composite
{
    public class InputFormMessage : IMessage
    {
        public string Nome {get; set;}

        public InputFormMessage(string nome)
        {
            Nome = nome;
        }

        public void ExibirMensagens(int sub)
        {
            System.Console.WriteLine(new string('-', sub) + Nome);
        }
    }
}