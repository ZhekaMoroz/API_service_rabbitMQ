﻿using QueueMessageSender.Logic.Models;

namespace QueueMessageSender.Logic
{
    /// <summary>
    /// Abstraction to publish messages to the queue.
    /// </summary>
    public interface IQueueMessageSender
    {
        void SendMessage(DepartureDatаRMQModel data);
    }
}
