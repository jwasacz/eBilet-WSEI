Dokumentacja Projektu ASP.NET MVC

Spis Treści:

1.Opis Projektu

2.Struktura Projektu

3.Instrukcje Instalacji

4.Wymagania Systemowe

5.Opis Funkcjonalności

6.Baza Danych

7.Autoryzacja Użytkowników

8.API CRUD

9.Instrukcje Uruchomienia Projektu

10.Działające Elementy


1. Opis Projektu
Projekt jest aplikacją webową zbudowaną w oparciu o framework ASP.NET MVC. Aplikacja ma na celu zarządzanie danymi związanymi z aktorami, kinami, producentami, filmami, itp. Projekt stosuje wzorzec MVC (Model-View-Controller) dla lepszego zorganizowania kodu i łatwiejszej utrzymanie.

2. Struktura Projektu
Projekt podzielony jest na kilka głównych komponentów:

Models: Zawiera modele danych, takie jak Actor, Cinema, Movie, Producer itp.
Views: Widoki HTML odpowiedzialne za prezentację danych.
Controllers: Kontrolery obsługujące logikę biznesową i interakcję z użytkownikiem.
Data: Zawiera pliki dotyczące obsługi bazy danych.
wwwroot: Zawiera zasoby takie jak skrypty JavaScript, arkusze stylów CSS, itp.
Areas: Obszar projektu dotyczący autoryzacji i zarządzania użytkownikami.

3. Instrukcje Instalacji
Aby zainstalować i uruchomić projekt, wykonaj poniższe kroki:

Sklonuj repozytorium z GitHub.
Uruchom projekt w środowisku Visual Studio lub Visual Studio Code.
Ustaw połączenie z bazą danych w pliku appsettings.json.
W konsoli Package Manager wykonaj komendę Update-Database w celu utworzenia bazy danych.
Skonfiguruj dane testowe i testowe użytkownicy w pliku program.cs.
Uruchom projekt.

4. Wymagania Systemowe
Do uruchomienia projektu wymagane jest środowisko .NET Core 3.1 lub nowsze.


6. Opis Funkcjonalności
Projekt oferuje następujące funkcjonalności:

Zarządzanie aktorami, kinami, producentami, filmami itp.
Autoryzacja użytkowników na poziomie administratora i użytkownika zwykłego.
API CRUD umożliwiające manipulację danymi.

7. Baza Danych
Projekt używa Entity Framework do obsługi bazy danych. Baza danych zostanie utworzona automatycznie podczas pierwszego uruchomienia aplikacji.

8. Autoryzacja Użytkowników
Autoryzacja użytkowników realizowana jest poprzez framework ASP.NET Identity. Administrator ma rozszerzone uprawnienia, takie jak edycja, usuwanie i dodawanie danych, w przeciwieństwie do użytkownika zwykłego, który ma ograniczony dostęp.

9. API CRUD
Projekt udostępnia interfejs API do operacji CRUD na głównej encji, umożliwiając integrację z innymi systemami.

10. Instrukcje Uruchomienia Projektu
Po zainstalowaniu projektu zgodnie z instrukcjami w punkcie 3, uruchom projekt w środowisku Visual Studio lub Visual Studio Code.

11. Działające Elementy
Projekt zawiera działające widoki i formularze do zarządzania aktorami, kinami, producentami i filmami. Funkcje autoryzacji są również sprawdzone i działające.
