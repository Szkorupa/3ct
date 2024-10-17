let formularz = document.getElementById('formularz');
formularz.addEventListener('submit', function(event) {
 event.preventDefault();

 let imie = document.getElementById('imie').value;
 let nazwisko = document.getElementById('nazwisko').value;
 let data = document.getElementById('data').value;
 let numer = document.getElementById('telefon').value;
 let haslo = document.getElementById('haslo').value;
 let haslo2 = document.getElementById('haslo2').value;
 let email = document.getElementById('email').value;

 if (imie == "") {
    let imie2 = document.getElementById("imie").style.borderColor = "red";
    alert('Wprowadz poprawne imie');
} else {
    let imie2 = document.getElementById("imie").style.borderColor = "green";
}

if (nazwisko == "") {
    let nazwisko2 = document.getElementById("nazwisko").style.borderColor = "red";
    alert('Wprowadz poprawne nazwisko');
} else {
    let nazwisko2 = document.getElementById("nazwisko").style.borderColor = "green";
}

if (data == "") {
    let data2 = document.getElementById("nazwisko").style.borderColor = "red";
    alert("Niepoprawna data");
} else {
    let data2 = document.getElementById("nazwisko").style.borderColor = "green";
}

if (numer.length < 8 || numer.length < 10)
{
    let numer2 = document.getElementById("telefon").style.borderColor = "red";

} else {
    let numer2 = document.getElementById("telefon").style.borderColor = "green";
}

if (!email){
    let email2 = document.getElementById("email").style.borderColor = "red";
} else {
    let email2 = document.getElementById("email").style.borderColor = "green";
}
if (haslo == haslo2)
{
    let haslo3 = document.getElementById("haslo").style.borderColor = "green";
    let haslo4 = document.getElementById("haslo2").style.borderColor = "green";
} else {
    let haslo3 = document.getElementById("haslo").style.borderColor = "red";
    let haslo4 = document.getElementById("haslo2").style.borderColor = "red";
    alert("Haslo sie nie zgadza");
}
});

formularz.addEventListener('submit', function(event) {
    event.preventDefault();
   
    let imie = document.getElementById('imie').value;
    let nazwisko = document.getElementById('nazwisko').value;
    let data = document.getElementById('data').value;
    let numer = document.getElementById('telefon').value;
    let haslo = document.getElementById('haslo').value;
    let haslo2 = document.getElementById('haslo2').value;

    if (haslo == haslo2 && numer.length >= 9 || numer.length > 10) {
        console.log('Dane są poprawne, przesyłanie formularza');
        let usun = document.getElementById("okno").style.display = "hidden";
        let dodaj = document.getElementById("pod").style.display = "block";

        let w1 = document.getElementById('w1').textContent = imie;
        let w2 = document.getElementById('w2').textContent = nazwisko;
        let w3 = document.getElementById('w3').textContent = data;
        let w4 = document.getElementById('w4').textContent = numer;
        let w5 = document.getElementById('w5').textContent = email;
        let w6 = document.getElementById('w6').textContent = haslo;
        let w7 = document.getElementById('w7').textContent = haslo2;
    } else {
        alert("No chyba cie grzeje")
    }
});