#include <iostream>
using namespace std;

class Prostokat
{
public:
	void ustawSzerokosc(double s) {
		this->szerokosc = s;
	}
	void ustawWysokosc(double w) {
		this->wysokosc = w;
	}
	double obliczPole() {
		return this->szerokosc * this->wysokosc;
	}
private:
	double szerokosc, wysokosc;
};

class Trojkat
{
private:
	double Podstawa, Wysokosc;
public:
	void ustawA(float A) { this->Podstawa = A; };
	void ustawH(float H) { this->Wysokosc = H; };
	double obliczPoleTrojkat() {
		return this->Podstawa * this->Wysokosc / 2;
	}
};

class Romb
{
private:
	double podstawa2, wysokosc2;
public:
	void ustawA2(float a2) { this->podstawa2 = a2; };
	void ustawH2(float h2) { this->wysokosc2 = h2; };
	double obliczPoleRomb() {
		return this->podstawa2 * wysokosc2;
	}

};

int main()
{
    cout << "ᛋᛋ Zadanie pierwsze ᛋᛋ" << "\n";
    

	double s, w;
	cout << "Podaj szerokosc = "; cin >> s;
	cout << "Podaj wysokosc = "; cin >> w;
	Prostokat prostokat;
	prostokat.ustawSzerokosc(s);
	prostokat.ustawWysokosc(w);
	cout << "Pole prostokata = " << prostokat.obliczPole() << endl;

	cout << "-------------------------" << "\n";

	cout << "Zadanie 2" << "\n";

	double A, H;
	cout << "Podaj podstawe = "; cin >> A;
	cout << "Podaj wysokosc = "; cin >> H;
	Trojkat trojkat;
	trojkat.ustawA(A);
	trojkat.ustawH(H);
	cout << "Wynik: " << trojkat.obliczPoleTrojkat() << endl;

	cout << "-------------------------" << "\n";

	cout << "Zadanie 3" << "\n";

	double a2, h2;
	cout << "Podaj podstawa"; cin >> a2;
	cout << "Podaj podstawa"; cin >> h2;
	Romb romb;
	romb.ustawA2(a2);
	romb.ustawH2(h2);
	cout << "WyniK: " << romb.obliczPoleRomb() << endl;

    return EXIT_SUCCESS;
}
