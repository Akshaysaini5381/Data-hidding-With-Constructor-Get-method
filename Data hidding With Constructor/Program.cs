using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_hidding_With_Constructor
{

    class data
    {
        private int num;

    public    data(int num)
        {
            this.num = num;
        }
        public int GetNum()
        {
            return this.num;
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            data obj = new data(100);
            int num1 = obj.GetNum();
            Console.WriteLine(num1);
            Console.ReadLine();
        }
    }
}
