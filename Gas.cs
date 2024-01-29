using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._2___Equilibrio_Gas
{
    internal class Gas : Particella
    {
        public List <Particella> particelle = new List<Particella>();
        public Gas(int nParticelle)
        {
            AggiungiParticelle(nParticelle);
        }
        public void AggiungiParticelle(int nParticelle)
        {
            for (int i = 0; i < nParticelle; i++)
            {
                particelle.Add(new Particella());
            }
        }
        public void SimulaEvoluzione()
        {
            foreach (Particella p in particelle)
            {
                p.Evoluzione();
            }
        }
        public void Risultati(ref int contA, ref int contB)
        {
            contA = 0;
            contB = 0; 
            foreach (Particella p in particelle)
            {
                if (p.settore == 'A')
                {
                    contA++;
                }
                else
                {
                    contB++;
                }
            }
        }
    }
}
