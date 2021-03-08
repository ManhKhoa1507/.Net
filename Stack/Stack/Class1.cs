using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Collections
{
    public class Stack<T>
    {
        Entry _top;

        public void Push(T data)
        {
            _top = new Entry(_top, data);
        }

        public bool Is_Empty()
        {
            if (_top == null)
            {
                return true;
            }
            else return false;
        }

        public T Pop()
        {
            if(_top == null)
            {
                throw new InvalidCastException();
            }
            T result = _top.Data;
            _top = _top.Next;
            return result;
        }
        class Entry
        {
            public Entry Next
            {
                get;
                set;
            }

            public T Data
            {
                get;
                set;
            }

            public Entry(Entry next, T data)
            {
                Next = next;
                Data = data;
            }
        }
    }
}
