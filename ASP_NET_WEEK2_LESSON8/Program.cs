using static System.Console;

// Zadanie 1

/*
1. Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.
*/

static bool CzyLiczbaPierwsza(int liczba)
{
    if (liczba < 2)
    {
        return false;
    }

    for (int i = 2; i <= Math.Sqrt(liczba); i++)
    {
        if (liczba % i == 0)
        {
            return false;
        }
    }

    return true;
}

int ilePierwszych = 0;

for (int i = 2; i <= 100; i++)
{
    if (CzyLiczbaPierwsza(i))
    {
        ilePierwszych++;
    }
}

WriteLine($"Jest: {ilePierwszych} liczb pierwszych");
ReadKey();

// Zadanie 2

/*
2. Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z 
zakresu 0 – 1000.
*/


int i2 = 0;
List<int> tabela = new List<int>();

do
{
    if (i2 % 2 == 0)
    {
        tabela.Add(i2);
    }
    i2++;
}
while (i2 <= 1000);

WriteLine("Liczby parzyste:");
foreach (object obj in tabela)
{
    Write($"{obj} ");
}
WriteLine();
ReadKey();

// Zadanie 3

/*
3. Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
*/

static int Fibbonaci(int liczba)
{
    if (liczba<2)
    {
        return liczba;
    }
    else
    {
        return Fibbonaci(liczba - 1) + Fibbonaci(liczba - 2);
    }
}
WriteLine(Fibbonaci(10));
ReadKey();

// Zadanie 4

/*
4. Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej 
liczby w formie jak poniżej:
1
2 3
4 5 6
7 8 9 10
*/

int liczbe;
WriteLine("Podaj liczbe");
Int32.TryParse(ReadLine(), out liczbe);

int temp_liczba=1;
int temp_ilosc_rzedow = 1;

while (temp_liczba < liczbe)
{
    if (temp_liczba == 1)
    {
        WriteLine(temp_liczba);
        temp_liczba++;
    }
    else
    {
        for (int i=0; i<temp_ilosc_rzedow;i++)
        {
            Write(temp_liczba+" ");
            if (temp_liczba == liczbe)
                break;
            temp_liczba++;
        }
        WriteLine();
    }
    temp_ilosc_rzedow++;
}
ReadKey();

// Zadanie 5

/*
5.Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
*/

for (int i=1;i<21;i++)
{
    WriteLine(Math.Pow(i,3));
}
ReadKey();

// Zadanie 6

/*
6. Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
1 + ½ +1 / 3 + ¼ itd.
*/
float suma=0;

for (int i = 1; i < 21; i++)
{
    suma += 1 / i;
}
WriteLine(suma);
ReadKey();

// Zadanie 7

/*
7.Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej 
przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
*
 ***
 *****
*******
*********
*******
 *****
 ***
 *
*/

int liczba;
WriteLine("Podaj dlugosc boku");
Int32.TryParse(ReadLine(), out liczba);

if (liczba == 1)
    WriteLine("*");
if (liczba == 2)
{
    WriteLine("*");
    WriteLine("* *");
    WriteLine("*");
}
else
{
    for (int i = 0; i < liczba; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Write("* * ");
        }
        WriteLine();
    }
    for (int i = 0; i < liczba+1; i++)
    {
        Write("* ");
    }
    WriteLine();
    for (int i = liczba; i != 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            Write("* * ");
        }
        WriteLine();
    }
}

ReadKey();

// Zadanie 8

/*
8.Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
Testowe dane:
Abcdefg
Rezultat
Gfedcba
*/

// Zadanie 9

/*
9. Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.
*/

// Zadanie 10

/*
10. Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
*/