using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace tugasalgordata1
{
	internal class Program
	{

		static void Main(string[] args)
		{
			no12();
			
		}


		static void o1()
		{
			Console.Write("Input angka hari (1-7): ");
			int q;
			q = int.Parse(Console.ReadLine());

			switch (q)
			{
				case 1:
					Console.WriteLine("Senin");
					break;

				case 2:
					Console.WriteLine("Selasa");
					break;

				case 3:
					Console.WriteLine("Rabu");
					break;

				case 4:
					Console.WriteLine("Kamis");
					break;

				case 5:
					Console.WriteLine("Jumat");
					break;

				case 6:
					Console.WriteLine("Sabtu");
					break;


				case 7:
					Console.WriteLine("Ahad");
					break;

				default:
					Console.WriteLine("tidak tersedia");
					break;

			}

			Console.ReadLine();
		}
		static void o2()
		{
			String n, golongan;

			int kerja, gaji;// var gaji adalah gaji tanpa uang lembur
			String jk;//untuk variabel tampung jenis kelamin
			float gajitota; //gajitota = gaji total
			String jenkel;//untuk tampung bapak bu bersdasarkan jenis kelamin
			//-------------------------------------
			Console.Write("Nama Karyawan    = ");
			n = Console.ReadLine();
			//--------------------------------------
			Console.Write("Jenkel (l/w)   =");
		jenkel:
			jk = Console.ReadLine();

			if (jk.Equals("l"))
			{
				jenkel = "bapak";
			}
			else if (jk.Equals("w"))
			{
				jenkel = "bu";
			}
			else
			{
				Console.Write("ayo input gender dengan benar ( l / w )");

				goto jenkel;
			}
		//------------------------------------------
		golongan:
			Console.Write("golongan    = ");
			golongan = Console.ReadLine();
			if (golongan.Equals("A") || "B".Equals(golongan) || golongan.Equals("C") || "D".Equals(golongan))
			{
				goto kerja;
			}
			else
			{
				Console.WriteLine("tolong input golongan dengan benar (A/B/C/D)");
				goto golongan;

			}
		//-------------------------------------
		kerja:
			Console.Write("Jam kerja perminggu    =  ");
			kerja = int.Parse(Console.ReadLine());

			switch (golongan)
			{
				case ("A"):
					gaji = 500000;
					if (kerja > 48)// >=
					{
						gajitota = (kerja - 48) * 4000 + gaji;
						Console.WriteLine(jenkel + " " + n + " dapat gaji " + String.Format("{0:n0}", gajitota) + "");
					}
					else if (kerja <= 48)
					{
						gajitota = gaji;
						Console.WriteLine(jenkel + " " + n + " dapat gaji " + String.Format("{0:n0}", gajitota) + "");
					}
					break;

				case ("B"):
					gaji = 700000;
					if (kerja > 48)
					{
						gajitota = (kerja - 48) * 4000 + gaji;
						Console.WriteLine(jenkel + " " + n + " dapat gaji " + String.Format("{0:n}", gajitota) + "");
					}
					else if (kerja <= 48)
					{
						gajitota = gaji;
						Console.WriteLine(jenkel + " " + n + " dapat gaji " + String.Format("{0:n0}", gajitota) + "");
					}
					break;
				case ("C"):
					gaji = 800000;
					if (kerja > 48)
					{
						gajitota = (kerja - 48) * 4000 + gaji;
						Console.WriteLine(jenkel + " " + n + " dapat gaji " + String.Format("{0:n}", gajitota) + "");
					}
					else if (kerja <= 48)
					{
						gajitota = gaji;
						Console.WriteLine(jenkel + " " + n + " dapat gaji " + String.Format("{0:n0}", gajitota) + "");
					}
					break;
				case ("D"):
					gaji = 1000000;
					if (kerja >= 48)
					{
						gajitota = (kerja - 48) * 4000 + gaji;
						Console.WriteLine(jenkel + " " + n + " dapat gaji " + String.Format("{0:n}", gajitota) + "");
					}
					else if (kerja < 48)
					{
						gajitota = gaji;
						Console.WriteLine(jenkel + " " + n + " dapat gaji " + String.Format("{0:n0}", gajitota) + "");
					}
					break;
				default:

					break;
			}

			Console.ReadLine();

		}
		static void o3()
		{

			double ut, ua, tuga, nilaiangka;
			nl:
			Console.Write("Nilai Ulangan tengah semester=    ");
			ut = int.Parse(Console.ReadLine());
			Console.Write("Nilai Ulangan akhir semester=    ");
			ua = int.Parse(Console.ReadLine());
			Console.Write("nilai tugas kuliah keseluruhan=    ");
			tuga = int.Parse(Console.ReadLine());

			nilaiangka = (0.2 * ut) + (0.4 * ua) + (0.4 * tuga);

			if (ut <= -1 || ut > 100 || ua <= -1 || ua > 100 || tuga <= -1 || tuga > 100)

			{
				Console.WriteLine("nilai terbesar 100 dan terkecil 0");
				goto nl;
			}
			else if (nilaiangka >= 87 && nilaiangka <= 100)
			{
				Console.WriteLine("Nilai A");
			}
			else if (nilaiangka >= 75 && nilaiangka < 87)
			{
				Console.WriteLine("Nilai B");
			}
			else if (nilaiangka >= 65 && nilaiangka < 75)
			{
				Console.WriteLine("Nilai C");
			}
			else if (nilaiangka >= 50 && nilaiangka <= 64)
			{
				Console.WriteLine("Nilai D");
			}
			else if (nilaiangka >= 0 && nilaiangka <= 49)
			{
				Console.WriteLine("Nilai E");
			}

			Console.ReadLine();
		}
		static void o4()
		{
			int n4, ln, l; //n adalah input user, ln adalah nilai tinggi dan l adalah nilai lebar
						   //4 adalah untuk variabel nomor 4
			Console.WriteLine("Nilai sisi bujur sangkar :  ");
			n4 = int.Parse(Console.ReadLine());
			for (ln = 0; ln < n4; ln++)
			{

				for (l = 0; l < n4; l++)
				{
					Console.Write("* " );
				}
				Console.WriteLine("");

			}

			Console.ReadLine();
		}
		static void o5()
		{

			int tg, la, tn, ln;
			Console.Write("lebar :" ) ;
			la = int.Parse(Console.ReadLine());
			Console.Write("tinggi :" );
			tg = int.Parse(Console.ReadLine());
			for (tn = 0; tn < tg; tn++)
			{

				for (ln = 0; ln < la; ln++)
				{
					Console.Write("*");
				}
				Console.WriteLine("");

			}



			Console.ReadLine();

		}
		static void o6()
		{
			int tg, tn;

			Console.Write("tinggi segitiga: ");
			tg = int.Parse(Console.ReadLine());
			tn = 1;
			while (tn <= tg)
			{
				for(int n = 1; n <= tn; n++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
				tn++;


			}

			Console.ReadLine();

		}
		static void o7()
		{
			int tg, tingg;

			
			Console.Write("tinggi segitiga: ");
			tg = int.Parse(Console.ReadLine());
		  
			for (tingg = 1; tingg <= tg; tingg++)
			{

				int a;
				for (a = tg; a >= tingg; a--)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}
		static void o8()
		{
			int tn, nc, a, c, f; // tn = tinggi segitiga, nc = nilai spasi di segitiga
			Console.Write("tinggi segitiga =");
			tn = int.Parse(Console.ReadLine());
			nc = tn - 1;
			for (a = 1; a <= tn; a++)
			{ 
				for (c = a; c <= nc; c++)
				{ 
					Console.Write(" ");
				}
				for (f = 0; f <= (a * 2) - 2; f++)
				{ 
					Console.Write("*");
				}
				Console.WriteLine(); 
			}
			Console.ReadLine();
		}
	
		static void o9()
		{
			int tn, nc, tbintang, a; // tn = tinggi segitiga, nc = nilai spasi di segitiga
			Console.Write("tinggi segitiga = ");
			tn = int.Parse(Console.ReadLine());
			tbintang = ( ( tn - 1 ) * 2) + 1; nc = 0;
			for (a = 0; a < tn; a++)
			{
				for (int c = 0; c < nc; c++)
				{
					Console.Write(" ");
				}
				for (int f = 0; f < tbintang; f++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
				nc += 2;
				tbintang -= 2;
			}
			Console.ReadLine();
		}
		static void no10()
		{
			int tg, tn;

			Console.Write("tinggi : ");
			tg = int.Parse(Console.ReadLine());
			tn = 1;

			do
			{
				for (int n = 1; n <= tn; n++)
				{
					Console.Write(tn);
				}
				Console.WriteLine("");
				tn++;


			} while (tn <= tg);

            Console.ReadLine();
		}
		static void no11()
		{
			int tg, tn;

			Console.Write("tinggi : ");
			tg = int.Parse(Console.ReadLine());
			tn = 1;
			while (tn <= tg)
			{
				for (int n = 1; n <= tn; n++)
				{
					Console.Write(n);
				}
				Console.WriteLine(  );
				tn++;


			}
			Console.ReadLine();
		}
		static void no12()
		{
            int tg, tn, n, a;
			a = 1;
            Console.Write("tinggi : ");
            tg = int.Parse(Console.ReadLine());
            tn = 1;
            while (tn <= tg)
            {
                for (n = 1; n <= tn; n++)
                {
                    Console.Write(a+" ");
					a++;
                }
                Console.WriteLine();
                tn++;


            }
            Console.ReadLine();
        }

	} 
}
