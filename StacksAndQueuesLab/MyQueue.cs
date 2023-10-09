using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueuesLab
{
    public class MyQueue<T> : IQueue<T>
    {
        public int Count => throw new NotImplementedException();

        public T Dequeue()
        {
            throw new NotImplementedException();
        }

        public MyQueue<T> Enqueue(T item)
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        void IQueue<T>.Enqueue(T item)
        {
            throw new NotImplementedException();
        }
    }
}
