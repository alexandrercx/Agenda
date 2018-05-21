using Dados.Entidades;
using Dados.Repositorios;
using Dados.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace Dominio.DominioModels
{
    public class ContatoDominio : IDisposable
    {

        private readonly Repositorio repositorio;
        private readonly TelefoneDominio telefoneDominio;
        private readonly EmailDominio emailDominio;


        public ContatoDominio()
        {
            repositorio = new Repositorio();
            telefoneDominio = new TelefoneDominio();
            emailDominio = new EmailDominio();
        }


        public void Salvar(Contato contato)
        {
            repositorio.Salvar(contato);
        }

        public void Salvar(Contato contato, List<Telefone> lstTel, List<Email> lstEmail)
        {
            if (string.IsNullOrEmpty(contato.Nome))
            {
                throw new FormatException("Nome é informação obrigatória");
            }
   

            using (var trans = new TransactionScope())
            {
               

                repositorio.Salvar(contato);

                lstTel.ForEach(c => c.IdContato = contato.Id);
                lstEmail.ForEach(c => c.IdContato = contato.Id);

                telefoneDominio.Salvar(lstTel);
                emailDominio.Salvar(lstEmail);

                trans.Complete();
            }
        }

        public void Excluir(int contatoId)
        {
            var contato = Obter(contatoId);
            repositorio.Excluir(contato);
        }

        public Contato Obter(int id)
        {
            return repositorio.ObterPorId<Contato>(id);
        }

        public List<ContatoView> Listar(string nome)
        {
            var colecaoContato = new List<Contato>();
            if (string.IsNullOrEmpty(nome.Trim()))
               colecaoContato = repositorio.ObterTodos<Contato>();
            else
                colecaoContato = repositorio.ObterTodos<Contato>(c => c.Nome.StartsWith(nome));


            List<ContatoView> lstContatoView = new List<ContatoView>();
            ContatoView contato;
            foreach(var item in colecaoContato)
            {
                contato = new ContatoView();
                contato.IdContato = item.Id;
                contato.NomeContato = item.Nome;
                contato.Numeros = item.colecaoTelefone.Select(c => c.Numero).ToList();
                contato.Emails = item.colecaoEmail.Select(c => c.EnderecoEmail).ToList();
                lstContatoView.Add(contato);
            }

            return lstContatoView;
        }


        public void Dispose()
        {
            repositorio.Dispose();
            telefoneDominio.Dispose();
            emailDominio.Dispose();
        }

    }
}
