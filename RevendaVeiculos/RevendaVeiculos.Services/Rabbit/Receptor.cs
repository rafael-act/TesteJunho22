using System;
using RabbitMQ.Client;
using System.Text;
using RevendaVeiculos.Dominio.Entidades;
using Newtonsoft.Json;
using RabbitMQ.Client.Events;


namespace RevendaVeiculos.Services.Rabbit
{
    public class Receptor:DefaultBasicConsumer
    {
        public Veiculo RecebeVeiculoFila()
        {
            CommonService commonService = new CommonService();
            IConnection connection = commonService.GetRabbitMqConnection();
            IModel model = connection.CreateModel();

            var consumer = new EventingBasicConsumer(model);
            consumer.Received += Consumer_Received;
            model.BasicConsume(
                queue: "VeiculosQueue",
                autoAck:true,
                consumer:consumer
                );

            return new Veiculo();
        }
        private static void Consumer_Received(
          object sender, BasicDeliverEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Body.ToArray());
            Console.WriteLine(Environment.NewLine +
                "Veiculo => " + message);

            var veiculo = JsonConvert.DeserializeObject<Veiculo>(message);
            Email.Email.EnviarEmail(veiculo);
        }

    }
}
