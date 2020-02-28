using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace QueueStackTest
{
    [TestClass]
    public class QueueTest 
    {
        [TestMethod]
        public void QueueUsePeek()
        {
            var queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            Assert.AreEqual(1, queue.Peek());
        }
    }
}
