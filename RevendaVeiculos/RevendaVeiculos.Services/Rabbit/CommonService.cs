using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevendaVeiculos.Services.Rabbit
{
    public class CommonService
    {
        private string _hostName = "localhost";
        private string _userName = "revenda";
        private string _password = "revenda";
        private int _port = 5672;

        public static string SerialisationQueueName = "VeiculosQueue";

        public IConnection GetRabbitMqConnection()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory();
            connectionFactory.HostName = _hostName;
            connectionFactory.UserName = _userName;
            connectionFactory.Password = _password;
            connectionFactory.Port = _port;


            return connectionFactory.CreateConnection();
        }
    }
}
