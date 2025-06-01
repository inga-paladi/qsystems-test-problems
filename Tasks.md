Dezvoltă Tascurile și punele pe GitHub.

# Task 1
Scrieți o bibliotecă pentru distribuții externe care poate calcula aria unui cerc avînd raza sa și 
a unui triunghi fiind dată cele trei laturi ale sale.
Pe lângă performanță, vom evalua:
- Teste unitare
- Ușurința de a adăuga alte forme geometrice
- Calcularea ariei unei figuri fără a cunoaște tipul figurii geometrice
- Verificarea dacă un triunghi este dreptunghic

# Task 2
Baza de date MS SQL Server conține produse și categorii. Un produs poate corespunde mai multor categorii, iar o categorie poate 
conține mai multe produse. Scrieți o interogare SQL pentru a selecta toate perechile „Nume produs - Nume categorie”. 
Dacă un produs nu are categorii, numele său ar trebui să fie afișat în continuare.
Suplimentar:
- Se cere diagrama tabelelor si relatiile intre ele

# Task 3
Se dă ```List<uint> list``` și un anumit număr ```ulong sum```. Numărul așteptat de elemente în ```list``` este de câteva milioane.
Este necesar să se scrie o metodă ```FindElementsForSum``` care să poată găsi cei mai mici indici ```start``` și ```end``` astfel 
încât suma elementelor ```list``` de la indicele ```start``` inclusiv până la indicele ```end``` exclusiv să fie exact 
egală cu ```sum```. Dacă astfel de valori pentru ```start`` și ```end`` nu pot fi găsite, 
atunci setați ```start`` și ```end`` la ```0```. Oferiți soluția ca metodă. Semnătura și numele 
metodei nu pot fi modificate, ci doar corpul.

```
public void FindElementsForSum(List<uint> listă, ulong sum, out int început, out int sfârșit)
{
// codul tău aici
}
```

Exemple:
```
FindElementsForSumTest(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 11, out început, out sfârșit); //începutul va fi egal cu 5 și sfârșitul cu 7;
FindElementsForSumTest(new List<uint> { 4, 5, 6, 7 }, 18, out început, out sfârșit); //începutul va fi egal cu 1 și sfârșitul cu 4;
FindElementsForSumTest(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 88, out început, out sfârșit); //începutul va fi egal cu 0 și sfârșitul va fi 0;
```

Pe lângă funcție, trebuie să creați și să scrieți mai multe exemple (teste) pentru a vă asigura că implementarea funcționează bine și corect.

# Task 4

#### **Stivă tehnologică:**

1. Backend: C#, .net core 8+
2. Arhitectură: cqrs
3. Bază de date: mssql/postgres
4. Sarcină suplimentară pe UI: nu conteaza (angular react razor etc)

#### **Exercițiu**

Este necesar să scrieți un serviciu care să vă permită să creați și să editați angajații unei organizații. Angajații trebuie 
să aibă o denumire a postului în baza căreia li se calculează salariul. Pe lângă cererile CRUD, trebuie să existe o 
cerere paginată care să includă un câmp de sortare și un câmp de filtrare (după numele sau funcția angajatului).

Sarcină de cunoaștere a bazelor de date. Scrieți și atașați scripturi pentru: selectarea tuturor angajaților, 
angajații al căror salariu este mai mare de 10.000, ștergerea angajaților cu vârsta peste 70 de ani, 
actualizarea salariului la 15.000 pentru acei angajați al căror salariu este mai mic.

#### Sarcină suplimentară (opțională):

Este necesar să scrieți un site web cu un meniu de navigare orizontal format din două file:

● „Despre companie” (pagina de pornire)
● „Angajați”

În prima filă, utilizați un aspect personalizat. Când accesați fila „Angajați”, ar trebui să apară un tabel 
format din următoarele coloane:

● „Departament”
● „Nume complet”
● „Data nașterii”
● „Data angajării”
● „Salarii”
● „Creează/șterge/editează angajat”

În coloana „Creează/șterge/editează angajat”, antetul trebuie să fie gol, iar corpul trebuie să conțină trei butoane. Când faceți
clic pe butoanele „Creare” și „Editare”, se deschide o fereastră modală cu câmpurile angajatului; Când faceți clic pe butonul 
„Șterge”, se afișează o fereastră modală cu confirmare. Toate acțiunile trebuie efectuate asincron, adică fără a reîncărca pagina.
