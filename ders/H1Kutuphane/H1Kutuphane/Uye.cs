using System;

namespace H1Kutuphane
{
	public class Uye
	{
		int uyeNo;
		string ad;
		string adres;
		public Uye ()
		{
		}
		public Uye (int uyeNo, string ad, string adres)
		{
			this.uyeNo = uyeNo;
			this.ad = ad;
			this.adres = adres;
		}
		public int UyeNo {
			get {
				return this.uyeNo;
			}
			set {
				uyeNo = value;
			}
		}

		public string Ad {
			get {
				return this.ad;
			}
			set {
				ad = value;
			}
		}

		public string Adres {
			get {
				return this.adres;
			}
			set {
				adres = value;
			}
		}
		public override string ToString ()
		{
			return string.Format ("[Uye: UyeNo={0}, Ad={1}, Adres={2}]", UyeNo, Ad, Adres);
		}
		
	}
}

