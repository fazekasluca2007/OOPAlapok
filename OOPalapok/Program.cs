﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOPalapok
{
    public class Szemely
    {
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
        {
            nev = Nev;
            kor = Kor;
        }
        */


        public string Kiir()
        {
            return $"A személy neve:{nev} és életkora {kor}";
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely person = new Szemely();
            person.Nev = "Kiss Ilona";
            person.Kor = 23;
            Console.WriteLine($"A személy neve:{person.Nev} és {person.Kor} éves");

           /* Szemely person = new Szemely("Peti",22);
            System.Console.WriteLine(person.Kiir());*/
            
        }
    }
    
}
