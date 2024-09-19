#include <iostream>
using namespace std;

class Czlowiek
{
public:
    int wiek;
    string imie;
    string nazwisko;

public:
    Czlowiek(int wiek, string nazwisko, string imie) {
        this->wiek = wiek;
        this->nazwisko = nazwisko;
        this->imie = imie;
    }

    void czlowiek_setter(int wiek, string nazwisko, string imie) {
        this->wiek = wiek;
        this->nazwisko = nazwisko;
        this->imie = imie;
    }

    void

 
    void opisCzlowieka() {
        cout << "wiek " << this->wiek << endl;
        cout << "imie " << this->imie << endl;
        cout << "nawisko " << this->nazwisko << endl;
    }

    ~Czlowiek() {
        cout << "Koniec Obiektu" << endl;
    };
};


int main()
{
    Czlowiek nauczyciel = Czlowiek(40, "Arkadiusz", "Waliczek");
  

    nauczyciel.opisCzlowieka();
    cout << "-------------------------------" << endl;


    Czlowiek wykladowiec = Czlowiek(40, "Arkadiusz", "Waliczek");
  
    wykladowiec.opisCzlowieka();
   
    return EXIT_SUCCESS;
}


