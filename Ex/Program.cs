using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario("João", 220, 30);
            Funcionario func2 = new Funcionario("Marcos", 180, 22);
            Funcionario func3 = new Terceiro("Matheus", 220, 32.5, "Itaú", 0.10);

            func1.ImprimeDados();
            func2.ImprimeDados();
            func3.ImprimeDados();

            Console.ReadLine();
        }
    }
}
