using System;

namespace Kriptografi
{
    class Program
    {
        [STAThread()]
        static void Main(string[] args)
        {
            string plaintxt, chipertxt;
        awal:
            Console.WriteLine("*************************** Kriptografi Sederhana ****************************");
            Console.WriteLine("****************************** By Adityasmutki *******************************");
            Console.WriteLine();
            Console.WriteLine("Pilihan ");
            Console.WriteLine("[1]. Mengenkripsi.");
            Console.WriteLine("[2]. Mendekripsi");
            Console.WriteLine("[3]. Keluar");
            Console.Write("Pilih : ");
            int.TryParse(Console.ReadLine(), out int Pilih);

            if (Pilih == 1)
            {
                Console.WriteLine();
                Console.Write("Masukan Kalimat : ");
                plaintxt = Console.ReadLine();
                chipertxt = Enkripsi(plaintxt);// memanggil fungsi enkripsi
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Hasil Enkripsi : " + chipertxt);

                TextCopy.Clipboard.SetText(chipertxt);
                Console.WriteLine("\n\nHasil telah tersalin di Clipboard!");

                Console.ReadKey();
                Console.Clear();
                goto awal;
            }
            else if (Pilih == 2)
            {
                Console.WriteLine();
                Console.Write("Masukan Chipertext : ");
                chipertxt = Console.ReadLine();
                if (chipertxt.Length % 8 == 0)
                {
                    plaintxt = Dekripsi(chipertxt);// memanggil fungsi dekripsi
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Hasil Enkripsi : " + plaintxt);

                    Console.WriteLine();
                    Console.WriteLine("Chipertext barhasil di dekripsi");
                    Console.WriteLine();
                    TextCopy.Clipboard.SetText(plaintxt);
                    Console.WriteLine("Hasil telah tersalin di Clipboard!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Panjang chipertext tidak sesuai");
                }
                Console.ReadKey();
                Console.Clear();
                goto awal;
            }
            else if (Pilih == 3)
            {
                Console.WriteLine("\n\nTerimakasih");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Masukan Salah");
                Console.ReadKey();
                Console.Clear();
                goto awal;
            }
        }

        //Function Enkripsi 
        //1. Menukar huruf ke 1 abjad dengan huruf ke 6 dalam abjad
        //2. Menambahan kata jika panjang %8 != 0
        //3. Menukar Huruf kr 1 dengan Huruf Ke 10 setiap 10 karakter
        //4. Menukar Huruf kr 3 dengan Huruf Ke 7 Setiap 10 Karakter
        //5. Menukar Huruf kr 5 dengan Huruf Ke 6 Setiap 10 Karakter
        private static string Enkripsi(string kata)
        {
            char katapecah;
            string hasil = null;
            for (int i = 0; i < kata.Length; i++)//Menukar huruf asli
            {
                katapecah = kata[i];

                switch (katapecah)
                {
                    case 'a':
                        katapecah = 'F';
                        break;
                    case 'b':
                        katapecah = 'G';
                        break;
                    case 'c':
                        katapecah = 'H';
                        break;
                    case 'd':
                        katapecah = 'I';
                        break;
                    case 'e':
                        katapecah = 'J';
                        break;
                    case 'f':
                        katapecah = 'K';
                        break;
                    case 'g':
                        katapecah = 'L';
                        break;
                    case 'h':
                        katapecah = 'M';
                        break;
                    case 'i':
                        katapecah = 'N';
                        break;
                    case 'j':
                        katapecah = 'O';
                        break;
                    case 'k':
                        katapecah = 'P';
                        break;
                    case 'l':
                        katapecah = 'Q';
                        break;
                    case 'm':
                        katapecah = 'R';
                        break;
                    case 'n':
                        katapecah = 'S';
                        break;
                    case 'o':
                        katapecah = 'T';
                        break;
                    case 'p':
                        katapecah = 'U';
                        break;
                    case 'q':
                        katapecah = 'V';
                        break;
                    case 'r':
                        katapecah = 'W';
                        break;
                    case 's':
                        katapecah = 'X';
                        break;
                    case 't':
                        katapecah = 'Y';
                        break;
                    case 'u':
                        katapecah = 'Z';
                        break;
                    case 'v':
                        katapecah = 'A';
                        break;
                    case 'w':
                        katapecah = 'B';
                        break;
                    case 'x':
                        katapecah = 'C';
                        break;
                    case 'y':
                        katapecah = 'D';
                        break;
                    case 'z':
                        katapecah = 'E';
                        break;
                    case 'A':
                        katapecah = 'f';
                        break;
                    case 'B':
                        katapecah = 'g';
                        break;
                    case 'C':
                        katapecah = 'h';
                        break;
                    case 'D':
                        katapecah = 'i';
                        break;
                    case 'E':
                        katapecah = 'j';
                        break;
                    case 'F':
                        katapecah = 'k';
                        break;
                    case 'G':
                        katapecah = 'l';
                        break;
                    case 'H':
                        katapecah = 'm';
                        break;
                    case 'I':
                        katapecah = 'n';
                        break;
                    case 'J':
                        katapecah = 'o';
                        break;
                    case 'K':
                        katapecah = 'p';
                        break;
                    case 'L':
                        katapecah = 'q';
                        break;
                    case 'M':
                        katapecah = 'e';
                        break;
                    case 'N':
                        katapecah = 's';
                        break;
                    case 'O':
                        katapecah = 't';
                        break;
                    case 'P':
                        katapecah = 'u';
                        break;
                    case 'Q':
                        katapecah = 'v';
                        break;
                    case 'R':
                        katapecah = 'w';
                        break;
                    case 'S':
                        katapecah = 'x';
                        break;
                    case 'T':
                        katapecah = 'y';
                        break;
                    case 'U':
                        katapecah = 'z';
                        break;
                    case 'V':
                        katapecah = 'a';
                        break;
                    case 'W':
                        katapecah = 'b';
                        break;
                    case 'X':
                        katapecah = 'c';
                        break;
                    case 'Y':
                        katapecah = 'd';
                        break;
                    case 'Z':
                        katapecah = 'e';
                        break;
                    case '%':
                        katapecah = '`';
                        break;
                    case '&':
                        katapecah = '~';
                        break;
                    case '*':
                        katapecah = '!';
                        break;
                    case '(':
                        katapecah = '@';
                        break;
                    case ')':
                        katapecah = '#';
                        break;
                    case '-':
                        katapecah = '%';
                        break;
                    case '_':
                        katapecah = '&';
                        break;
                    case '=':
                        katapecah = '*';
                        break;
                    case '+':
                        katapecah = '(';
                        break;
                    case '[':
                        katapecah = ')';
                        break;
                    case '{':
                        katapecah = '-';
                        break;
                    case ']':
                        katapecah = '_';
                        break;
                    case '}':
                        katapecah = '=';
                        break;
                    case '|':
                        katapecah = '+';
                        break;
                    case ';':
                        katapecah = '[';
                        break;
                    case ':':
                        katapecah = '{';
                        break;
                    case '"':
                        katapecah = ']';
                        break;
                    case ',':
                        katapecah = '}';
                        break;
                    case '<':
                        katapecah = '|';
                        break;
                    case '.':
                        katapecah = ';';
                        break;
                    case '>':
                        katapecah = ':';
                        break;
                    case '/':
                        katapecah = '"';
                        break;
                    case '?':
                        katapecah = ',';
                        break;
                    case '`':
                        katapecah = '<';
                        break;
                    case '~':
                        katapecah = '.';
                        break;
                    case '!':
                        katapecah = '>';
                        break;
                    case '@':
                        katapecah = '/';
                        break;
                    case '#':
                        katapecah = '?';
                        break;
                    case '$':
                        katapecah = ' ';
                        break;
                    case '1':
                        katapecah = '4';
                        break;
                    case '2':
                        katapecah = '5';
                        break;
                    case '3':
                        katapecah = '6';
                        break;
                    case '4':
                        katapecah = '7';
                        break;
                    case '5':
                        katapecah = '8';
                        break;
                    case '6':
                        katapecah = '9';
                        break;
                    case '7':
                        katapecah = '0';
                        break;
                    case '8':
                        katapecah = '1';
                        break;
                    case '9':
                        katapecah = '2';
                        break;
                    case '0':
                        katapecah = '3';
                        break;
                }
                hasil += katapecah;
            }

            int s = hasil.Length;
            while (s % 8 != 0)//Menambahkan huruf lain agar jumlah huruf pada kalimat menghasilkan sisa bagi 0 jika di bagi 8
            {
                hasil += '$';
                s = hasil.Length;
            }

            int al = 0;
            int ah = hasil.Length - 1;
            System.Collections.Generic.List<char> katanya = new System.Collections.Generic.List<char>();
            for (int i = 0; i < hasil.Length; i++)//memasukan huruf ke dalam list
            {
                katanya.Add(hasil[i]);
            }

            while (al < ah)//menukar urutan huruf
            {
                char temp = katanya[al];
                katanya[al] = katanya[al + 3];
                katanya[al + 3] = temp;

                temp = katanya[al + 1];
                katanya[al + 1] = katanya[al + 2];
                katanya[al + 2] = temp;

                temp = katanya[al + 4];
                katanya[al + 4] = katanya[al + 7];
                katanya[al + 7] = temp;

                temp = katanya[al + 5];
                katanya[al + 5] = katanya[al + 6];
                katanya[al + 6] = temp;
                al = al + 8;
            }

            //hasil = "";
            //for (int i = 0; i < katanya.Count; i++)//
            //{
            //    hasil += katanya[i];
            //}
            return string.Join("", katanya.ToArray()); ;
        }


        //Function Dekripsi 
        //1. Menukar Huruf kr 1 dengan Huruf Ke 10 setiap 10 karakter
        //2. Menukar Huruf kr 3 dengan Huruf Ke 7 Setiap 10 Karakter
        //3. Menukar Huruf kr 5 dengan Huruf Ke 6 Setiap 10 Karakter
        //4. Menukar huruf ke 10 abjad dengan huruf ke 1 dalam abjad
        //5. Mengurangi Panjang Kata jika Huruf terdepan adalah spasi
        private static string Dekripsi(string chipertxt)
        {
            char katapecah;
            string hasil = null;
            int al = 0;
            int ah = chipertxt.Length - 1;
            System.Collections.Generic.List<char> chiperlist = new System.Collections.Generic.List<char>();
            for (int i = 0; i < chipertxt.Length; i++)//Memasukan karakter ke dalam List char
                chiperlist.Add(chipertxt[i]);

            while (al < ah)//menukar posisi huruf / dikembalikan ke posisi semula
            {
                char temp = chiperlist[al];
                chiperlist[al] = chiperlist[al + 3];
                chiperlist[al + 3] = temp;

                temp = chiperlist[al + 1];
                chiperlist[al + 1] = chiperlist[al + 2];
                chiperlist[al + 2] = temp;

                temp = chiperlist[al + 4];
                chiperlist[al + 4] = chiperlist[al + 7];
                chiperlist[al + 7] = temp;

                temp = chiperlist[al + 5];
                chiperlist[al + 5] = chiperlist[al + 6];
                chiperlist[al + 6] = temp;
                al = al + 8;
            }

            chipertxt = string.Join("",chiperlist.ToArray());
            hasil = "";
            char a;
            for (int i = 0; i < chipertxt.Length; i++)//mengurangi tambahan huruf ketika kalimat di enkripsi
            {
                a = chipertxt[i];
                if (a != '$')
                    hasil += a;
            }

            chipertxt = hasil;
            hasil = "";
            for (int i = 0; i < chipertxt.Length; i++)// mengganti huruf enkripsi ke huruf aslinya
            {
                katapecah = chipertxt[i];

                switch (katapecah)
                {
                    case 'F':
                        katapecah = 'a';
                        break;
                    case 'G':
                        katapecah = 'b';
                        break;
                    case 'H':
                        katapecah = 'c';
                        break;
                    case 'I':
                        katapecah = 'd';
                        break;
                    case 'J':
                        katapecah = 'e';
                        break;
                    case 'K':
                        katapecah = 'f';
                        break;
                    case 'L':
                        katapecah = 'g';
                        break;
                    case 'M':
                        katapecah = 'h';
                        break;
                    case 'N':
                        katapecah = 'i';
                        break;
                    case 'O':
                        katapecah = 'j';
                        break;
                    case 'P':
                        katapecah = 'k';
                        break;
                    case 'Q':
                        katapecah = 'l';
                        break;
                    case 'R':
                        katapecah = 'm';
                        break;
                    case 'S':
                        katapecah = 'n';
                        break;
                    case 'T':
                        katapecah = 'o';
                        break;
                    case 'U':
                        katapecah = 'p';
                        break;
                    case 'V':
                        katapecah = 'q';
                        break;
                    case 'W':
                        katapecah = 'r';
                        break;
                    case 'X':
                        katapecah = 's';
                        break;
                    case 'Y':
                        katapecah = 't';
                        break;
                    case 'Z':
                        katapecah = 'u';
                        break;
                    case 'A':
                        katapecah = 'v';
                        break;
                    case 'B':
                        katapecah = 'w';
                        break;
                    case 'C':
                        katapecah = 'x';
                        break;
                    case 'D':
                        katapecah = 'y';
                        break;
                    case 'E':
                        katapecah = 'z';
                        break;
                    case 'f':
                        katapecah = 'A';
                        break;
                    case 'g':
                        katapecah = 'B';
                        break;
                    case 'h':
                        katapecah = 'C';
                        break;
                    case 'i':
                        katapecah = 'D';
                        break;
                    case 'j':
                        katapecah = 'E';
                        break;
                    case 'k':
                        katapecah = 'F';
                        break;
                    case 'l':
                        katapecah = 'G';
                        break;
                    case 'm':
                        katapecah = 'H';
                        break;
                    case 'n':
                        katapecah = 'I';
                        break;
                    case 'o':
                        katapecah = 'J';
                        break;
                    case 'p':
                        katapecah = 'K';
                        break;
                    case 'q':
                        katapecah = 'L';
                        break;
                    case 'r':
                        katapecah = 'E';
                        break;
                    case 's':
                        katapecah = 'N';
                        break;
                    case 't':
                        katapecah = 'O';
                        break;
                    case 'u':
                        katapecah = 'P';
                        break;
                    case 'v':
                        katapecah = 'Q';
                        break;
                    case 'w':
                        katapecah = 'R';
                        break;
                    case 'x':
                        katapecah = 'S';
                        break;
                    case 'y':
                        katapecah = 'T';
                        break;
                    case 'z':
                        katapecah = 'U';
                        break;
                    case 'a':
                        katapecah = 'V';
                        break;
                    case 'b':
                        katapecah = 'W';
                        break;
                    case 'c':
                        katapecah = 'X';
                        break;
                    case 'd':
                        katapecah = 'Y';
                        break;
                    case 'e':
                        katapecah = 'Z';
                        break;
                    case '`':
                        katapecah = '%';
                        break;
                    case '~':
                        katapecah = '&';
                        break;
                    case '!':
                        katapecah = '*';
                        break;
                    case '@':
                        katapecah = '(';
                        break;
                    case '#':
                        katapecah = ')';
                        break;
                    case '%':
                        katapecah = '-';
                        break;
                    case '&':
                        katapecah = '_';
                        break;
                    case '*':
                        katapecah = '=';
                        break;
                    case '(':
                        katapecah = '+';
                        break;
                    case ')':
                        katapecah = '[';
                        break;
                    case '-':
                        katapecah = '{';
                        break;
                    case '_':
                        katapecah = ']';
                        break;
                    case '=':
                        katapecah = '}';
                        break;
                    case '+':
                        katapecah = '|';
                        break;
                    case '[':
                        katapecah = ';';
                        break;
                    case '{':
                        katapecah = ':';
                        break;
                    case ']':
                        katapecah = '"';
                        break;
                    case '}':
                        katapecah = ',';
                        break;
                    case '|':
                        katapecah = '<';
                        break;
                    case ';':
                        katapecah = '.';
                        break;
                    case ':':
                        katapecah = '>';
                        break;
                    case '"':
                        katapecah = '/';
                        break;
                    case ',':
                        katapecah = '?';
                        break;
                    case '<':
                        katapecah = '`';
                        break;
                    case '.':
                        katapecah = '~';
                        break;
                    case '>':
                        katapecah = '!';
                        break;
                    case '/':
                        katapecah = '@';
                        break;
                    case '?':
                        katapecah = '#';
                        break;
                    case '$':
                        katapecah = ' ';
                        break;
                    case '4':
                        katapecah = '1';
                        break;
                    case '5':
                        katapecah = '2';
                        break;
                    case '6':
                        katapecah = '3';
                        break;
                    case '7':
                        katapecah = '4';
                        break;
                    case '8':
                        katapecah = '5';
                        break;
                    case '9':
                        katapecah = '6';
                        break;
                    case '0':
                        katapecah = '7';
                        break;
                    case '1':
                        katapecah = '8';
                        break;
                    case '2':
                        katapecah = '9';
                        break;
                    case '3':
                        katapecah = '0';
                        break;
                }
                hasil += katapecah;
            }
            return hasil;
        }
    }
}
