using System;
using RabbitMQ.Client;
using System.Text;

class Send
{
     
        public void send(string message)  
        {
        var factory = new ConnectionFactory() { HostName = "amqp://dtthmyhq:BCddowD70aoyhu-TlMtx1_GNVetm-OhQ@hornet.rmq.cloudamqp.com/dtthmyhq" };
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {
            channel.QueueDeclare(queue: "upt",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            
            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: "",
                                 routingKey: "upt",
                                 basicProperties: null,
                                 body: body);
            Console.WriteLine(" [x] Sent {0}", message);
        }

        Console.WriteLine("Message has been send!");
        //Console.ReadLine();
        
        
    }
}
