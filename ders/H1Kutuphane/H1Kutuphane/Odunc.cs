using System;

namespace H1Kutuphane
{
	public class Odunc
	{
		Kitap kitap;
		Uye uye;
		DateTime zaman;
		public Odunc (Kitap kitap, Uye uye)
		{
			this.kitap = kitap;
			this.uye = uye;
			this.zaman = DateTime.Now;
		}
		
		public Odunc ()
		{
			this.zaman = DateTime.Now;
		}
		public Kitap Kitap {
			get {
				return this.kitap;
			}
			set {
				kitap = value;
			}
		}

		public Uye Uye {
			get {
				return this.uye;
			}
			set {
				uye = value;
			}
		}
		public DateTime Zaman {
			get {
				return this.zaman;
			}
		}
		public override string ToString ()
		{
			return string.Format ("[Odunc: Kitap={0}, Uye={1}, Zaman={2}]", Kitap.Ad, Uye.Ad, Zaman);
		}
		
	}
}

