using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System;
using System.Text;
using System.Text.Json;

[ApiController]
[Route("api/pedido")]
public class PedidoController : ControllerBase
{
    [HttpPost]
    public IActionResult CriarPedido()
    {
        var pedido = new { Id = Guid.NewGuid(), Produto = "Notebook", Preco = 5000 };

        try
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: "pedidos", durable: false, exclusive: false, autoDelete: false, arguments: null);

            var mensagem = JsonSerializer.Serialize(pedido);
            var body = Encoding.UTF8.GetBytes(mensagem);

            channel.BasicPublish(exchange: "", routingKey: "pedidos", basicProperties: null, body: body);

            return Ok($"Pedido {pedido.Id} enviado para pagamento!");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao enviar pedido: {ex.Message}");
        }
    }
}
