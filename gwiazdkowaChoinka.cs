using System;

Console.Write("Podaj ilosc wierszy choinki: "); 
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0 && n < 50) // rozkminic checkowanie czy jest int, jesli nie to wywalic komunikat i return
{
    if (n == 1)
    {
        Console.WriteLine("No to rysujemy " + n + " wiersz.");
        rysujChoinke();

    }
    else if (n >= 2 && n <= 4)
    {
        Console.WriteLine("No to rysujemy " + n + " wiersze.");
        rysujChoinke();
    }
    else if (n >= 5)
    {
        Console.WriteLine("No to rysujemy " + n + " wierszy.");
        rysujChoinke();
    }
}
else
{
    Console.WriteLine("Przy takiej wartosci nie porysujemy choinki ;)");
}
void rysujChoinke()
{
    int d, i, j, k, l;
    string a = "*";
    string b = " ";
    Thread.Sleep(500);
    d = n;
    for (i = 1; i <= n; i++)
    {
        for (j = 1; j < d; j++)
        {
            Console.Write(b);
        }
        for (l = 1; l <= i; l++)
        {
            Console.Write(a);
        }
        for (k = 1; k <= i - 1; k++)
        {
            Console.Write(a);
        }
        d--;
        Console.WriteLine();
    }
}