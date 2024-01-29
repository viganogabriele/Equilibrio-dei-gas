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
            int nIstanti = 30;
            int nParticelle = 100;
            int contA = 100;
            int contB = 0;
            Gas g = new Gas(nParticelle);
            IniziaFile();
            for (int i = 0; i <= nIstanti; i++)
            {
                Console.WriteLine("Evoluzione {0} - Settore A: {1} particelle - Settore B: {2} particelle ", i, contA, contB);
                CompilaFile(i, contA, contB);
                g.SimulaEvoluzione();
                g.Risultati(ref contA, ref contB);     
            }
            Console.ReadKey();
        }
        static void CompilaFile(int istante, int contA, int contB)
        {
            File.AppendAllText("C:\\Users\\gabri\\OneDrive\\Desktop\\Gas.csv.txt", 
            string.Format("{0}\t{1}\t{2}\r\n", istante, contA, contB));
        }
        static void IniziaFile()
        {
            if (File.Exists("C:\\Users\\gabri\\OneDrive\\Desktop\\Gas.csv.txt") == true)
            {
                File.Delete("C:\\Users\\gabri\\OneDrive\\Desktop\\Gas.csv.txt");
            }
            File.AppendAllText("C:\\Users\\gabri\\OneDrive\\Desktop\\Gas.csv.txt",
            string.Format("Istante\tSettoreA\tSettoreB\r\n"));
        }
    }
}
