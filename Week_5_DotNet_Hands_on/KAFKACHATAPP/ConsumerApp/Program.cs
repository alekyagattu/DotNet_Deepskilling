using Confluent.Kafka;

Console.WriteLine("Kafka Chat Consumer - Listening...");

var config = new ConsumerConfig
{
    BootstrapServers = "localhost:9092",
    GroupId = "chat-consumer-group",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
consumer.Subscribe("chat-topic");

while (true)
{
    var consumeResult = consumer.Consume();
    Console.WriteLine($"Received: {consumeResult.Message.Value}");
}
