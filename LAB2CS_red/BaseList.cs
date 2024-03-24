using System;

namespace LAB2CS_red
{
    public abstract class BaseList
    {
        protected int count = 0;
        protected abstract BaseList Dummy();
        public int Count { get { return count; } }
        public abstract void Add(int val);
        public abstract void Delete(int pos);
        public abstract void Insert(int val, int pos);
        public abstract void Clear();
        public abstract int this[int i] { set; get; }
        public abstract void Show(); 
        public void Assign(BaseList source) 
        {
            Clear();
            for (int i = 0; i < source.Count; i++) Add(source[i]);            
        }
        public void AssignTo(BaseList dest)
        {
            dest.Assign(this);
        }
        public BaseList Clone() 
        {
            BaseList clone = Dummy();
            clone.Assign(this);
            return clone;
        }
        public virtual void Sort()
        {   
            if (this.Count == 0 || this.Count == 1) { return; }
            
            int pos = 0;
            while (pos < this.Count)
            {
                if (this[pos] >= this[pos + 1])
                {
                    pos++;
                }

                else
                {
                    (this[Count - 1], this[pos]) = (this[pos], this[Count - 1]);

                    if (pos > 0) pos--;
                }
            }                         
        }
        public bool IsEqual(BaseList list) 
        {
            if (this.Count > 0)
            {
                for (int i = 0; i <= this.Count; i++)
                {
                    if (this[i] != list[i]) return false; 
                }
                return true;
            } 
            else if (this.Count == 0) return true;
            else return false;
        }

    }
}
