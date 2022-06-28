using RevendaVeiculos.Dominio.Contratos;
using RevendaVeiculos.Dominio.Entidades;
using RevendaVeiculos.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevendaVeiculos.Repositorio.Repositorios
{
    public class EnderecoRepositorio : BaseRepositorio<Endereco>, IEnderecoRepositorio
    {
        public EnderecoRepositorio(RevendaVeiculosContexto revendaVeiculosContexto) : base(revendaVeiculosContexto)
        {
        }
    }
}
