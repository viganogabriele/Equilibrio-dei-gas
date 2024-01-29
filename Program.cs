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
            int contA = 100;
            int contB = 0;
            Gas g = new Gas(nParticelle);
            for (int i = 0; i <= nIstanti; i++)
            {
                Console.WriteLine("Evoluzione {0} - Settore A: {1} particelle - Settore B: {2} particelle ", i, contA, contB);
                g.SimulaEvoluzione();
                g.Risultati(ref contA, ref contB);     
            }
            Console.ReadKey();
        }
    }
}
