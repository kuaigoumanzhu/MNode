namespace MNode.Infrastructure
{
    /// <summary>
    /// Represents a handler proxy(代理、委托).
    /// </summary>
    public interface IObjectProxy
    {
        /// <summary>
        /// Get the inner object.
        /// </summary>
        /// <returns></returns>
        object GetInnerObject();
    }
}
