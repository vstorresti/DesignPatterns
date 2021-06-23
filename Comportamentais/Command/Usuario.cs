using System.Collections.Generic;

namespace Command
{
    public class Usuario
    {
        private readonly Calculadora _calculadora = new Calculadora();
        private readonly List<Commander> _commands = new List<Commander>();
        private int _total;

        public void Adicionar(char operador, int valor)
        {
            Commander cmd = new CalculadoraCommand(_calculadora, operador, valor);
            cmd.Executar();

            _commands.Add(cmd);
            _total++;
        }

        public void Retornar(int niveis)
        {
            System.Console.WriteLine("Retornando {0} níveis", niveis);

            for(var i = 0; i < niveis; i++)
            {
                if(_total >= _commands.Count - 1) continue;
                var command = _commands[_total++];
                command.Executar();
            }
        }

        public void Desfazer(int niveis)
        {
            System.Console.WriteLine("Desfazendo {0} níveis", niveis);

            for(var i = 0; i < niveis; i++)
            {
                if(_total <= 0) continue;
                var command = _commands[--_total];
                command.Desfazer();
            }
        }
    }
}