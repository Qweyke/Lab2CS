﻿
namespace LAB2CS_red
{
    internal class Test
    {
        static void Main(string[] args)
        {

            ArrList abstr = new ArrList();
            ChainList chain = new ChainList();

            Random rnd = new Random();

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

                    /*case 3:
                        //Console.WriteLine("clr");
                        abstr.Clr();
                        chain.Clear();
                        break;*/

                    case 4:

                        abstr[pos] = value;
                        chain[pos] = value;
                        break;
                }
            }

            bool check = false;

            for (int i = 0; i < abstr.Count; i++)
            {
                if (abstr[i] != chain[i])
                {
                    Console.WriteLine("Элементы не сошлись");
                    Console.WriteLine($"{abstr[i]}, {chain[i]}, {i}");
                    check = true;
                }
            }
            if (check == false) Console.WriteLine("Успешно\n");

            Console.WriteLine($"Arr cnt = {abstr.Count}, Chain cnt = {chain.Count}\n");

            abstr.Show();
            Console.WriteLine("\n\n");
            chain.Show();
            Console.WriteLine("\n\n");

            Console.WriteLine("\n\nНажмите любую клавишу");
            Console.ReadKey();
        }


    }
}
