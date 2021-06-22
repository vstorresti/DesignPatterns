using System;
using System.Collections.Generic;
using Facade.CrossCutting;
using Facade.Domain;

namespace Facade
{
    public class ExecucaoFacade
    {
        public static void Executar()
        {
            var produtos = new List<Produto>
            {
                new Produto { Nome = "Tenis Adidas", Valor = new Random().Next(500)},
                new Produto { Nome = "Raquete Tenis", Valor = new Random().Next(500)},
                new Produto { Nome = "Camisa Boliche", Valor = new Random().Next(500)}
            };

            var pedido = new Pedido
            {
                Id = Guid.NewGuid(),
                Produtos = produtos
            };

            var pagamento = new Pagamento
            {
                CartaoCredito = "5555 2222 3333 4444"
            };

            var pagamentoService = new PagamentoCartaoCreditoService(new PagamentoCartaoCreditoFacade(new PayPalGateway(), new ConfigurationManager()));

            var pagamentoResult = pagamentoService.RealizarPagamento(pedido, pagamento);

            System.Console.WriteLine(pagamentoResult.Status);
        }
    }
}
