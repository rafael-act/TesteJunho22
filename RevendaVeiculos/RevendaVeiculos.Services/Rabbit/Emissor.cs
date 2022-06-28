using System;
using RabbitMQ.Client;
using System.Text;
using RevendaVeiculos.Dominio.Entidades;
using Newtonsoft.Json;

namespace RevendaVeiculos.Services.Rabbit
{
    public class Emissor
    {
        public bool EnviaVeiculoFila(Veiculo veiculo)
        {
            try
            {
                var v = new Veiculo()
                {
                    AnoModelo = 2022,
                    Id = 1,
                    Marca = new Marca() { Id = 1, Nome = "Fiat", Status = true, Veiculos = null },
                    Modelo = "Uno",
                    Proprietario = null,
                    Quilometragem = 112,
                    Renavam = "abcd1234",
                    Valor = 57000
                };
                CommonService commonService = new CommonService();
                IConnection connection = commonService.GetRabbitMqConnection();
                IModel model = connection.CreateModel();
                SetupSerialisationMessageQueue(model);
                IBasicProperties basicProperties = model.CreateBasicProperties();
                String jsonified = JsonConvert.SerializeObject(v);
                byte[] customerBuffer = Encoding.UTF8.GetBytes(jsonified);
                model.BasicPublish("", CommonService.SerialisationQueueName, basicProperties, customerBuffer);
                return true;
            }
            catch { return false; }
        }
        private static void SetupSerialisationMessageQueue(IModel model)
        {
            model.QueueDeclare(CommonService.SerialisationQueueName, true, false, false, null);
        }
    }
}
