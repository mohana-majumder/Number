using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter a number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                Program p = new Program();
                string str = p.DivNum(num);
                Console.WriteLine(str);
                Console.WriteLine("Do you want to continue (Y/N)? ");
            } while (Console.ReadLine().ToUpper() == "Y");
        }
        public string DivNum(int num)
        {
            string str = "";
            if (num % 3 == 0 && num % 5 == 0)
            {
                str = "C";
            }
            else if (num % 3 == 0)
            {
                str = "A";
            }
            else if (num % 5 == 0)
            {
                str = "B";
            }
            else
            {
                str = "Not divisible";
            }
            return str;
        }
    }
}
