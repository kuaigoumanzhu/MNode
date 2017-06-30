using ECommon.IO;
using System.Threading.Tasks;

namespace MNode.Infrastructure
{
    /// <summary>
    /// Represents a message handler proxy.
    /// </summary>
    public interface IMessageHandlerProxy1:IObjectProxy
    {
        /// <summary>
        /// Handle the given message async.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<AsyncTaskResult> HandleAsync(IMessage message);
    }
    /// <summary>
    /// Represents a message handler proxy.
    /// </summary>
    public interface IMessageHandlerProxy2:IObjectProxy
    {
        /// <summary>
        /// Handle the given message async.
        /// </summary>
        /// <param name="message1"></param>
        /// <param name="message2"></param>
        /// <returns></returns>
        Task<AsyncTaskResult> HandleAsync(IMessage message1, IMessage message2);
    }
    /// <summary>
    /// Represents a message handler proxy.
    /// </summary>
    public interface IMessageHandlerProxy3:IObjectProxy
    {
        /// <summary>
        /// Handle the given message async.
        /// </summary>
        /// <param name="message1"></param>
        /// <param name="message2"></param>
        /// <param name="message3"></param>
        /// <returns></returns>
        Task<AsyncTaskResult> HandleAsync(IMessage message1,IMessage message2,IMessage message3);
    }
}
