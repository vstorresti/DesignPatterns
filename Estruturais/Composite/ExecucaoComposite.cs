using System;

namespace Composite
{
    public class ExecucaoComposite
    {
        public static void Executar()
        {
            var validacaoCadastro = new Mensagem("O cadastro não foi realizado!");

            var usuarioFormErro = new Mensagem("O Usuário informado é inválido");

            var tamanhoNomeForm = new InputFormMessage("O nome precisa possuir mais de 2 caracteres");
            var nomeVazioForm = new InputFormMessage("O nome não pode possuir números");

            usuarioFormErro.AdicionarFilha(tamanhoNomeForm);
            usuarioFormErro.AdicionarFilha(nomeVazioForm);

            validacaoCadastro.AdicionarFilha(usuarioFormErro);

            var domainUsuarioErro = new Mensagem("problemas ao acessar o usuário");

            var cpfUsuarioDomain = new DomainMessage("O Cpf informado é inválido");
            var emailUsuarioDomain = new DomainMessage("O email informado está em uso");

            domainUsuarioErro.AdicionarFilha(cpfUsuarioDomain);
            domainUsuarioErro.AdicionarFilha(emailUsuarioDomain);

            validacaoCadastro.AdicionarFilha(domainUsuarioErro);

            validacaoCadastro.ExibirMensagens(2);
        }
    }
}
