﻿using System;

namespace MNode.Infrastructure
{
    /// <summary>
    /// 表示一个message
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Represents the unique identifier of the message.
        /// </summary>
        string Id { get; set; }
        /// <summary>
        /// Represents the timestamp of the message.(时间戳)
        /// </summary>
        DateTime Timestamp { get; set; }
        /// <summary>
        /// Represents the sequence of the message which is belongs to the message stream.
        /// </summary>
        int Sequence { get; set; }
        /// <summary>
        /// Represents the routing key of the message.
        /// </summary>
        /// <returns></returns>
        string GetRoutingKey();
        /// <summary>
        /// Represents the type name of the message.
        /// </summary>
        /// <returns></returns>
        string GetTypeName();
    }
}
