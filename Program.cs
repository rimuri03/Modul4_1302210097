using System;
using System.Collections.Generic;
public class KodeBuah
{
    private Dictionary<string, string> kodeBuah = new Dictionary<string, string>()
    {
        {"Apel","A00"},
        {"Aprikot","B00"},
        {"Alpukat","C00"},
        {"Pisang","D00"},
        {"Paprika","E00"},
        {"Blackberry","F00"},
        {"Ceri","H00"},
        {"Kelapa","I00"},
        {"Jagung","J00"},
        {"Kurma","K00"},
        {"Durian","L00"},
        {"Anggur","M00"},
        {"Melon","M00"},
        {"Semangka","O00"},

    };
    public string getKodeBuah (string namabuah)
    {
        if (kodeBuah.ContainsKey(namabuah))
        {
            return kodeBuah[namabuah];
        }
        else
        {
            return "Kode Buah Tidak ditemukan" ;
        }
    }
}
public class Program
{
    static void Main(string[] args)
    {
        KodeBuah kodebuah = new KodeBuah();

        Console.WriteLine("Kode Buah Apel: " + kodebuah.getKodeBuah("Apel"));
        Console.WriteLine("Kode Buah Aprikot: " + kodebuah.getKodeBuah("Aprikot"));
        Console.WriteLine("Kode Buah Semangka: " + kodebuah.getKodeBuah("Semangka"));
        Console.WriteLine("Kode Buah Anggur: " + kodebuah.getKodeBuah("Anggur"));
        Console.WriteLine("Kode Buah Strawberry: " + kodebuah.getKodeBuah("Strawberry"));
    }
}