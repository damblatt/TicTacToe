
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

Unser Ziel bei diesem Projekt ist es, ein Programm zu erstellen, in dem man TicTacToe spielen kann. Was unser TicTacToe jedoch speziell macht ist die Möglichkeit, einen Spielzug rückgängig zu machen. Der Name der Spieler und deren Zeichen können zudem personalisiert werden.

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

      

## Dokumentation

### Unit Testing

Für einige Methoden haben wir Unit Tests geschrieben. Getestet haben wir nur öffentliche Methoden (public) wie zum Beispiel die Methode 'TryCreateCoordinate(string input)' aus der Klasse 'Coordinate' oder zum Beispiel den WinChecker. Alle Unit Tests sind hier zu finden: [Unit Testing](https://github.com/damblatt/TicTacToe/tree/main/TicTacToe/TicTacToe.Test).



### 07-03-2023 (Sprint 1)

#### Sprintziele

- Erste Tasks bearbeiten
- Organisation bereitstellen

#### Tätigkeit

Gestartet haben wir als Gruppe damit, die User-Stories zu notieren. Wir sind erstmals auf insgesamt 8 User-Stories gekommen. Dalibor schrieb die Akzeptanzkriterien zu den notierten User-Stories, während Damian diese im Projekt auf Azure DevOps eintrug und priorisierte. Pascal arbeitete in dieser Zeit am Use-Case-Diagramm. Nachdem das Product Backlog erstellt wurde, sassen wir erneut im Team zusammen und führten ein erstes Sprint Planning durch. Während dem ersten Modulblock lag unser Fokus vor allem auf der Planung und der korrekten Handhabung der vorgegebenen Hilfsmittel wie Azure DevOps und GitHub.

#### Review & Retrospektive Protokoll

In diesem Sprint haben wir uns Sprintziel leider nicht erreicht. Grund dafür ist wohl der Mangel an Planung. Trotzdem kamen wir schlussendlich weit und konnten alle Plattformen wie Github und Azure DevOps aufsetzen. Im nächsten Sprint möchten wir den Fokus mehr aufs Coden legen, da das Organisatorische nun erledigt ist.



### 14-03-2023 (Sprint 2)

#### Sprintziele

- Sprintziele Sprint 1

- Objektorientierte Umsetzung
  - Alle Klassen & Methoden bereitstellen
- Funktionierendes Spielfeld
  - Spielereingaben
  - Fehlermeldung bei ungültiger Eingabe

#### Tätigkeit

In den zweiten Sprint starteten wir abgelenkt von unserem Projekt, trotzdem haben wir im Unterricht viel erreicht und uns die Aufgaben von dem zweiten Sprint zugeteilt. Die Aufgaben, welche wir im ersten Sprint noch nicht im erledigen hatten, haben wir im Unterricht bearbeitet. Die restlichen Sprintziele haben wir zu Hause erledigt.

#### Review & Retrospektive Protokoll

In diesem Sprint haben wir unser Sprintziel erreicht.
Wir haben uns dieses Mal besser ausserhalb vom Unterricht organisiert. Ein Problem welches während des zweiten Sprints öfters auftrat sind Merge Conflicts, welche uns sehr viel Zeit gekostet haben.



### 21-03-2023 (Sprint 3)

#### Sprintziele

- UI fertigstellen

  - Anzeigen welcher Spieler am Zug ist

  - Gewinner anzeigen

  - Unentschieden anzeigen

- Logik fertigstellen
  - Gewinnlogik implementieren
  - Undo Funktion implementieren
- Refactoring
- Unit Testing

#### Tätigkeit

Den dritten Sprint starteten wir motiviert. Es gab jedoch Probleme beim Implementieren vom Stack für die Undo-Funktion. Nach einiger Recherche und Debugging wurde uns klar, dass das Problem darin lag, wie wir das aktuelle Feld in den Stack laden. Wir informierten uns also über Shallow und Deep Copies und wandten unser Wissen an.

#### Review & Retrospektive Protokoll

In diesem Sprint haben wir unser Sprintziel erreicht.
Wir haben in unserer Freizeit viel Zeit investiert, damit wir unser Ziel erreichen und es hat sich auf jeden Fall gelohnt. Der Stack funktioniert jetzt einwandfrei und die Unit Tests sind geschrieben.
