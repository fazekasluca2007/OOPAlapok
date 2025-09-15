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

        protected string _nev;
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
      
       public override string ToString()
        {
            return $"A személy neve: {_nev} és az életkora {_kor}";
        }
        
    }

    public class Bankszamla
    {
        private int _egyenleg;
        public int Egyenleg
        {
            get { return _egyenleg; }
            set
            {
                if (value > 0)
                    _egyenleg = value;
                else
                    Console.WriteLine("Egyenleg nem lehet nulla");
            }
        }
        public void Betesz()
        {

        }
        public void Kivesz()
        {

        }
    }
    public class Hallgato : Szemely
    {
        private string _neptunKod;
        public string NeptunKod
        {
            get { return _neptunKod; }
            set
            {
                if (_neptunKod.Length <= 6)
                    _neptunKod = value;
                else
                    Console.WriteLine("Túl hosszú kód!");
            }
        }

      
        public override string ToString()
        {
            _nev = "István";
            return $"A hallgató neve{_nev}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Szemely person = new Szemely();
            person.Nev = "Kiss Ilona";
            person.Kor = 23;
            Console.WriteLine(person);

            Hallgato student = new Hallgato();
            Console.WriteLine(student);

           /* Szemely person = new Szemely("Peti",22);
            System.Console.WriteLine(person.Kiir());*/

            
        }
    }
    
}
