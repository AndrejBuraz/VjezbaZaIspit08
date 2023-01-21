using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaZaIspit007
{
    internal class Program
    {

        class Fruit
        {
            private string vrsta, boja;
            private bool jeLiSlatko;

            public Fruit(string vrsta)
            {
                this.vrsta = vrsta;
            }

            public Fruit(string vrsta, string boja, bool jeLiSlatko)
            {
                this.vrsta = vrsta;
                this.boja = boja;
                this.jeLiSlatko = jeLiSlatko;
            }

            public override string ToString()
            {
                Console.WriteLine("Vrsta: {0}\nBoja: {1}\nSlatko: {2}", this.vrsta, this.boja, this.jeLiSlatko);
                return "";
            }
        }

        static void Main(string[] args)
        {
            Fruit Jagoda = new Fruit("jagoda", "crvena", true);
            Fruit Limun = new Fruit("limun", "zuti", false);
            Fruit Avokado = new Fruit("avokado", "zeleni", false);
            Jagoda.ToString();
            Limun.ToString();
            Avokado.ToString();
            Console.ReadKey();

        }
    }
}
