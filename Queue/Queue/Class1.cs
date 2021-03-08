using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue<T>
    {
        Entry _Top;
        Entry _Tail;

        public bool Is_Empty()
        {
            if(_Top == null && _Tail == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Push(T data)
        {
            if(Is_Empty() == true)
            {
                _Tail = new Entry(_Tail, data);
            }
            _Top = new Entry(_Top, data);
        }

        public T Pop()
        {
            if(_Tail == null)
            {
                throw new InvalidCastException();
            }
            T result = _Tail.Data;
            _Tail = _Tail.Next;
            return result;
        }

        class Entry
        {
            public Entry Next { get; set;}
            public T Data { get; set;}

            public Entry (Entry next, T data)
            {
                Next = next;
                Data = data;
            }
        }
    }
}
