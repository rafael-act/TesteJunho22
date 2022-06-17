using RevendaVeiculos.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevendaVeiculos.Dominio.Entidades
{
    public class Proprietario:Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public virtual ICollection<Veiculo> Veiculos { get; set; }
        public Status Status { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Nome do proprietario não foi informado");
            }

            if (string.IsNullOrEmpty(Documento))
            {
                AdicionarCritica("Documento do proprietario não foi informado");
            }

            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("Email do proprietario não foi informado");
            }

            if (Endereco is null)
            {
                AdicionarCritica("Endereço do proprietario não foi informado");
            }

            if (!Enum.IsDefined(typeof(Status), Status))
            {
                AdicionarCritica("Status não foi informado");
            }
        }
    }
}
