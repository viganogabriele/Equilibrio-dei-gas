using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._2___Equilibrio_Gas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nIstanti = 30;
            int nParticelle = 100;
            int contA = 0;
            int contB = 0;
            Gas g = new Gas(nParticelle);
            for (int i = 1; i <= nIstanti; i++)
            {
                g.SimulaEvoluzione();
                g.Risultati(ref contA, ref contB);
                Console.WriteLine("Evoluzione {0} - Settore A: {2} particelle - Settore B: {1} particelle ", i, contA, contB);
            }
            Console.ReadKey();
        }
    }
}
