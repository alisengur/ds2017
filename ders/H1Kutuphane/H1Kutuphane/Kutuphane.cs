using System;
using System.Collections;

namespace H1Kutuphane
{
	public class Kutuphane
	{
		ArrayList kitaplar;
		ArrayList uyeler;
		ArrayList oduncler;
		public Kutuphane ()
		{
			kitaplar = new ArrayList ();
			uyeler = new ArrayList ();
			oduncler = new ArrayList ();
		}
		public void uyeEkle(Uye u)
		{
			uyeler.Add (u);
		}
		public void uyeleriListele()
		{
			//for (int i = 0; i < uyeler.Count; i++) {
			//	Console.WriteLine (uyeler[i]);
			//}
			foreach(Uye u in uyeler)
				Console.WriteLine (u);
		}
		public Uye uyeBul(string uyeAdi)
		{
			foreach (Uye u in uyeler)
				if (u.Ad.Equals (uyeAdi))
					return u;
			return null;
		}
		public void kitapEkle(Kitap kitap)
		{
			kitaplar.Add (kitap);
		}
		public Kitap kitapBul(string kitapAdi)
		{
			foreach (Kitap k in kitaplar)
				if (k.Ad.Equals (kitapAdi))
					return k;
			return null;
		}
		public void oduncListele()
		{
			foreach(Odunc o in oduncler)
				Console.WriteLine (o);
		}
		public void oduncEkle(Uye u, Kitap k)
		{
			oduncler.Add (new Odunc (k, u));
		}
		public void oduncEkle(string uyeAdi, string kitapAdi)
		{
			Uye u = uyeBul (uyeAdi);
			Kitap k = kitapBul (kitapAdi);
			if(u==null || k==null)
				throw new Exception ("Üye veya kitap bulunamadı");
			oduncEkle (u, k);
		}
	}
}

