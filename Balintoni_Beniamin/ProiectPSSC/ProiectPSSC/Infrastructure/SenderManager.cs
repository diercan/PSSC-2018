using System;
using System.Text;
using System.Windows.Forms;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace ProiectPSSC.Infrastructure
{
    public class SenderManager
    {
        public void SendMessage(string message)
        {
            try
            {
                var factory = new ConnectionFactory() {HostName = "localhost"};
                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "orderQueue",
                        durable: false,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                        routingKey: "orderQueue",
                        basicProperties: null,
                        body: body);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Eroare conexiune!");
            }
        }

        public string ReceiveMessage()
        {
            var message = string.Empty;
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "orderQueue",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    message = Encoding.UTF8.GetString(body);
                };
                channel.BasicConsume(queue: "orderQueue",
                    autoAck: true,
                    consumer: consumer);
            }

            return message;
        }
    }
}
