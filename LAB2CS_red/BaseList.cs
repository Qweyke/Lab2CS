using System;

namespace LAB2CS_red
{
    public abstract class BaseList
    {
        int Count { get; }
        public abstract void Add(int val);
        public abstract void Delete(int pos);
        public abstract void Insert(int val, int pos);
        public abstract void Clear();
        public abstract int this[int i] { set; get; }
        void Print() { }
        void Assign(BaseList source) { }
        void AssignTo(BaseList dest) { }
        public BaseList Clone() { return null; }


    }
}
