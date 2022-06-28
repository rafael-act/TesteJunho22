using RevendaVeiculos.Dominio.Contratos;
using RevendaVeiculos.Dominio.Entidades;
using RevendaVeiculos.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevendaVeiculos.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(RevendaVeiculosContexto revendaVeiculosContexto) : base(revendaVeiculosContexto)
        {
        }
    }
}
