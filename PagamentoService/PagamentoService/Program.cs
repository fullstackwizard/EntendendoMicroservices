using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

var factory = new ConnectionFactory() { HostName = "localhost" };

try
{
    using var connection = factory.CreateConnection();
    using var channel = connection.CreateModel();

    channel.QueueDeclare(queue: "pedidos", durable: false, exclusive: false, autoDelete: false, arguments: null);

    var consumer = new EventingBasicConsumer(channel);
    consumer.Received += (model, ea) =>
    {
        var body = ea.Body.ToArray();
        var message = Encoding.UTF8.GetString(body);
        Console.WriteLine($"Mensagem recebida: {message}");
    };

    channel.BasicConsume(queue: "pedidos", autoAck: true, consumer: consumer);

    Console.WriteLine("Pressione [enter] para sair.");
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
