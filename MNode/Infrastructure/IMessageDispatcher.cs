using ECommon.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNode.Infrastructure
{
    /// <summary>
    /// Represents a message dispatcher(调度、转发)
    /// </summary>
    public interface IMessageDispatcher
    {
        /// <summary>
        /// Dispatch the given message async.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<AsyncTaskResult> DispatchMessageAsync(IMessage message);
        /// <summary>
        /// Dispatch the given messages async.
        /// </summary>
        /// <param name="messages"></param>
        /// <returns></returns>
        Task<AsyncTaskResult> DispatchMessageAsync(IEnumerable<IMessage> messages);
    }
}
