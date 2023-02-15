using System;
class Program
{
    static bool PrimtalsUndersökarn(int tal)
    {
        for (int i = tal - 1; 1 < i; i--)
        {
            if (tal % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static int AllaPrimtal(int tal)
    {
        int PrimtalNummer = 0;
        for (; tal > 0; tal--)
        {
            if (PrimtalsUndersökarn(tal))
            {
                PrimtalNummer++;
            }
        }
        return PrimtalNummer;
    }
    static void Main()
    {
        Console.WriteLine("Skriv ett tal så undersöker hur många primtal det finns som är <= det");
        int tal = int.Parse(Console.ReadLine());
        Console.WriteLine("Det finns " + AllaPrimtal(tal) + " primtal mellan 0-" + tal + ".");

    }
}
