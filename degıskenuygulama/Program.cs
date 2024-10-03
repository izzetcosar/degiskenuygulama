using System;

namespace degiskenlerleuygulama;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz");
        Console.WriteLine("T.C. Kimlik Numaranız:");

        string Tc = Console.ReadLine();

        Console.WriteLine("Adi");

        string Name = Console.ReadLine();

        Console.WriteLine("soyadı");

        string Lastname = Console.ReadLine();

        Console.WriteLine("Telefon Numarası");

        string Telnum = Console.ReadLine();

        Console.WriteLine("yası");

        string Age = Console.ReadLine();

        Console.WriteLine("ilk aldıgı ürün fiyatı");

        string firstprice = Console.ReadLine();

        int intfp = int.Parse(firstprice);

        Console.WriteLine("İkinci aldigi ürün fiyati");

        string secondprice = Console.ReadLine();

        int intsp = int.Parse(secondprice);

        int toplam = intsp + intfp;

        int indirim = toplam / 10;

        Console.WriteLine($"{Tc} Tc numaralı {Name}{Lastname} isimli kişi için kayıt olusturulmustur.");

        Console.WriteLine($"{Telnum} telefon numarasına mesaji dönerilmiştir");

        Console.WriteLine($"{toplam} toplam harcama karsılıgında kazanılan 10% patika puan miktarı -> {indirim} TL'dir");






    }



}


