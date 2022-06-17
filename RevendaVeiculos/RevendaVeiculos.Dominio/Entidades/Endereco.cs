using System;
using System.Collections.Generic;
using System.Text;

namespace RevendaVeiculos.Dominio.Entidades
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Servico { get; set; }
    }
}
