using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daire__get_set_operator_overload
{
    class Daire
    {
        private double yc;
        private double gpi;
        public double r
        {
            get { return yc; }
            set { yc = Math.Abs(value); }
        }
        public double pi
        {
            set { gpi = Math.Abs(value); }
            get { return gpi; }
        }
        public Daire()
        { gpi = 3.14d; }
        public Daire(double pi,double r)
        {
            this.pi = pi;
            this.r = r;
        }
        public double Cevre()
        { return 2 * gpi * yc; }
        public double Alan()
        { return gpi * yc * yc; }
        static public double operator-(Daire d1,Daire d2)
        { return d1.Alan() - d2.Alan(); }
        static public string operator >(Daire d1, Daire d2)
        {
            if (d1.Alan() > d2.Alan())
                Console.Write("daire 1 buyuk");
            return "";
        }
        static public string operator <(Daire d1, Daire d2)
        {
            if (d1.Alan() < d2.Alan())
                Console.Write("daire 1 kucuk");
                    return "";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Daire d1 = new Daire();
            d1.r = 4;
            Daire d2 = new Daire(3,2);
            
            double fark = d1 - d2;
            Console.WriteLine(" birinci daire : " + d1.Alan());
            Console.WriteLine(" ikinci Daire  : " + d2.Alan());
            Console.WriteLine("alan farkı = " + fark);
        }
    }
}
