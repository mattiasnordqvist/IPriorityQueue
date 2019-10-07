using System;

namespace PriorityQueue
{
    /// <summary>
    /// Represents a queue where elements with the highest priority are served first. I.e insertion order does not matter.
    /// Priority of an element is decided by the implementation of its IComparable interface, and the priority queue
    /// should give smaller items higher priority. For example, 6 has higher priority than 10, and "a" has higher priority than "c".
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPriorityQueue<T> where T : IComparable<T>, IComparable
    {
        /// <summary>
        /// Adds a new value to the priority queue
        /// </summary>
        /// <param name="value">The value to be added</param>
        void Add(T value);

        /// <summary>
        /// Return the count of elements in the priority queue.
        /// </summary>
        /// <returns>The number of elements in the priority queue</returns>
        int Count();

        /// <summary>
        /// Returns the element with the highest priority in the queue.
        /// 
        /// This method should throw an InvalidOperationException if the queue is empty
        /// </summary>
        /// <returns>The element with the highest priority in the queue</returns>
        T Peek();

        /// <summary>
        /// Returns the element with the highest priority, and also removed it from the priority queue.
        /// 
        /// This method should throw an InvalidOperationException if the queue is empty
        /// </summary>
        /// <returns>The element with the highest priority</returns>
        T Pop();
    }
}
