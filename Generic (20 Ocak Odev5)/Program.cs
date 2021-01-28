using System;

namespace Generic__20_Ocak_Odev5_
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Alex de Souza", 10);
            myDictionary.Add("Gökhan Gönül", 77);
            myDictionary.Add("Caner Erkin", 88);
            myDictionary.Add("Luiz Gustavo", 20);


            for (int i = 0; i < myDictionary.Length; i++)
            {
                Console.WriteLine("Ad:" + " " + myDictionary.key[i] + " " + "Numara:" + myDictionary.value[i]);
            }

            foreach (var f in myDictionary.key)
            {
                Console.WriteLine(f);
            }

            foreach (var b in myDictionary.value)
            {
                Console.WriteLine(b);
            }
        }
    }
} 
