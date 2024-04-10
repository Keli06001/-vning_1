using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace övning_1
{
    public class bil
    {
        private string märke;
        private string modell;
        private int hästkrafter;
        private int vikt;
        private int sittplatser;
        public bil(string mä, string mo, int h, int v, int s) 
        {
            märke = mä;
            modell = mo;
            hästkrafter = h;
            vikt = v;
            sittplatser = s;
        }
        public void Output(string mä, string mo, int h, int v, int s)
        {
            Console.WriteLine(mä);
            Console.WriteLine(mo);
            Console.WriteLine(h);
            Console.WriteLine(v);
            Console.WriteLine(s);
        }
        public string Märke
        { get { return märke; } set { märke = value; } }
        public string Modell
        { get { return modell; } set {  modell = value; } }
        public int H
        { get { return hästkrafter; } set { hästkrafter = value; } }
        public int Vikt
        { get { return vikt; } set {  vikt = value; } }
        public int Sittplatser
        { get { return sittplatser; } set { sittplatser = value; } }

    }
    class Program
    {

        static void Main()
        {
            bil b = new bil("Volvo", "XC60", 215, 1567, 5);



            Console.WriteLine(b.Märke);
            Console.WriteLine(b.Modell);
            Console.WriteLine(b.H+"HP");
            Console.WriteLine(b.Vikt+"KG");
            Console.WriteLine(b.Sittplatser+"st");

            Console.ReadKey();
        }
    }

}
