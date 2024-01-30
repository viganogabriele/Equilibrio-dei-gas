using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._2___Equilibrio_Gas
{
    internal class Particella
    {
        public char settore = 'A';
        public void Evoluzione(Random random)
        {
            int numeroCasuale = random.Next(1, 7); // Genera una delle 6 direzioni
            if(numeroCasuale == 1) // Se la direzione è 1 cambia settore
            {
                if(settore == 'A')
                {
                    settore = 'B';
                }
                else
                {
                    settore = 'A';
                }
            }
        }
    }
}
