using System;

namespace H1Kutuphane
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Kitap k1 = new Kitap ("9876546", "Data Structures and Algorithm Analysis in Java", "Mark Allen Weiss", "Bilgisayar");
			//Console.WriteLine (k1.ToString());
			Kitap k2 = new Kitap ("9875468", "Nutuk", "M.K.Atatürk", "Tarih");
			//Console.WriteLine (k1+"\n"+k2);
			k1.ISBN = "987548";
			Uye u1 = new Uye (123, "Şevket Çakır", "Denizli");
			Uye u2 = new Uye (124, "Mustafa Tosun", "Antalya");
			Uye u3 = new Uye (125, "Selahattin Akkaş", "Manisa");
			//Console.WriteLine (u1);
			//Console.WriteLine (u2+"\n"+u3);
			Odunc o1 = new Odunc (k1, u2);
			Odunc o2 = new Odunc (k2, u3);
			//Console.WriteLine (o1);
			//Console.WriteLine (o2);
			Kutuphane k = new Kutuphane ();
			k.uyeEkle (u1);
			k.uyeEkle (u2);
			k.uyeEkle (u3);
			k.uyeleriListele ();
			k.kitapEkle (k1);
			k.kitapEkle (k2);
			k.oduncEkle (u2, k1);
			k.oduncEkle ("Şevket Çakır", "Nutuk");
			k.oduncListele ();
		}
	}
}
