using static System.Console;

// Zadanie1

/*
 * 1. Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane 
które chcesz przetrzymywać to:
a. Imię,
b. Nazwisko
c. Wiek
d. Płeć (‘m’ albo ‘k’)
e. PESEL
f. Numer pracownika (np. 2509324094)
Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje
*/

string imie;
string nazwisko;
int wiek;
char plec;
long pesel;
int numer_pracownika;

WriteLine("Podaj imie pracownika");
imie = ReadLine();
WriteLine("Podaj imie nazwisko");
nazwisko = ReadLine();
WriteLine("Podaj imie wiek");
Int32.TryParse(ReadLine(), out wiek);
WriteLine("Podaj imie plec 'k' lub 'm'");
plec = Char.Parse(ReadLine());
WriteLine("Podaj pesel");
long.TryParse(ReadLine(), out pesel);
WriteLine("Podaj numer pracownika");
Int32.TryParse(ReadLine(), out numer_pracownika);

WriteLine($"Imię: {imie}, Nazwisko: {nazwisko}, Wiek: {wiek}, Płeć: {plec}, PESEL: {pesel}, Numer pracownika: {numer_pracownika}");
ReadKey();

//Zadanie 2

/*
 * 2. Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w 
odwrotnej kolejności niż zostały zadeklarowane.
*/
char a1;
char a2;
char a3;

WriteLine("Podaj a1");
a1 = Char.Parse(ReadLine());
WriteLine("Podaj a2");
a2 = Char.Parse(ReadLine());
WriteLine("Podaj a3");
a3 = Char.Parse(ReadLine());

WriteLine($"a3: {a3}, a2: {a2}, a1: {a1}");
ReadKey();

// Zadanie 3

/*
 * 3. Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość 
przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())
*/

double szerokosc;
double dlugosc;
double przekatna;

WriteLine("Podaj szerokosc");
double.TryParse(ReadLine(), out szerokosc);
WriteLine("Podaj dlugosc");
double.TryParse(ReadLine(), out dlugosc);

przekatna = Math.Sqrt(Math.Pow(szerokosc, 2) + Math.Pow(dlugosc, 2));

WriteLine(przekatna);
ReadKey();

// Zadanie 4

/*
 4. Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie 
przypiszesz im następujące wartości:
a. 10
b. Szkoła Dotneta
c. 12,5
Pamiętaj o użyciu poprawnych typów danych.
*/

int a = 10;
string b = "Szkoła Dotnet";
float c = 12.5f;

//Zadamoe 5

/*
 * 5. Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko, 
numer telefonu, adres email, wzrost, waga (np. 85,7), itp (postaraj się wymyślić jak najwięcej) 
i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody: 
typDanych.Parse(odpowiedźOdUżytkownika). 
*/

string imie_2;
string nazwisko_2;
int wiek_2;
char plec_2;
long pesel_2;
int numer_telefonu_2;
float waga_2;
float wzrost_2;

WriteLine("Podaj imie pracownika");
imie_2 = ReadLine();
WriteLine("Podaj imie nazwisko");
nazwisko_2 = ReadLine();
WriteLine("Podaj imie wiek");
Int32.TryParse(ReadLine(), out wiek_2);
WriteLine("Podaj imie plec 'k' lub 'm'");
plec_2 = Char.Parse(ReadLine());
WriteLine("Podaj pesel");
long.TryParse(ReadLine(), out pesel_2);
WriteLine("Podaj numer telefonu");
Int32.TryParse(ReadLine(), out numer_telefonu_2);
WriteLine("Podaj wage");
waga_2 = Char.Parse(ReadLine());
WriteLine("Podaj wzrost");
wzrost_2 = Char.Parse(ReadLine());
WriteLine($"Imię: {imie}, Nazwisko: {nazwisko}, Wiek: {wiek}, Płeć: {plec}, PESEL: {pesel}, Numer telefonu: {numer_telefonu_2}, Waga: {waga_2}, Wzrost: {wzrost_2}");
ReadKey();
