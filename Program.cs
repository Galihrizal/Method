using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarasi variabel
            int hasil;

            // membuar objek dari class Calculator
            Calculator calculator = new Calculator();

            // panggil method Penjumlahan
            hasil = calculator.Penjumlahan(10, 2);
            CetakHasil("Hasil Penjumalahan : " + hasil);

            // panggil method Penjumlahan dengan 3 parameter (overload method)
            hasil = calculator.Penjumlahan(10, 2, 3);
            CetakHasil("Hasil Penjumlahan Overload : " + hasil);

            // panggil method Pengurangan
            hasil = calculator.Pengurangan(7, 2);
            CetakHasil("Hasil Pengurangan : " + hasil);

            // panggil static method, langsung dari nama classnya
            hasil = Calculator.Perkalian(5, 2);
            CetakHasil("Hasil Perkalian : " + hasil);

            Console.ReadKey();
        }
        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}
