
namespace LAB2CS_red
{
    internal class Test
    {
        static void Main(string[] args)
        {

            BaseList abstr = new ArrList();
            BaseList chain = new ChainList();

            Random rnd = new();

            int iter = 2000;

            for (int i = 0; i < iter; i++)
            {
                int ops = rnd.Next(5);
                int value = rnd.Next(100);
                int pos = rnd.Next(2000);

                switch (ops)
                {
                    case 0:

                        abstr.Add(value);
                        chain.Add(value);
                        break;

                    case 2:

                        abstr.Delete(pos);
                        chain.Delete(pos);
                        break;

                    case 1:

                        abstr.Insert(value, pos);
                        chain.Insert(value, pos);

                        break;

                    /* case 3:
                        //Console.WriteLine("clr");
                        abstr.Clear();
                        chain.Clear();
                        break; */

                    case 4:

                        abstr[pos] = value;
                        chain[pos] = value;
                        break;
                }
            }

            if (abstr.IsEqual(chain)) Console.WriteLine("Успешно");

            Console.WriteLine($"Arr count = {abstr.Count}, Chain count = {chain.Count}\n");

            abstr.Assign(chain);

            if (abstr.IsEqual(chain)) Console.WriteLine("Успешно");

            abstr.Show();
            Console.WriteLine("\n\n");
            chain.Show();
            Console.WriteLine("\n\n");

            Console.WriteLine("\n\nНажмите любую клавишу");
            Console.ReadKey();
        }


    }
}
