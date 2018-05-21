using CoreFramework.Linq;
using Dados.Contextos;
using Dados.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Transactions;

namespace Dados.Repositorios
{
    public class Repositorio : IDisposable
    {
        private Contexto contexto;

        public Repositorio()
        {
            NovoContexto();
        }

        #region CRUD

        private void SaveChanges()
        {
            using (var transacao = new TransactionScope())
            {
                contexto.SaveChanges();

                transacao.Complete();
            }
        }

        public void Salvar<T>(T entidade) where T : Entidade
        {
            if (entidade == null)
                throw new ArgumentNullException("entidade", "Não é possível salvar uma entidade nula.");

            contexto.Set<T>().Attach(entidade);

            if (entidade.Id == 0)
                contexto.Set<T>().Add(entidade);
            else
                contexto.Entry(entidade).State = EntityState.Modified;

            ValidarEntidade(entidade);
            SaveChanges();
        }

        public void Incluir<T>(T entidade) where T : Entidade
        {
            if (entidade == null)
                throw new ArgumentNullException("entidade", "Não é possível salvar uma entidade nula.");

            if (entidade.Id == 0)
                throw new ArgumentNullException("entidade", "Não é possível incluir sem Id.");

            contexto.Set<T>().Attach(entidade);
            contexto.Set<T>().Add(entidade);

            ValidarEntidade(entidade);
            SaveChanges();
        }

        public void Excluir<T>(T entidade) where T : Entidade
        {
            if (entidade == null)
                throw new ArgumentNullException("entidade", "Não é possível excluir uma entidade nula.");

            contexto.Set<T>().Attach(entidade);
            contexto.Set<T>().Remove(entidade);

            SaveChanges();
        }

        #endregion

        #region Obter

        public T ObterPorId<T>(int id, bool novoContexto = true) where T : Entidade
        {
            return ObterQueryable<T>(c=> c.Id == id, novoContexto).FirstOrDefault();
        }

        public T ObterPorChavePrimaria<T>(object[] chave, bool novoContexto = true) where T : Entidade
        {
            if (novoContexto)
                NovoContexto();

            return contexto.Set<T>().Find(chave);
        }

        public List<T> ObterTodos<T>(Expression<Func<T, bool>> expressao = null, bool novoContexto = true) where T : Entidade
        {
            return ObterQueryable(expressao, novoContexto).ToList();
        }

        public List<T> ObterTodos<T>(string expressaoDinamica, object[] parametros, bool novoContexto = true) where T : Entidade
        {
            return ObterTodos<T>(null, novoContexto).AsQueryable().Where(expressaoDinamica, parametros).ToList();
        }

        public IQueryable<T> ObterQueryable<T>(Expression<Func<T, bool>> expressao = null, bool novoContexto = true) where T : Entidade
        {
            if (novoContexto)
                NovoContexto();

            return (expressao == null ? contexto.Set<T>() : contexto.Set<T>().Where(expressao));
        }

        #endregion

        #region Auxiliares

        private void ValidarEntidade<T>(T entidade) where T: Entidade
        {
            try
            {
                entidade.Validar();
            }
            catch (Exception ex)
            {
                contexto.Detach(entidade);
                throw new ValidationException(ex.Message);
            }
        }

        public void NovoContexto()
        {
            DetachAll();
            contexto = new Contexto();
        }

        private void DetachAll()
        {
            if (contexto != null)
                contexto.DetachAll();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        #endregion
    }
}


