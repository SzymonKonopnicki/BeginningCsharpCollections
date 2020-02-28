using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace QueueStackTest
{
    [TestClass]
    public class StackTest 
    {
        [TestMethod]
        public void StackUsePeek()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            Assert.AreEqual(6, stack.Peek());
        }
    }
}
