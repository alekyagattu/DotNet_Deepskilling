﻿using Confluent.Kafka;

Console.WriteLine("Kafka Chat Producer");
Console.WriteLine("Type messages (type 'exit' to quit)");

var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

using var producer = new ProducerBuilder<Null, string>(config).Build();

while (true)
{
    Console.Write("You: ");
    var message = Console.ReadLine();

    if (message?.ToLower() == "exit") break;

    await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
    Console.WriteLine("Message sent.");
}
