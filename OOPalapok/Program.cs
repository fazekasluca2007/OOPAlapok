using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOPalapok
{
    public class Szemely
    {
        private string nev;
        private int kor;

        public Szemely(string Nev,int Kor)
        {
            nev = Nev;
            kor = Kor;
        }
        public string Kiir()
        {
            return $"A személy neve:{nev} és életkora {kor}";
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely person = new Szemely("Peti",22);
            System.Console.WriteLine(person.Kiir());
            
        }
    }
    
}
