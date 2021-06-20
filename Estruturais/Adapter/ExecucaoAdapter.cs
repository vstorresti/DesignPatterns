namespace Adapter
{
    public class ExecucaoAdapter
    {
        public static void Executar()
        {
            var pagamentoLogLadrao = new TransacaoService(new Logger());
            pagamentoLogLadrao.RealizarTransacao();

            var pagamentoLogCustom = new TransacaoService(new LogAdapter(new LogNetMasterService()));
            pagamentoLogCustom.RealizarTransacao();
        }
    }
}