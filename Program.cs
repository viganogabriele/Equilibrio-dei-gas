using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _30._2___Equilibrio_Gas
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // Dichiarazioni
            Random random = new Random();
            int nIstanti = 30;
            int nParticelle = 100;
            int contA = 100;
            int contB = 0;
            string percorsoFile = "C:\\Users\\gabri\\OneDrive\\Desktop\\Gas.csv.txt";
            Gas g = new Gas(nParticelle);

            // Pulizia file
            IniziaFile(percorsoFile); 

            // Programma evoluzioni
            for (int i = 0; i <= nIstanti; i++)
            {
                Console.WriteLine("Evoluzione {0} - Settore A: {1} particelle - Settore B: {2} particelle ", i, contA, contB);
                CompilaFile(percorsoFile, i, contA, contB);
                g.SimulaEvoluzione(random);
                g.Risultati(ref contA, ref contB);     
            }
            Console.ReadKey();
        }
        static void CompilaFile(string percorsoFile, int istante, int contA, int contB)
        {
            File.AppendAllText(percorsoFile, 
            string.Format("{0}\t{1}\t{2}\r\n", istante, contA, contB));
        }
        static void IniziaFile(string percorsoFile)
        {
            if (File.Exists(percorsoFile) == true)
            {
                File.Delete(percorsoFile);
            }
            File.AppendAllText(percorsoFile,
            string.Format("Istante\tSettoreA\tSettoreB\r\n"));
        }
    }
}
