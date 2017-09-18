using System;

namespace H1Kutuphane
{
	public class Kitap
	{
		string isbn;
		public String ISBN {
			get { return isbn; }
			set { isbn = value; }
		}
		string ad;
		string yazar;
		string alan;

		public string Ad {
			get {
				return this.ad;
			}
			set {
				ad = value;
			}
		}

		public string Yazar {
			get {
				return this.yazar;
			}
			set {
				yazar = value;
			}
		}

		public string Alan {
			get {
				return this.alan;
			}
			set {
				alan = value;
			}
		}
		public Kitap(string isbn, string ad, string yazar, string alan)
		{
			this.isbn = isbn;
			this.ad = ad;
			this.yazar = yazar;
			this.alan = alan;
		}
		public Kitap ()
		{}

		public override string ToString ()
		{
			return string.Format ("ISBN:{0}, Adı:{1}, Yazarı:{2}, Alan:{3}",isbn,ad,yazar,alan);
		}
	}
}

