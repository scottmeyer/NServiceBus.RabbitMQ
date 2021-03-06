﻿namespace EasyNetQ
{
    using NServiceBus.Transports.RabbitMQ.Config;
    using RabbitMQ.Client;

    interface IConnectionFactory
    {
        IConnection CreateConnection();
        IConnectionConfiguration Configuration { get; }
        IHostConfiguration CurrentHost { get; }
        bool Next();
        void Success();
        void Reset();
        bool Succeeded { get; }
    }
}