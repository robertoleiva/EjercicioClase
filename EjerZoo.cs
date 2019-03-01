using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciozoologico
{
    class Program
    {

        public string grup1, grup2, grup3, grup4;

        static void Main(string[] args)
        {



            Program zoo = new Program();
            Console.WriteLine(zoo.gene1() + zoo.gene2() + zoo.gene3() + zoo.gene4());
            Console.ReadKey();

        }

        string gene1()
        {
            return "Aves: 10 ";

        }


        string gene2()
        {
            return "Reptiles: 20 ";


        }

        string gene3()
        {
            return "Mamiferos: 15";


        }

        string gene4()
        {
            return "Acuaticos: 10 ";


        }


    }



}


    

