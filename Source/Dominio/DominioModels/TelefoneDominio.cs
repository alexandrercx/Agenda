using Dados.Entidades;
using Dados.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dominio.DominioModels
{
    public class TelefoneDominio : IDisposable
    {
        private readonly Repositorio repositorio;


        public TelefoneDominio()
        {
            repositorio = new Repositorio();
        }

        public void Salvar(List<Telefone> lst)
        {
            
            lst.ForEach(c => c.Numero = c.Numero.Replace("(", "").Replace(")","").Replace("-",""));
            foreach (var item in lst)
            {             
                if (!string.IsNullOrEmpty(item.Numero) && !string.IsNullOrWhiteSpace(item.Numero))
                {
                    repositorio.NovoContexto();
                    repositorio.Salvar(item);
                }
                 
            }
        }

        public void Excluir(Telefone telefone)
        {
            repositorio.Excluir(telefone);
        }

        public List<Telefone> ObterTelefoneContato(int contatoId)
        {
            return repositorio.ObterTodos<Telefone>(c => c.IdContato == contatoId).ToList();
        }

        public List<Telefone> ObterTelefoneContato(List<int> lstContatoId)
        {
            return repositorio.ObterTodos<Telefone>(c => lstContatoId.Contains(c.IdContato)).ToList();
        }


        public void Dispose()
        {
            repositorio.Dispose();
        }
    }
}
