﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_else_if
{
	class Program
	{
		static void Main(string[] args)
		{


			// Kullanicidan alinan iki sayinin büyük kücük. mod toplam çarpma çıkarma işlemlerini gösteren konsol programını tasarlayınız.
			// Çıkarma işlemi daima büyük olan sayıdan gerçekleşmesi istenmektedir.
			// Hangi sayının büyük olduğunu konsolda gösterilsin.
			// Programcılar olarak program geliştirirken daima kafamızda kolaydan zora doğru bir algoritma bir problem kurup çözümlemeye daima devam edelim.

			Console.WriteLine("1.Sayiyi Giriniz:");
			int sayi = int.Parse(Console.ReadLine());

			Console.WriteLine("2.Sayiyi Giriniz:");
			int sayi1 = int.Parse(Console.ReadLine());


			if (sayi <= 0)
			{
				Console.WriteLine("Sayi 0 veya 0'a eşit olamaz");
			}

			if (sayi > sayi1)
			{
				Console.WriteLine($"1.SAYİ DAHA BÜYÜKTÜR {sayi}");
			}
			
			else if (sayi < sayi1)
			{
				Console.WriteLine($"1. sayi ikinci sayidan küçüktür {sayi1}");
			}

			else if(sayi==sayi1)
			{
				Console.WriteLine("Sayilar Eşittir");
			}

			int toplam = sayi + sayi1;
			Console.WriteLine(toplam + "iki sayinin toplamı");

			if (sayi > sayi1)
			{
				int çıkarma = sayi - sayi1;
				Console.WriteLine("Çıkarma işlemi:" + çıkarma);
			}
			else if (sayi < sayi1)
			{
				int çıkarma = sayi1 - sayi;
				Console.WriteLine("Çıkarma İşlemi:" + çıkarma);
			}

			int çarpma = sayi * sayi1;
			Console.WriteLine("Çarpma İşlemi:"+çarpma);
	



			int modAl = sayi % sayi1;

			Console.WriteLine("Modu"+modAl);
			Console.ReadLine();








		}
	}
}
