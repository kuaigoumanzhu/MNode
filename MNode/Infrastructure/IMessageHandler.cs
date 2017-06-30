using ECommon.IO;
using System.Threading.Tasks;

namespace MNode.Infrastructure
{
    /// <summary>
    /// Represents a message handler
    /// </summary>
    public interface IMessageHandler
    {
    }
    /// <summary>
    /// Represents a message handler
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMessageHandler<in T>:IMessageHandler where T:class,IMessage
    {
    }
    /// <summary>
    /// Represents a message handler
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public interface IMessageHandler<in T1,in T2>:IMessageHandler
        where T1:class,IMessage
        where T2:class,IMessage
    {
        /// <summary>
        /// Handle the given message async.
        /// </summary>
        /// <param name="message1"></param>
        /// <param name="message2"></param>
        /// <returns></returns>
        Task<AsyncTaskResult> HandleAsync(T1 message1,T2 message2);
    }

    public interface IMessageHandler<in T1,in T2,in T3>:IMessageHandler
        where T1:class,IMessage
        where T2:class,IMessage
        where T3:class,IMessage
    {
        /// <summary>
        /// Handle the given message async.
        /// </summary>
        /// <param name="message1"></param>
        /// <param name="message2"></param>
        /// <param name="message3"></param>
        /// <returns></returns>
        Task<AsyncTaskResult> HandleAsync(T1 message1, T2 message2, T3 message3);
    }
}
