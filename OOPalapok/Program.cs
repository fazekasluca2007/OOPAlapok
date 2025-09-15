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
<<<<<<< HEAD
        private string _nev;
        private int _kor;

        public string Nev
        {
            get { return _nev; }
            set { _nev = value; }
        }
         public int Kor
        {
            get { return _kor; }
            
            set 
            {
                if(value>0)
                _kor = value;
                else
                    Console.WriteLine("Nem lehet negatív.");
            }
        }
        /*public Szemely(string Nev,int Kor)
=======
        private string nev;
        private int kor;

        public Szemely(string Nev,int Kor)
>>>>>>> b697acaf912ea2052c789e7a9af8d1ec6dfea628
        {
            nev = Nev;
            kor = Kor;
        }
<<<<<<< HEAD
        */


=======
        public int Kor
        {
            get { return kor; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Hiba: Az életkor nem lehet negatív!");
                }
                else
                {
                    kor = value;
                }
            }
        }
>>>>>>> b697acaf912ea2052c789e7a9af8d1ec6dfea628
        public string Kiir()
        {
            return $"A személy neve:{nev} és életkora {kor}";
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Szemely person = new Szemely();
            person.Nev = "Kiss Ilona";
            person.Kor = 23;
            Console.WriteLine($"A személy neve:{person.Nev} és {person.Kor} éves");

           /* Szemely person = new Szemely("Peti",22);
            System.Console.WriteLine(person.Kiir());*/
=======
            Szemely person = new Szemely("Peti",22);
            System.Console.WriteLine(person.Kiir());

>>>>>>> b697acaf912ea2052c789e7a9af8d1ec6dfea628
            
        }
    }
    
}
