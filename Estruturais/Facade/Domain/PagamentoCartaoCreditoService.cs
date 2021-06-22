using System.Linq;

namespace Facade.Domain
{
    public class PagamentoCartaoCreditoService : IPagamento
    {
        private readonly IPagamentoCartaoCreditoFacade _pagamentoCartaoCreditoFacade;
        
        public PagamentoCartaoCreditoService(IPagamentoCartaoCreditoFacade pagamentoCartaoCreditoFacade)
        {
            _pagamentoCartaoCreditoFacade = pagamentoCartaoCreditoFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            System.Console.WriteLine("Iniciando pagamento Via cartão de crédito - Valor R$ " + pagamento.Valor);

            if(_pagamentoCartaoCreditoFacade.RealizarPagamento(pedido, pagamento))
            {
                pagamento.Status = "Pago via cartão de crédito";
                return pagamento;
            }

            pagamento.Status = "Cartão de crédito Recusado!";
            return pagamento;
        }
    }
}