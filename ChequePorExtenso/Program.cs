using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Cheque cheque = new Cheque(999999999999.99);

            Console.WriteLine(cheque.resultado.ToUpper());
            Console.ReadLine();
        }
    }

}
