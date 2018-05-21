using Dados.Entidades;
using Dados.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dominio.DominioModels
{
    public class EmailDominio : IDisposable
    {

        private readonly Repositorio repositorio;

        public EmailDominio()
        {
            repositorio = new Repositorio();
        }

        public void Salvar(List<Email> lstEmail)
        {
           foreach(var item in lstEmail)
            {
                repositorio.NovoContexto();
                repositorio.Salvar(item);
            }
        }

        public void Excluir(Email email)
        {
            repositorio.Excluir(email);
        }

        public List<Email> ObterEmailContato(int contatoId)
        {
            return repositorio.ObterTodos<Email>(c => c.IdContato == contatoId).ToList();
        }

        public List<Email> ObterEmailContato(List<int> lstContatoId)
        {
            return repositorio.ObterTodos<Email>(c => lstContatoId.Contains(c.IdContato) ).ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
