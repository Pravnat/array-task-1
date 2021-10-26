using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaryofemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the Array");
            int n =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("enter the employees salary");
            int[] sal = new int[n];

            for( int i=0;i<sal.Length;i++)
            {
                sal[i] = int.Parse(Console.ReadLine());

            }
            double avg = sal.Sum() / sal.Length;
            Console.WriteLine("the average salary: ");
            Console.WriteLine(avg);



            int low = sal[0];
            for(int i = 0; i < n; i++)
            {
                if (sal[i] < low)
                {
                    low = sal[i];
                }
                
            }
            Console.WriteLine("the lowest salary :");
            Console.WriteLine(low);
            Array.Sort(sal);
            Console.WriteLine("highest salary of employee: ");
            Console.WriteLine(sal[sal.Length - 1]);

            
        }
    }
}
