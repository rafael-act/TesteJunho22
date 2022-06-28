using RevendaVeiculos.Dominio.Contratos;
using RevendaVeiculos.Dominio.Entidades;
using RevendaVeiculos.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RevendaVeiculos.Repositorio.Repositorios
{
    public class ProprietarioRepositorio : BaseRepositorio<Proprietario>, IProprietarioRepositorio
    {
        public ProprietarioRepositorio(RevendaVeiculosContexto revendaVeiculosContexto) : base(revendaVeiculosContexto)
        {
        }
        public bool ValidaDuplicacao(Proprietario proprietario)
        {
            return RevendaVeiculosContexto.Set<Proprietario>()
                .Where(m => m.Nome == proprietario.Nome)
                .Count() > 0 ? false : true;//se existe == false
        }
    }
}
