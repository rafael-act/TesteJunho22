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
        public bool Status { get; set; }

        public virtual ICollection<Veiculo> Veiculos { get; set; }
        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Nome da marca não foi informado");
            }
        }
    }
}
