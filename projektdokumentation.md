# Projekt-Dokumentation

Damian Eisenring, Joël Haldimann

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 03.05.2024      | 0.0.1   | Projekt initialisiert|
|       | ...     |                                                              |
| 12.06.2024      | 1.0.0   |  Projekt beendet    |

## 1 Informieren

### 1.1 Ihr Projekt

Wir haben eine Webseite für ein fiktives Unternehmen entwickelt mit einer Feedbackpage, welche Benutzerdaten in einer Datenbank speichert.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
|1|	Muss|	Funktional|	Als ein Nutzer möchte ich die Unternehmensgeschichte lesen, um mehr über das Unternehmen zu erfahren.|
|2|	Muss|Funktional|	Als ein Nutzer möchte ich die Dienstleistungen des Unternehmens sehen, um zu verstehen, was angeboten wird.|
|3|	Muss|	Funktional|	Als ein Nutzer möchte ich die Kontaktinformationen des Unternehmens sehen, um mit ihnen in Kontakt treten zu können.|
|4|	Muss|	Funktional|	Als ein Nutzer möchte ich auf der Webseite Feedback hinterlassen können, um meine Meinung zu äußern.|
|5|	Soll|	Funktional|	Als Administrator möchte ich Zugriff auf das Feedback erhalten, um auf Kundenanliegen reagieren zu können.|


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | 	Webseite ist geladen  |  Nutzer navigiert zur Unternehmensgeschichte   |  Die Unternehmensgeschichte wird angezeigt.  |
|1.2|	Webseite ist geladen|	Nutzer navigiert zu den Dienstleistungen|	Die Dienstleistungen des Unternehmens werden angezeigt.|
|1.3|	Webseite ist geladen|	Nutzer navigiert zu den Kontaktinformationen|	Die Kontaktinformationen des Unternehmens werden angezeigt.|
|1.4|	Webseite ist geladen|	Nutzer navigiert zur Feedback-Seite|	Die Feedback-Seite wird angezeigt.|
|1.5|	Webseite ist geladen|	Administrator navigiert zur Feedback-Verwaltungsseite|	Das Feedback wird angezeigt und kann bearbeitet werden.|
| ...  |              |         |                   |


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
|1.A|	12.06.2024|	Damian|	Entwicklung der Unternehmensgeschichte-Seite|	4h
|1.B|	12.06.2024|	Joël|	Entwicklung der Dienstleistungen-Seite|	4h
|1.C|	12.06.2024|	Damian|	Entwicklung der Kontakt-Seite	|3h
|1.D|	12.06.2024|	Joël|	Entwicklung der Feedback-Seite|	5h
|1.E|	12.06.2024|	Damian|	Implementierung des Feedback-Datenbankzugriffs|	4h
| ...  |       |           |              |               |

Total: 20h


## 3 Entscheiden

Die Feedback-Datenbank wird mit MongoDB implementiert, um flexibles und skalierbares Datenmanagement zu ermöglichen.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
|1.A|	2024-06-14|	Damian|	4h	| 4h|
|1.B|	2024-06-14|	Joël|	4h	| 5h|
|1.C|	2024-06-15|	Damian|	3h	| 3h|
|1.D|	2024-06-15|	Joël|	5h	| 5h|
|1.E|	2024-06-16|	Damian|	4h	| 4h|
| ...  |       |           |               |                   |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
|1.1|	12.06.2024	| OK	| Damian
|1.2|	12.06.2024	|	OK  | Joël
|1.3|	12.06.2024	|	OK  | Damian
|1.4|	12.06.2024	|	OK  | Joël
|1.5|	12.06.2024  | OK  | Damian
| ...  |       |          |        |

