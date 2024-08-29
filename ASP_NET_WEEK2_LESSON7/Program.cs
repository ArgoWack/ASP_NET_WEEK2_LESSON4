using static System.Console;

// Zadanie 2

/*
1. Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są 
one równe czy nie.
Dane testowe:
a : 5
b : 5
Rezultat w terminalu :
5 i 5 są równe
*/

var a = 5;
var b = 5;

if (a == b)
    WriteLine("5 i 5 są sobie równe");
ReadKey();

// Zadanie 2

/*
2. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba 
jest parzysta czy nieparzysta.
Dane testowe : 15
Rezultat w terminalu :
15 jest liczbą nieparzystą
*/

int liczba;
WriteLine("Podaj liczbe");
Int32.TryParse(ReadLine(), out liczba);

if (liczba % 2 == 0)
    WriteLine("Parzysta");
else
    WriteLine("Nieparzysta");
ReadKey();

// Zadanie 3

/*
3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba 
jest dodatnia czy ujemna.
Dane testowe : 14
Rezultat w terminalu :
14 jest liczbą dodatnią
*/

int liczba2;
WriteLine("Podaj liczbe");
Int32.TryParse(ReadLine(), out liczba2);

if (liczba2 >= 0)
    WriteLine("Dodatnia");
else
    WriteLine("Ujemna");
ReadKey();

// Zadanie 4

/*
4. Napisz program w C#, który sprawdzi czy podany przez użytkownika rok 
jest rokiem przestępnym.
Dane testowe : 2016
Rezultat w terminalu :
2016 jest rokiem przestępnym
*/

int rok;
WriteLine("Podaj rok");
Int32.TryParse(ReadLine(), out rok);

if (rok % 4 == 0)
    WriteLine("Przestepny rok");
else
    WriteLine("Zwykły rok");
ReadKey();

// Zadanie 5

/*
5. Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek 
uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, 
prezydenta.
Dane testowe : 21
Rezultat w terminalu :
Możesz zostać posłem
*/

int wiek;
WriteLine("Podaj wiek");
Int32.TryParse(ReadLine(), out wiek);

if (wiek >= 18)
    WriteLine("Możesz zostać premierem");
if (wiek >= 21)
    WriteLine("Możesz zostać posłem");
if (wiek >= 30)
    WriteLine("Możesz zostać senatorem");
if (wiek >= 35)
    WriteLine("Możesz zostać prezydentem");
ReadKey();

// Zadanie 6

/*
6. Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu 
wymyśloną kategorię wzrostu.
Dane testowe : 140
Rezultat w terminalu :
Jesteś krasnoludem
*/

int wzrost;
WriteLine("Podaj wzrost");
Int32.TryParse(ReadLine(), out wzrost);

if (wzrost == 140)
    WriteLine("Jesteś krasnoludem");
ReadKey();

// Zadanie 7

/*
7. Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, 
która jest największa
Dane testowe:
25
63
79
Rezultat w terminalu :
79 jest największa z podanych
*/

double d1;
double d2;
double d3;

WriteLine("Podaj pierwsza liczbe");
double.TryParse(ReadLine(), out d1);
WriteLine("Podaj druga liczbe");
double.TryParse(ReadLine(), out d2);
WriteLine("Podaj trzecia liczbe");
double.TryParse(ReadLine(), out d3);

WriteLine(Math.Max(Math.Max(d1, d2),d3));
ReadKey();

// Zadanie 8

/*
8. Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce 
na studiach wg. Następujących kryteriów:
Wynik z Matury z matematyki powyżej 70
Wynik z fizyki powyżej 55
Wynik z chemii powyżej 45
Łączny wynik z 3 przedmiotów powyżej 180
Albo
Wynik z matematyki i jednego przedmiotu powyżej 150
Dane testowe:
Matematyka 80
Fizyka 71
Chemia 0
Rezultat w terminalu :
Kandydat dopuszczony do rekrutacj
*/

int matematyka;
int fizyka;
int chemia;
int suma;

WriteLine("Podaj wynik matury z matematyki");
Int32.TryParse(ReadLine(), out matematyka);
WriteLine("Podaj wynik matury z fizyki");
Int32.TryParse(ReadLine(), out fizyka);
WriteLine("Podaj wynik matury z chemi");
Int32.TryParse(ReadLine(), out chemia);

suma = matematyka + fizyka + chemia;

if (matematyka > 70 && fizyka > 55 && chemia > 45 && suma > 180 || (matematyka + fizyka) > 150 || (matematyka + chemia) > 150)
    WriteLine("Możesz ubiegać się o miejsce na studia");
else
    WriteLine("Nie możesz ubiegać się o miejsce na studia");
ReadKey();

// Zadanie 9

/*
9. Napisz program, który odczyta temperaturę I zwróci nazwę jak w 
poniższych kryteriach
Temp < 0 – cholernie piździ
Temp 0 – 10 – zimno
Temp 10 – 20 – chłodno
Temp 20 – 30 – w sam raz
Temp 30 – 40 – zaczyna być słabo, bo gorąco
Temp >= 40 – a weź wyprowadzam się na Alaskę.
Dane testowe : 41
Rezultat w terminalu :
a weź wyprowadzam się na Alaskę.
*/

int temperatura;

WriteLine("Podaj temperature");
Int32.TryParse(ReadLine(), out temperatura);

if(temperatura<0)
{
    WriteLine("cholernie piździ");
}
else if (temperatura<10)
{
    WriteLine("zimno");
}
else if (temperatura < 20)
{
    WriteLine("chłodno");
}
else if (temperatura < 30)
{
    WriteLine("w sam raz");
}
else if (temperatura < 40)
{
    WriteLine("zaczyna być słabo, bo gorąco");
}
else
{
    WriteLine("a weź wyprowadzam się na Alaskę");
}
ReadKey();

// Zadanie 10

/*
10. Napisz program, który sprawdzi, czy z 3 podanych długości można 
stworzyć trójkąt
Dane testowe : 40 55 65
Rezultat w terminalu :
Można zbudować trójkąt
*/

double d11;
double d22;
double d33;

WriteLine("Podaj pierwsza liczbe");
double.TryParse(ReadLine(), out d11);
WriteLine("Podaj druga liczbe");
double.TryParse(ReadLine(), out d22);
WriteLine("Podaj trzecia liczbe");
double.TryParse(ReadLine(), out d33);

if(d11+d22>d33 && d11+d33>d22 && d22+d33>d11)
    WriteLine("Można zbudować trójkąt");
else
    WriteLine("Nie można zbudować trójkąta");
ReadKey();

// Zadanie 11

/*
11. Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
Ocena Opis
6 Celujący
5 Bardzo dobry
4 Dobry
3 Dostateczny
2 Dopuszczający
1 Niedostateczny
Dane testowe : 3
Rezultat w terminalu :
Dostateczny
*/

int ocena;

WriteLine("Podaj numer oceny");
Int32.TryParse(ReadLine(), out ocena);

string Ocena = ocena switch
{
    1 => "Niedostateczny",
    2 => "Dopuszczający",
    3 => "Dostateczny",
    4 => "Dobry",
    5 => "Bardzo dobry",
    6 => "Celujący",
    _ => "Bledne dane"
};

WriteLine("Ocena to: "+ Ocena);
ReadKey();

// Zadanie 12

/*
12. Napisz program, który pobierze numer dnia tygodnia i wyświetli jego 
nazwę
Dane testowe : 4
Rezultat w terminalu :
Czwartek
*/

int dzien;

WriteLine("Podaj dzien tygodnia");
Int32.TryParse(ReadLine(), out dzien);

string Dzien = dzien switch
{
    1 => "Poniedzialek",
    2 => "Wtorek",
    3 => "Sroda",
    4 => "Czwartek",
    5 => "Piatek",
    6 => "Sobota",
    7 => "Niedziela",
    _ => "Bledne dane"
};

WriteLine("Dzień to: " + Dzien);
ReadKey();

// Zadanie 13

/*
13. Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I 
będzie prostym kalkulatorem
Podaj pierwszą liczbę: 
…
Podaj drugą liczbę:
…
Podaj numer operacji do wykonania:
1. Dodawanie
2. Odejmowanie
3. Mnożenie
4. Dzielenie
…
Twój wynik to:
*/

double d111;
double d222;
double d333;

int numer;

WriteLine("Podaj pierwsza liczbe");
double.TryParse(ReadLine(), out d111);
WriteLine("Podaj druga liczbe");
double.TryParse(ReadLine(), out d222);
WriteLine("Podaj numer operacji do wykonania: \r\n 1.Dodawanie \r\n  2.Odejmowanie \r\n  3.Mnożenie \r\n  4.Dzielenie");
Int32.TryParse(ReadLine(), out numer);

switch(numer)
{
    case 1:
        WriteLine("Twój wynik to: "+ (d111 + d222));
        break;

    case 2:
        WriteLine("Twój wynik to: " + (d111 - d222));
        break;

    case 3:
        WriteLine("Twój wynik to: " + (d111 * d222));
        break;

    case 4:
        WriteLine("Twój wynik to: " + (d111 / d222));
        break;

    default:
            WriteLine("Zly numer");
        break;
}
ReadKey();