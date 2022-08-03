//---------------------metot overloading----------------

string sayi = "999";

bool sonuc = int.TryParse(sayi, out int result);

if(sonuc)
{
    Console.WriteLine("Başarılı!");
    Console.WriteLine(result);
}
else 
Console.WriteLine("Başarısız!");


metotlar instance = new metotlar();
instance.Topla(2,3,out int yazdirilacaksonuc);

Console.WriteLine(yazdirilacaksonuc);


int ifade = 8888;
instance.ekranayazdir(Convert.ToString(ifade));
instance.ekranayazdir(ifade);

//-------------metot overloading--------------------

//fonksiyonun imzasını değiştirerek fonksiyonu birden fazla kullanabiliyoruz
// metot imzasına göre hangi parametreli metotu kullanacağına karar verir
//instance.ekranayazdir(ifade); int parametreli metotu kullandı

// metot_adi + parametre sayısı + parametre tipi   ====> bu 3 bilgi aynı olmamalı, aynı olduğunda işlem yapmaz
// erişim belirteci metot imzasına dahil değildir. public, private
//geri dönüş tipinin de etkisi yoktur. void, int, string

instance.ekranayazdir("buse","alp");


class metotlar
{
    public void Topla ( int a , int b, out int toplam)
    {
        toplam = a + b;
    }

    public void ekranayazdir(string veri)
{
    Console.WriteLine(veri);
}

    public void ekranayazdir(int veri)
{
    Console.WriteLine(veri);;
}
    public void ekranayazdir(string veri1, string veri2) ///overload metot
{
    Console.WriteLine(veri1+veri2);;
}
    
}

