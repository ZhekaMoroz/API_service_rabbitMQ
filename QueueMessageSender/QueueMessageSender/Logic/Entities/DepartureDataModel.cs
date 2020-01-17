﻿namespace QueueMessageSender.Models
{
    /// <summary>
    /// The data model includes a message and data for sending messages for RabbitMQ.
    /// </summary>
    public class DepartureDataModel
    {
        public string NameExchange { get; set; }
        public string RoutingKey { get; set; }
        public object Message { get; set; }
    }
}