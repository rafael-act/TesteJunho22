using System;
using System.Collections.Generic;
using System.Text;

namespace RevendaVeiculos.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Nome não foi informado");
            }

            if (string.IsNullOrEmpty(Sobrenome))
            {
                AdicionarCritica("Sobrenome não foi informado");
            }

            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("Email não foi informado");
            }

            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarCritica("Senha não foi informada");
            }
        }
    }
}
