using Dados.Entidades;
using Dados.Repositorios;
using System;
using System.Collections.Generic;

namespace Dominio.DominioModels
{
    public class ClassificacaoDominio : IDisposable
    {
        private readonly Repositorio repositorio;


        public ClassificacaoDominio()
        {
            repositorio = new Repositorio();
        }


        public List<Classificacao> Listar()
        {
            return repositorio.ObterTodos<Classificacao>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
