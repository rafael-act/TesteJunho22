using System;
using System.Collections.Generic;
using System.Text;

namespace RevendaVeiculos.Dominio.Entidades
{
    public class Veiculo:Entidade
    {
        public int Id { get; set; }
        public Proprietario Proprietario { get; set; }
        public string Renavam { get; set; }
        public Marca Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoModelo { get; set; }
        public int Quilometragem { get; set; }
        public double Valor { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (Proprietario is null)
            {
                AdicionarCritica("Proprietario não foi informado");
            }

            if (string.IsNullOrEmpty(Renavam))
            {
                AdicionarCritica("Renavam do veículo não foi informado");
            }

            if (Marca is null)
            {
                AdicionarCritica("Marca não foi informado");
            }


            if (string.IsNullOrEmpty(Modelo))
            {
                AdicionarCritica("Modelo do veículo não foi informado");
            }

            if (AnoModelo==0)
            {
                AdicionarCritica("Ano do veículo não foi informado");
            }

            if (Quilometragem<0)
            {
                AdicionarCritica("Quilometragem do veículo não foi informado");
            }

            if (Valor <= 0)
            {
                AdicionarCritica("Valor do veículo não foi informado");
            }
        }

    }
}
