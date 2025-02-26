namespace Sube2.EmlakciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ev evim = new Ev();
            evim.alan = 100;
            evim.odasayisi = 2;
            evim.katno = 1;
            evim.semt = "Gazi";

            Ev evim2 = new Ev();
            evim2.alan = 120;
            evim2.odasayisi = 3;
            evim2.katno = 5;
            evim2.semt = "Gazi";

            //  Console.WriteLine(evim.EvBilgileri());

            string marka;
            string islemci;
            string ekrankarti;
            int ram;

            Bilgisayar pc1 = new Bilgisayar();
            pc1.marka = "INTEL";
            pc1.islemci = "INTEL-Core Ultra 5 245KF";
            pc1.ekrankarti = "INTEL-Intel ARC B580";
            pc1.ram = 16;

            Bilgisayar pc2 = new Bilgisayar();
            pc2.marka = "MSI";
            pc2.islemci = "INTEL-i5 14400F";
            pc2.ekrankarti = "ASUS-GeForce RTX 5070 Ti";
            pc2.ram = 64;

            Console.WriteLine(pc1.BilgisayarBilgileri());
            Console.WriteLine(pc2.BilgisayarBilgileri());
        }
    }





}


































/*
 
 || 3.Hafta ||

            Ev evim = new Ev(); // Ev classından bir nesne türetildi.
             evim: Nesnenin referansı. Nesneye ulaşmak için kullanılır.
            Ev: Referansın veri tipi. Her class aynı zamanda bir veri tipidir.
            new: Nesne üretmek için kullanılan anahtar sözcük. evim isimli referans stackte depolanır. -Nesneler HEAP bölgesindde oluşturulur
            Referanslar STACK bölgesinde - Nesneler HEAP bölgesinde oluşturulur
https://prnt.sc/b6JX7Jmwrxpl

Erişim belirleyiciler (Access Modifiers) -> Private, Public, internal, ...


Bir classtan birden fazla nesne üretilebilir

DRY: Don't Repeat Yourself (Kendini tekrar etme)
 */