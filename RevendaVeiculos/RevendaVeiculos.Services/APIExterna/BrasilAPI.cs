using Newtonsoft.Json;
using RevendaVeiculos.Dominio.Entidades;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace RevendaVeiculos.Services.APIExterna
{
    public class BrasilAPI
    {
        private const string URL = "https://brasilapi.com.br/api/cep/v1/";
        public static async Task<Endereco> ProcessarEndereco(string cep)
        {
          return  await ConsultarEndereco(cep);
        }
        private static async Task<Endereco> ConsultarEndereco(string cep) {
           var requisicao = WebRequest.CreateHttp(URL + cep);
            requisicao.Method = "GET";
            var endereco = new Endereco();
             using (var respostaRequisicao = requisicao.GetResponse())
            {
                var dados = respostaRequisicao.GetResponseStream();
                StreamReader leitor = new StreamReader(dados);
                object resultado = leitor.ReadToEnd();

                 endereco = JsonConvert
                    .DeserializeObject<Endereco>(resultado.ToString());
                dados.Close();
                respostaRequisicao.Close();
            }
            return endereco;
        }
    }
}
