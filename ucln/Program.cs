using System;

namespace ucln
{
    class Program
    {
        static void Main(string[] args)
        {
            int  n1, n2;
            Console.Write("Nhap so thu nhat: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            tim(n1, n2);
           

            Console.ReadKey();
            static void tim(int a1,int a2){
                int i, j, ucln = 1;
                j = (a1 < a2) ? a1 : a2;
                for (i = 1; i <= j; i++)
                {
                    if (a1 % i == 0 && a2 % i == 0)
                    {
                        ucln = i;
                    }
                }
                Console.Write("uoc chung lon nhat cua {0} va {1} la: {2}", a1, a2, ucln);
            }
        }
    }
}
