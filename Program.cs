namespace KurucuFonksiyonlar;

class Program
{
    static void Main(string[] args)
    {

        Calısan Calısan1 =new Calısan("Bedirhan","Gökkaya",1,"Yazılımcı.");

        Console.WriteLine("-------------------Çalışan 1----------------------");
        Calısan1.CalısanBilgileri();
        Console.WriteLine();

        Calısan Calısan2 =new Calısan("Selin","Gürtürk",2,"Genetikçi");

        Console.WriteLine("-------------------Çalışan 2----------------------");        
        Calısan2.CalısanBilgileri();
        Console.WriteLine();

        Console.WriteLine("-------------------Çalışan 3----------------------"); 
        Calısan Calısan3 = new Calısan("Umut Yasin", "Gürtürk");
        Calısan3.CalısanBilgileri();
    }
}


class Calısan
{
    public string Ad;
    public string Soyad;
    public int No; 
    public string Departman;

    //Kurucu Fonksiyon
    public Calısan(string ad, string Soyad, int no, string Departman) //kurucu fonksiyonlar class adı ile aynı olmalıdır, geri dönüş tipi yoktur ve Public Olmak ZORUNDADIR.
    {
        this.Ad=ad;
        this.Soyad=Soyad;
        this.No=no;
        this.Departman=Departman;
    }

    public Calısan(string ad, string Soyad)//Kurucu Metotlar overload edilebilir
    {
        this.Ad=ad;
        this.Soyad=Soyad;
    } 

    public void CalısanBilgileri()
    {
        Console.WriteLine("Çalışan Adı: "+Ad);
        Console.WriteLine("Çalışan Soaydı: "+Soyad);
        Console.WriteLine("Çalışan No'su: "+No);
        Console.WriteLine("Çalışan Depratmanı: "+Departman);
    }
}
