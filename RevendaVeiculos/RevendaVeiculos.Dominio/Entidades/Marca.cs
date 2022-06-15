using RevendaVeiculos.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevendaVeiculos.Dominio.Entidades
{
    public class Marca:Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Status Status { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Nome da marca não foi informado");
            }

            if(!Enum.IsDefined(typeof(Status), Status))
            {
                AdicionarCritica("Status não foi informado");
            }
        }
    }
}
