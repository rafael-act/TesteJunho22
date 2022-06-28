using RevendaVeiculos.Dominio.Contratos;
using RevendaVeiculos.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RevendaVeiculos.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly RevendaVeiculosContexto RevendaVeiculosContexto;
        
        public BaseRepositorio(RevendaVeiculosContexto revendaVeiculosContexto)
        {
            RevendaVeiculosContexto = revendaVeiculosContexto;
        }

        public void Adicionar(TEntity entity)
        {
            RevendaVeiculosContexto.Set<TEntity>().Add(entity);
            RevendaVeiculosContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            RevendaVeiculosContexto.Set<TEntity>().Update(entity);
            RevendaVeiculosContexto.SaveChanges();
        }

        public void Dispose()
        {
            RevendaVeiculosContexto.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return RevendaVeiculosContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return RevendaVeiculosContexto.Set<TEntity>().ToList();
        }

        public bool ValidaDuplicacao(TEntity entity)
        {
            return false;
        }
    }
}
