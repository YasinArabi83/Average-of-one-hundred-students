//یاسین عربی
//نمره صد دانشجو
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace StudentGrades
{

    class Program
    {
        static void Main(string[] args)
        {

            int[] pishrafte1 = new int[100]; int[] tafsir = new int[100];
            int[] riazi = new int[100]; int[] kargah = new int[100];
            int[] zaban = new int[100]; int[] pishrafte2 = new int[100];
            int[] shay_garai = new int[100]; int[] tarbiat_badani = new int[100];
            int[] system_amle = new int[100]; int[] Algorithm = new int[100];
            Random rand = new Random();

            int[][] Score = new int[][] { pishrafte1, tafsir, riazi, kargah, zaban, pishrafte2, shay_garai, tarbiat_badani, system_amle, Algorithm };

            for (int i = 0; i < Score.Length; i++)
            {
                for (int j = 0; j < Score[i].Length; j++)
                {
                    Score[i][j] = rand.Next(0, 21);

                }
            }

            string[] name = new string[100];
            name[0] = "hossein"; name[1] = "ali";
            name[2] = "mohsen"; name[3] = "bahram";
            name[4] = "kazem"; name[5] = "behrooz";
            name[6] = "amir"; name[7] = "sina";
            name[8] = "hasan"; name[9] = "mohammad";
            name[10] = " eskandar"; name[11] = " reza";
            name[12] = "mahram"; name[13] = "bahram";
            name[14] = " shahram"; name[15] = "shadmehr";
            name[16] = " ebi"; name[17] = "korosh";
            name[18] = "ehsan"; name[19] = "ahmad";
            name[20] = " salar"; name[21] = "sorena";
            name[22] = "avesta"; name[23] = "ramin";
            name[24] = "alireza"; name[25] = "mobin";
            name[26] = "saeid"; name[27] = "moein";
            name[28] = "mehdi"; name[29] = "sadegh";
            name[30] = "jalal"; name[31] = "bohlol";
            name[32] = "masood"; name[33] = "erfan";
            name[34] = "majid"; name[35] = "omid";
            name[36] = "mehrdad"; name[37] = "hesam";
            name[38] = "iliya"; name[39] = "ashkan";
            name[40] = "bardiya"; name[41] = "benjamin";
            name[42] = "babak"; name[43] = "behnam";
            name[44] = "pooya"; name[45] = "khosro";
            name[46] = "daryoosh"; name[47] = "sirvan";
            name[48] = "sadra"; name[49] = "sobhan";
            name[50] = "shahab"; name[51] = "zahra";
            name[52] = "fatemeh"; name[53] = "reyhaneh";
            name[54] = "homa"; name[55] = "sara";
            name[56] = "mona"; name[57] = "azita";
            name[58] = "nazanin"; name[59] = "niloofar";
            name[60] = "nastaran"; name[61] = "helen";
            name[62] = "asal"; name[63] = "ava";
            name[64] = "ghazal"; name[65] = "hana";
            name[66] = "mersana"; name[67] = "aseman";
            name[68] = "darya"; name[69] = "donya";
            name[70] = "baran"; name[71] = "ayda";
            name[72] = "maedeh"; name[73] = "negar";
            name[74] = "negin"; name[75] = "samira";
            name[76] = "elnaz"; name[77] = "elham";
            name[78] = "narges"; name[79] = "ameneh";
            name[80] = "zeynab"; name[81] = "nasrin";
            name[82] = "mahnaz"; name[83] = "bahar";
            name[84] = "niki"; name[85] = "sadaf";
            name[86] = "nahid"; name[87] = "akram";
            name[88] = "james"; name[89] = "ben";
            name[90] = "kevin"; name[91] = "marco";
            name[92] = "selena"; name[93] = "antony";
            name[94] = "taylor"; name[95] = "alan";
            name[96] = "maria"; name[97] = "roze";
            name[98] = "harry"; name[99] = "nicolas";

            double[] gpa1 = new double[99];
            double[] gpa2 = new double[99];
            double[] gpa3 = new double[99];
            double[] gpa4 = new double[99];

            void adadaval(int num)
            {
                int sum = 0;

                for (int i = 1; i < num; i++)
                {

                    if (num % i == 0)
                    {
                        sum++;
                    }

                }
                if (sum < 2 && num > 1)
                    Console.WriteLine(num);
            }

            void grade(double gpa)
            {
                switch (gpa)
                {
                    case double n when (n >= 17 && n <= 20):
                        Console.WriteLine("A");
                        break;
                    case double n when (n >= 15 && n < 17):
                        Console.WriteLine("B");
                        break;
                    case double n when (n >= 13 && n < 15):
                        Console.WriteLine("C");
                        break;
                    case double n when (n >= 10 && n < 13):
                        Console.WriteLine("D");
                        break;
                    case double n when (n >= 7 && n < 10):
                        Console.WriteLine("E");
                        break;
                    case double n when (n >= 3 && n < 7):
                        Console.WriteLine("F");
                        break;
                    case double n when (n >= 0 && n < 3):
                        Console.WriteLine("G");
                        break;

                }
            }

            double GPA(int x1, int z1, int x2, int z2, int x3, int z3, int x4, int z4, int x5, int z5,
                        int x6, int z6, int x7, int z7, int x8, int z8, int x9, int z9, int x10, int z10)
            {

                double result = ((x1 * z1) + (x2 * z2) + (x3 * z3) + (x4 * z4) + (x5 * z5) + (x6 * z6) + (x7 * z7) + (x8 * z8) + (x9 * z9) + (x10 * z10))
                  / (z1 + z2 + z3 + z4 + z5 + z6 + z7 + z8 + z9 + z10);
                return result;
            }

            void list(double[] gpa)
            {
                List<(string, double)> moadel = new List<(string, double)>();
                for (int i = 0; i < gpa.Length; i++)
                {
                    moadel.Add((name[i], gpa[i]));
                }
                moadel.Sort((x, y) => x.Item2.CompareTo(y.Item2));
                foreach (var tuple in moadel)
                {
                    Console.WriteLine(tuple.Item1 + ": " + tuple.Item2);
                }
            }

            void write()
            {
                Console.WriteLine("Choose one of the following(enter number):");
                Console.WriteLine("1.kol moadel ha");
                Console.WriteLine("2.moadel kol");
                Console.WriteLine("3.moadel omomi");
                Console.WriteLine("4.moadel nime takhsssi");
                Console.WriteLine("5.moadel takhsssi");
                Console.WriteLine("6.adad aval nomarat");
                Console.WriteLine("7.grade daneshjo");
                Console.WriteLine("8.exit");
            }

            int read()
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                return choice;
            }




            void result(int x)
            {   //1.kol moadel ha
                if (x == 1)
                {
                    double[] kol = new double[100];
                    double[] omomi = new double[100];
                    double[] nime_takhsssi = new double[100];
                    double[] takhsssi = new double[100];

                    for (int i = 0; i < 99; i++)
                    {
                        kol[i] = GPA(pishrafte1[i], 3, tafsir[i], 1, riazi[i], 2, kargah[i], 1, zaban[i], 2, pishrafte2[i], 3, shay_garai[i],
                             3, tarbiat_badani[i], 1, system_amle[i], 3, Algorithm[i], 3);

                        omomi[i] = GPA(pishrafte1[i], 0, tafsir[i], 1, riazi[i], 2, kargah[i], 1, zaban[i], 2, pishrafte2[i], 0, shay_garai[i],
                             0, tarbiat_badani[i], 1, system_amle[i], 0, Algorithm[i], 0);

                        nime_takhsssi[i] = GPA(pishrafte1[i], 0, tafsir[i], 0, riazi[i], 0, kargah[i], 0, zaban[i], 0, pishrafte2[i], 0, shay_garai[i],
                             0, tarbiat_badani[i], 0, system_amle[i], 3, Algorithm[i], 3);

                        takhsssi[i] = GPA(pishrafte1[i], 0, tafsir[i], 0, riazi[i], 0, kargah[i], 0, zaban[i], 0, pishrafte2[i], 0, shay_garai[i],
                             0, tarbiat_badani[i], 0, system_amle[i], 3, Algorithm[i], 3);

                    }

                    List<(string, double, double, double, double)> ScoreList = new List<(string, double, double, double, double)>();
                    for (int i = 0; i < 99; i++)
                    {
                        ScoreList.Add((name[i], kol[i], omomi[i], nime_takhsssi[i], takhsssi[i]));
                    }
                    Console.WriteLine(" kol | omomi | nime_takhsssi | takhsssi");
                    foreach (var tuple in ScoreList)
                    {
                        Console.WriteLine(tuple.Item1 + ": " + tuple.Item2 + " | " + tuple.Item3 + " | " + tuple.Item4 + " | " + tuple.Item5);
                    }
                }

                //2.moadel kol
                if (x == 2)
                {
                    for (int i = 0; i < 99; i++)
                    {
                        gpa1[i] = GPA(pishrafte1[i], 3, tafsir[i], 1, riazi[i], 2, kargah[i], 1, zaban[i], 2, pishrafte2[i], 3, shay_garai[i],
                               3, tarbiat_badani[i], 1, system_amle[i], 3, Algorithm[i], 3);

                    }
                    list(gpa1);
                }

                //3.moadel omomi
                else if (x == 3)
                {
                    for (int i = 0; i < 99; i++)
                    {

                        gpa2[i] = GPA(pishrafte1[i], 0, tafsir[i], 1, riazi[i], 2, kargah[i], 1, zaban[i], 2, pishrafte2[i], 0, shay_garai[i],
                             0, tarbiat_badani[i], 1, system_amle[i], 0, Algorithm[i], 0);
                    }
                    list(gpa2);
                }

                //4.moadel nime takhsssi
                else if (x == 4)
                {
                    for (int i = 0; i < 99; i++)
                    {

                        gpa3[i] = GPA(pishrafte1[i], 0, tafsir[i], 0, riazi[i], 0, kargah[i], 0, zaban[i], 0, pishrafte2[i], 0, shay_garai[i],
                             0, tarbiat_badani[i], 0, system_amle[i], 3, Algorithm[i], 3);
                    }
                    list(gpa3);
                }

                //5.moadel takhsssi
                else if (x == 5)
                {
                    for (int i = 0; i < 99; i++)
                    {

                        gpa4[i] = GPA(pishrafte1[i], 0, tafsir[i], 0, riazi[i], 0, kargah[i], 0, zaban[i], 0, pishrafte2[i], 0, shay_garai[i],
                             0, tarbiat_badani[i], 0, system_amle[i], 3, Algorithm[i], 3);
                    }
                    list(gpa4);
                }

                //6.adad aval nomarat
                else if (x == 6)
                {
                    for (int i = 0; i < Score.Length; i++)
                    {
                        for (int j = 0; j < Score[i].Length; j++)
                        {
                            adadaval(Score[i][j]);

                        }
                    }
                }

                //7.grade daneshjo
                else if (x == 7)
                {
                    double[] gpa = new double[100];

                    for (int i = 0; i < 99; i++)
                    {
                        gpa[i] = GPA(pishrafte1[i], 3, tafsir[i], 1, riazi[i], 2, kargah[i], 1, zaban[i], 2, pishrafte2[i], 3, shay_garai[i],
                               3, tarbiat_badani[i], 1, system_amle[i], 3, Algorithm[i], 3);
                        Console.Write(name[i] + "  "); grade(gpa[i]);
                    }


                }
            }
            bool exit = false;
            do
            {
                write();
                int x = read();
                result(x);
                if (x == 8)
                    exit = true;
            } while (!exit);
        }
    }
}