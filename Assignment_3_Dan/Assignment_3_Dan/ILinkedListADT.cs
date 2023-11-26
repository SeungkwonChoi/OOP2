using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Dan
{
    public interface ILinkedListADT
    {
        void AddFirst(int data);
        void AddLast(int data);
        void RemoveAt(int index);
        void RemoveFirst();
        void RemoveLast();
        void InsertAt(int index, int data);
        void Replace(int index, int data);
        int GetItemAt(int index);
        int IndexOf(int data);
        bool Contains(int data);
        void Clear();
        int Count();
        void Reverse();
    }

}
