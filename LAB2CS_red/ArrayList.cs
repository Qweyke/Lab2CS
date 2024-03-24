
namespace LAB2CS_red
{
    public class ArrList : BaseList
    {
        int cnt = 0; // pos < cnt if cnt != 0
        int[] buf;
        int size = 1;

        public ArrList()
        {
            buf = new int[size];
        }

        private void Expd()
        {
            size *= 2;
            Array.Resize(ref buf, size);
        }

        public override void Add(int val)
        {
            if (cnt >= size) { Expd(); }
            buf[cnt] = val;
            cnt++;

        }
        public override void Insert(int val, int pos)
        {
            if (pos == cnt && pos == 0) Add(val);

            else if (pos == cnt) Add(val);

            else if (pos < cnt)
            {
                cnt++;
                if (cnt >= size) Expd();

                for (int i = cnt - 1; i != pos; i--)
                {
                    buf[i] = buf[i - 1];
                }
                buf[pos] = val;
            }
        }
        public override void Delete(int pos)
        {
            if (pos < cnt)
            {
                for (int i = pos; i < cnt - 1; i++)
                {
                    buf[i] = buf[i + 1];
                }
                cnt--;
            }

            else if (pos == cnt - 1 && cnt > 0)
            {
                buf[pos] = 0;
                cnt--;
            }
        }

        public override void Clear()
        {
            for (int i = 0; i < cnt; i++)
            {
                buf[i] = 0;
            }
            cnt = 0;
        }

        public int Count
        {
            get { return cnt; }
        }

        public override int this[int i]
        {
            get
            {
                if (i >= cnt || i < 0) return 0;

                return buf[i];
            }

            set
            {
                if (i >= cnt || i < 0) return;

                buf[i] = value;
            }
        }

        public void Show()
        {
            if (cnt >= 0)
            {
                for (int i = 0; i < cnt; i++)
                {
                    if (i == cnt - 1) Console.Write($"{buf[i]}. ");
                    else Console.Write($"{buf[i]}, ");
                }
            }
            else Console.WriteLine("Нет элементов в array листе");
        }
    }
}
