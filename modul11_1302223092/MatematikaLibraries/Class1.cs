namespace UtilityLibraries;

public class MatematikaLibraries
{
    public static int FPB(int a, int b)
    {
        return b == 0 ? a : FPB(b, a % b);
    }

    public static int KPK(int a, int b)
    {
        return (a / FPB(a, b)) * b;
    }

    public static String Turunan(int[] persamaan)
    {
        String result = "";
        int first_num;
        for (int i = 0, pangkat = persamaan.Length - 1; i < persamaan.Length - 2; i++, pangkat--)
        {
            first_num = persamaan[i] * pangkat;
            result +=
            (first_num == 1 ? null : (first_num).ToString(" + #; -#; 0")) +
            "x^" + (pangkat - 1 == 1 ? null : (pangkat - 1));
        }
        return (result[1].ToString() == "+" ||
        result[1].ToString() == "-" ? result.Substring(3) : result) +
        persamaan[^2].ToString(" + #; - #;0");
    }

    public static String Integral(int[] persamaan)
    {
        String result = "";
        int first_num;
        for (int i = 0, pangkat = persamaan.Length - i - 1;
        i < persamaan.Length; i++, pangkat--)
        {
            first_num = persamaan[i] / (pangkat + 1);
            result += (first_num == 1 ? null :
            first_num.ToString(" + #; -#; 0")) + "x" + (i == persamaan.Length -
            1 ? null : (pangkat + 1));
        }
        return (result[1].ToString() == "+" ||
        result[1].ToString() == "-") ?
        result.Substring(3) : result + " + C";
    }
}
