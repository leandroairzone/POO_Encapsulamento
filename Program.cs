using System;
using Encapsulamento_POO.Classes;

namespace Encapsulamento_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();
            m.Parcela = 12;
           
            
            Console.WriteLine(m.Bandeira);
        }
    }
}
