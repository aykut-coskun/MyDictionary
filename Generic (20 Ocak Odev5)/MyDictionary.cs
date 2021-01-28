using System;
using System.Collections.Generic;
using System.Text;

namespace Generic__20_Ocak_Odev5_
{
    class MyDictionary<Fb, Bf>
    {
        Fb[] fArray;
        Bf[] bArray;

        //Constructor bloğu çalışır ve newlediğimiz için yeni dizi oluşturur.
        public MyDictionary()
        {
            fArray = new Fb[0];
            bArray = new Bf[0];
        }

        public void Add(Fb f, Bf b)
        {
            Fb[] tempKeyArray = fArray;  //temparray tanımlıyoruz. Constructor bloğunda newlediğimiz array'i aktarıyoruz. temparraya emanet ettik dizimizi
            Bf[] tempValueArray = bArray;
            fArray = new Fb[fArray.Length + 1]; // yeni tanımladığımız dizi constructorda oluşturduğumuz array'in uzunluğunun bir fazlası
            bArray = new Bf[bArray.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++) //diyelimki temparray 2 elemanlı yeni oluşturduğumuz array 3 elemanlı olur. 
            {                                             //Yeni arrayin ilk 2 elemanı temparraydan gelir son elemana verilen değer atanır
                fArray[i] = tempKeyArray[i];
            }

            fArray[fArray.Length - 1] = f;   //yeni arrayin son elemanını da eklenen değer oluşturur.

            for (int j = 0; j < tempValueArray.Length; j++)
            {
                bArray[j] = tempValueArray[j];
            }

            bArray[bArray.Length - 1] = b;
        }

        public int Length  // farrayin uzunluğu döner
        {
            get { return fArray.Length; }
        }

        public Fb[] key
        {
            get { return fArray; }
        }
        public Bf[] value
        {
            get { return bArray; }
        }

    }
}
