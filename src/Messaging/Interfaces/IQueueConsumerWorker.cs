﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Vtex.RabbitMQ.Messaging.Interfaces
{
    public interface IQueueConsumerWorker : IDisposable
    {
        bool ModelIsClosed { get; }

        Task DoConsumeAsync(CancellationToken cancellationToken);

        void Ack(ulong deliveryTag);

        void Nack(ulong deliveryTag, bool requeue = false);
    }
}
