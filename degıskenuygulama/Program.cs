using System;

namespace degiskenlerleuygulama;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz");
        Console.Write("T.C. Kimlik Numaranız:");

        string Tc = Console.ReadLine();

        Console.Write("Adi:");

        string Name = Console.ReadLine();

        Console.Write("soyadı:");

        string Lastname = Console.ReadLine();

        Console.Write("Telefon Numarası:");

        string Telnum = Console.ReadLine();

        //matematiksel işlem yapmadıgımız için string veri tipini kullandım.

        Console.Write("yası:");

        string Age = Console.ReadLine();

        Console.Write("ilk aldıgı ürün fiyatı:");

        string firstprice = Console.ReadLine();

        int intfp = int.Parse(firstprice);

        Console.Write("İkinci aldigi ürün fiyati:");

        string secondprice = Console.ReadLine();

        int intsp = int.Parse(secondprice);

        //matematiksel işlem uygulayacagimiz için string degiskenini int degiskenine cevirdim.

        int toplam = intsp + intfp;

        int indirim = toplam / 10;

        Console.WriteLine($"{Tc} Tc numaralı {Name}{Lastname} isimli kişi için kayıt olusturulmustur.");

        Console.WriteLine($"{Telnum} telefon numarasına mesaji dönerilmiştir");

        Console.WriteLine($"{toplam} toplam harcama karsılıgında kazanılan 10% patika puan miktarı -> {indirim} TL'dir");






    }



}


