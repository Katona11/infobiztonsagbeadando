using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titkositobeadando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irjon be a szöveget");
            string szoveg = Console.ReadLine();
            Console.WriteLine("Mennyivel tolja el");
            int eltolas = int.Parse(Console.ReadLine());
            Console.WriteLine(Cesarkodolo(szoveg,eltolas)); 
            Console.ReadLine();
        }
        static string Cesarkodolo(string szoveg,int kod)
        {
            char[] karakterek = new char[szoveg.Length];
            for (int i = 0; i < szoveg.Length; i++)
            {
                karakterek[i] = szoveg[i];
            }
            string uzenet = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                uzenet += (char)((int)karakterek[i] + kod);
            }
            return uzenet;
            
            
        }


        static string Csoportoshelyettesites(string szoveg)
        {
            string[,] tablazat = new string[,]
            {
                { " ","AA","AB","AC","BA","BB","BC","CA","CB","CC"},
                { "A","-","W","U","S","Z,","U","P","K","M"},
                { "B","F","G","B","D","Q","R","N","L","J"},
                { "C","I","E","C","A","H","X","Y","T","V"}

            };

              return "";

        }
    }
}
