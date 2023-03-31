
# TicTacToe

## Inhaltsverzeichnis

→ [Backlog](#backlog)

&emsp;↳ [User Stories](#user-stories)&emsp;

→ [Dokumentation](#dokumentation)

&emsp;↳ [Unit Testing](#unit-testing)

&emsp;↳ [Sprint 1](#07-03-2023-sprint-1)

&emsp;↳ [Sprint 2](#14-03-2023-sprint-2)

&emsp;↳ [Sprint 3](#21-03-2023-sprint-3)

## Projekt

### Backlog

####  Produktvision

Unser Ziel bei diesem Projekt ist ein Programm zu erstellen, in dem man TicTacToe spielen kann. Was unser Produkt jedoch hervorhebt, ist unsere Personalisierbarkeit. Wir wollen das Jeder Spieler sein eigenes Zeichen bestimmen kann.

#### User-Stories

> **Format**
>
> n. User-Story
>
> `Akzeptanzkriterien`
>
> 	-> (optional) Tasks

<br>

1. > Als Spieler möchte ich, dass ein Spielfeld automatisch generiert und gedruckt wird, damit ich jederzeit den Spielstand erkenne.
   >
   > `Das Feld wird im Konsolenfenster angezeigt.`
   >
   > `Das Feld wird automatisch generiert.`

   <br>

2. > Als Spieler möchte ich, dass ich leere Felder auswählen kann, um sie mit meinem Symbol zu belegen.
   >
   > `Die Spieler können einzelne Felder auswählen.`
   >
   > `Die Spieler können das ausgewählte Feld befüllen.`

   <br>

3. > Als Spieler möchte ich, dass ich die Symbole frei wählen kann, damit ich selbst entscheiden kann, womit ich spielen möchte.
   >
   > `Die Spieler können vor dem Spielstart ihre Symbole frei auswählen.`
   >
   > `TASK` Als Spieler möchte ich, dass mein Gegner nicht das gleiche Symbol wie ich benutzen kann, damit wir die Spielfiguren nicht verwechseln.

   <br>

4. > Als Spieler möchte ich, dass mein Gegner meine Felder nicht belegen kann, damit die Originalregeln beibehalten werden.
   >
   > `Die Spieler sollten nicht in der Lage sein, bereits belegte Felder zu ersetzen.`

   <br>

5. > Als Spieler möchte ich, dass ich einen oder mehrere Spielzüge rückgängig machen kann, damit z. B. schlechte Züge verbessert werden können.
   >
   > `Die Spieler sollten in der Lage sein, ihre Züge rückgängig zu machen.`

   <br>

6. > Als Spieler möchte ich, dass angezeigt wird, welcher Spieler am Zug ist, damit keine Verwirrung vorherrscht.
   >
   > `Das Spiel soll stets anzeigen, welcher Spieler am Zug ist.`

   <br>

7. > Als Spieler möchte ich, dass bei ungültigen Zügen eine Fehlermeldung ausgegeben wird, damit das Spiel nicht verfälscht wird.
   >
   > `Bei ungültigen Zügen sollte das Spiel Fehlermeldungen ausgeben.`
   >
   > `Das Spiel erlaubt keine ungültigen Züge.`

   <br>

8. > Als Spieler möchte ich, dass das Spiel beendet wird wenn eine Reihe vertikal, horizontal oder diagonal mit dem Symbol eines Spielers belegt ist oder wenn es zu einem Unentschieden kommt, damit das Spiel mit einem klaren Spielstand endet.
   >
   > `Das Spiel kann durch die TicTacToe Regeln gewonnen bzw. verloren werden. `

   <br>

9. > Als Product Owner möchte ich, dass das Projekt Gut dokumentiert wurde und sauber auf GitHub dargestellt ist.
   >
   > `Das ganze Developerteam hat das finale Projektresultat kontrolliert und zugestimmt es so abzugeben. `

      

### Dokumentation

### Unit Testing 

Für einige Methoden haben wir Unit Tests geschrieben. Getestet haben wir nur öffentliche Methoden (public) wie zum Beispiel die Methode 'TryCreateCoordinate(string input)' aus der Klasse 'Coordinate' oder zum Beispiel den WinChecker.

### 07-03-2023 (Sprint 1)

#### Sprintziele

- Ersten Tasks abarbeiten
- Organisation bereitstellen

#### Tätigkeit

Gestartet haben wir als Gruppe damit, die User-Stories zu notieren. Wir sind erstmals auf insgesamt 8 User-Stories gekommen. Dalibor schrieb die Akzeptanzkriterien zu den notierten User-Stories, während Damian diese im Projekt auf Azure DevOps eintrug und priorisierte. Pascal arbeitete in dieser Zeit am Use-Case-Diagramm. Nachdem das Product Backlog erstellt wurde, sassen wir erneut im Team zusammen und führten ein erstes Sprint Planning durch. Während dem ersten Modulblock lag unser Fokus vor allem auf der Planung und der korrekten Handhabung der vorgegebenen Hilfsmittel wie Azure DevOps und GitHub.

#### Review & Retrospektive Protokoll

In diesem Sprint ist haben wir leider nicht unser Sprintziel erreicht. Grund dafür ist unser Mangel an Planung wie mir die Aufgaben in unserer Freizeit organisieren. Trotzdem wurde die Organisation sehr weit gebracht, was uns beim nächsten Sprint sicher sehr helfen wird.

### 14-03-2023 (Sprint 2)

#### Sprintziele

- Objektorientierte Umsetzung
  - Alle Klassen & Methoden bereitstellen
- Funktionierendes Spielfeld
  - Spielereingaben
  - Fehlermeldungen bei ungültigen Eingaben

#### Tätigkeit

Den zweiten Sprint starteten wir abgelenkt von unserem Projekt, trotzdem haben wir im Unterricht viel erreicht und uns die Aufgaben von dem zweiten Sprint zugeteilt. die Wenigen Aufgaben, welche wir nicht im Unterricht erledigen konnten haben wir als Hausaufgaben erledigen.

#### Review & Retrospektive Protokoll

In diesem Sprint haben wir unser Sprintziel erreicht.
wir haben dieses Mal uns besser ausserhalb von Unterricht organisiert. das einzige Problem was aufgetreten ist, wir hatten Probleme mit Rücksicht auf die anderen GitHub zu arbeiten.

### 21-03-2023 (Sprint 3)

#### Sprintziele

- UI fertigstellen

  - Anzeigen welcher Spieler am Zug ist

  - Gewinner anzeigen

- Logik fertigstellen
  - Logik um zu Gewinnen implementieren
  - Undo Funktion implementieren
- Projekt fertigstellen

#### Tätigkeit

Den dritten Sprint starteten wir motiviert, jedoch gab es Probleme beim Implementieren von dem Stack für die Undo Funktion was unseren Fortschritt einschränkte. Jedoch waren wir entschlossen ein Präsentables Produkt am Ende des Sprints zu haben.

#### Review & Retrospektive Protokoll

In diesem Sprint haben wir unser Sprintziel erreicht.
wir haben diesen Sprint in unserer Freizeit viel Zeit investiert damit wir unser Ziel erreichen konnten. 
Das hatte leider zur Folge, dass wir schnell an Motivation an dem Projekt verloren haben, trotzdem sind wir zufrieden mit dem Resultat.
