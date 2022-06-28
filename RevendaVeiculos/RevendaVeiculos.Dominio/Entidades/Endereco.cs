using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevendaVeiculos.Dominio.Entidades
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        [JsonProperty(PropertyName = "state")]
        public string Estado { get; set; }
        [JsonProperty(PropertyName = "city")]
        public string Cidade { get; set; }
        [JsonProperty(PropertyName = "neighborhood")]
        public string Bairro { get; set; }
        [JsonProperty(PropertyName = "street")]
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Servico { get; set; }
    }
}
