using RevendaVeiculos.Dominio.Contratos;
using RevendaVeiculos.Dominio.Entidades;
using RevendaVeiculos.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RevendaVeiculos.Repositorio.Repositorios
{
    public class MarcaRepositorio : BaseRepositorio<Marca>, IMarcaRepositorio
    {
        public MarcaRepositorio(RevendaVeiculosContexto revendaVeiculosContexto) : base(revendaVeiculosContexto)
        {
        }

        public bool ValidaDuplicacao(Marca marca)
        {
            return RevendaVeiculosContexto.Set<Marca>()
                .Where(m => m.Nome == marca.Nome)
                .Count() > 0 ? false : true;//se existe == false
        }
    }
}
