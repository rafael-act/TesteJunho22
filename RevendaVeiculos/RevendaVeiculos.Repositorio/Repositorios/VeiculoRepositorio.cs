using RevendaVeiculos.Dominio.Contratos;
using RevendaVeiculos.Dominio.Entidades;
using RevendaVeiculos.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RevendaVeiculos.Repositorio.Repositorios
{
    public class VeiculoRepositorio : BaseRepositorio<Veiculo>, IVeiculoRepositorio
    {
        public VeiculoRepositorio(RevendaVeiculosContexto revendaVeiculosContexto) : base(revendaVeiculosContexto)
        {}
        public bool ValidaDuplicacao(Veiculo veiculo)
        {
            return RevendaVeiculosContexto.Set<Veiculo>()
                .Where(m => m.Renavam == veiculo.Renavam)
                .Count() > 0 ? false : true;//se existe == false
        }
    }
}
