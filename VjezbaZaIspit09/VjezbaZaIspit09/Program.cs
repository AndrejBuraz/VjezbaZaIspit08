using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspit09
{
    internal class Program
    {

        class GeometrijskiLik
        {
            public int BrojStranica;
            double[] Stranice = new double[10];

            public void UcitajStranice(string tijelo)
            {
                for(int i = 0; i < this.BrojStranica; i++)
                {
                    Console.WriteLine("Unesi " + (i + 1) + ". stranicu "+ tijelo +": ");
                    this.Stranice[i] = Convert.ToInt32(Console.ReadLine());
                }
                
            }
            public double Opseg()
            {
                double rez = 0;
                for (int i = 0; i < this.BrojStranica; i++)
                {
                    rez += Stranice[i];
                }
                return rez;
            }
        }

        class Trokut : GeometrijskiLik
        {
            public Trokut()
            {
                this.BrojStranica = 3;
                this.UcitajStranice("trokuta");
            }
        }

        class Cetverokut : GeometrijskiLik
        {
            public Cetverokut()
            {
                this.BrojStranica = 4;
                this.UcitajStranice("cetverokuta");
            }
        }

        static void Main(string[] args)
        {
            Trokut trokut = new Trokut();
            Cetverokut cetverokut = new Cetverokut();
            Console.WriteLine("Opseg trokuta: {0}\nOpseg cetverokuta: {1}", trokut.Opseg(), cetverokut.Opseg());
            Console.ReadKey();
        }
    }
}
