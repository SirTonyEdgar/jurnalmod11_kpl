using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        UtilityLibraries.MatematikaLibraries mat = new UtilityLibraries.MatematikaLibraries();

        int fpb = UtilityLibraries.MatematikaLibraries.FPB(60, 45);

        Console.WriteLine("Hasil FPB: ");
        Console.WriteLine(fpb);

        int kpk = UtilityLibraries.MatematikaLibraries.FPB(12, 8);

        Console.WriteLine("Hasil KPK: ");
        Console.WriteLine(kpk);

        string turun = UtilityLibraries.MatematikaLibraries.Turunan([1, 4, -12, 9]);

        Console.WriteLine("Hasil Turunan: ");
        Console.WriteLine(turun);

        string integral = UtilityLibraries.MatematikaLibraries.Integral([4, 6, -12, 9]);

        Console.WriteLine("Hasil Integral: ");
        Console.WriteLine(integral);
    }
}