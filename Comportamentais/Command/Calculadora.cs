namespace Command
{
    public class Calculadora
    {
        private int _valorAtual;

        public void Operacao(char operador, int valor)
        {
            switch(operador)
            {
                case '+':
                    _valorAtual += valor;
                    break;
                case '-':
                    _valorAtual -= valor;
                    break;
                case '*':
                    _valorAtual *= valor;
                    break;
                case '/':
                    _valorAtual /= valor;
                    break;
            }
            System.Console.WriteLine("(dado {1} {2}) - Valor Atual = {0,3}", _valorAtual, operador, valor);
        }
    }
}