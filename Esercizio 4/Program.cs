using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire primo numero");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire secondo numero");
            int n2=int.Parse(Console.ReadLine());
            calcolamcd(n1,n2);
        }
        static int calcolamcd(int n1,int n2)

        {
            while(n2!=0)
                {
                int temp = n2;
                n2 = n1 % n2;
                n1 = temp;
            }
            return 0;
        }
    }
}
