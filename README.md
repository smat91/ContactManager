# Semesterprojekt: ContactManager
### Autor des Projekts: Alexander Palmer im Auftrag des Zentrums für berufliche Weiterbildung
<b>Abgabedatum: bis zum 19.09.2021 / 23:00 Uhr</b>

____________________________________________________________________________________________________________

### An diesem interessanten und spannendem Projekt beteiligt sind:

<b>Von der Klasse IT-A 20H-23H</b>

Bill Eberhard | Matthias Stieger | Milad Fakiry | Nico Varela Garcia

### Aufgabenstellung:
Es soll eine Microsoft Window-Forms Applikation erstellt werden, welche die Verwaltung und Pflege von Mitarbeiterund Kundeninformationen vereinfacht. Dabei sollen die üblichen CRUD (Create, Read, Update, Delete) Möglichkeiten
umgesetzt werden. Nebst den allgemeinen zu verwaltenden Informationen soll es möglich sein, dass die
Kontaktaufnahme zu Kunden in Form einer laufenden Dokumentation nachvollziehbar wird. Jeder Kontakt mit Kunden
wird protokolliert und kann zu einem späteren Zeitpunkt eingesehen werden.
Folgende Informationen gilt es zu verwalten:
Anrede, Vorname, Nachname, Geburtsdatum, Geschlecht, Titel, Telefonnummer Geschäft, Fax-Nummer Geschäft,
Mobiltelefonnummer, E-Mail-Adresse, Status (aktiv, passiv)
Mitarbeiternummer, Abteilung, AHV-Nummer, Wohnort, Nationalität, Adresse, Postleitzahl, Wohnort, Telefonnummer
privat, Eintrittsdatum, Austrittdatum, Beschäftigungsgrad, Rolle (Tätigkeitsbezeichnung), Kaderstufe (0-5), Lehrjahre,
aktuelles Lehrjahr (wenn Lernender)
Firmenname, Geschäftsadresse, Kundentyp (A-E), Firmenkontakt

Quelle: Semesterprojekt "contact manager", Aufgabenstellung (2021, Version 1.4). 

__________________________________________________

### Was funktioniert:
<b>Funktionale Anforderungen</b>
- Erfassung von Mitarbeitenden und Kunden

- Mutieren von Mitarbeitenden und Kunden

- Aktivieren und deaktivieren von Mitarbeitenden und Kunden

- Löschen von Mitarbeitenden und Kunden

- Automatische Vergabe von Mitarbeiternummern

- Protokollieren von Notizen in Kundenkontakten inkl. Historie

- Suchmöglichkeiten über alle gespeicherten Informationen

- Automatisches Speichern des Datenstamms auf Festplatte

__________________________________________________

<b>Optionale Anforderungen welche implementiert sind</b>
- Mutationshistorie von Kontaktdaten: Im Dashboard implementiert

- Login: Gilt als 1. Form und wenn die Daten stimmen, öffnet sich die 2. Form (Contact Manager)

- Dashboard-View

- Import von Kontakten im CSV-Format. Im Repository Ordner gibt es eine CSV-Datei, welche man als Test importieren lassen kann.

__________________________________________________

<b>Nicht funktionale Anforderungen</b>
- Die Umsetzung des "Contact Manager" erfolgte in C#, .NET und Windows-Forms Framework
- Die Applikationsarchitektur wurde so gut wie möglich umgesetzt. Vererbungen wurden angewendet und die verschiedenen Klassen kommunizieren erfolgreich miteinander. Wir haben uns für 2 Forms entscheiden (Login und Contact Manager). Im Contact Manager haben wir dann eine allgemeine Struktur aufgebaut und danach mit UserControls gearbeitet.
- Die Benutzbarkeit haben wir im Friends & Family-Umkreis getestet und verbessert.
- Damit die Stabilität des Programms gewährleistet ist, haben wir durch Fehleingaben, die Fehler abgefangen und korrigiert - Abstürtze natürlich auch.
- Die Quellcodes wurden im Programm, an Stellen wo es notwendig war, ausreichend kommentiert.

__________________________________________________

<b>Danksagung</b>

Wir bedanken uns ganz herzlich an das ZbW und an Herr Palmer für die Zeit und die Möglichkeit, so ein Projekt in Angriff zu nehmen und es von Grund auf aufzubauen. Diese Erfahrung war notwendig um Theorie und Praxis zu fusionieren. Wir sind an Problemen gestossen und haben überlegt und getüftelt, wie wir es lösen können und wenn wir es geschafft haben, war die Freude gross.

Ganz herzlich bedanken wir uns an unsere Testpersonen, welche sich die paar Minuten genommen haben, um das Programm zu benutzen. So konnten wir frischen Wind reinbringen und das Programm von einem anderen Blickwinkel betrachten.

Ein grosses Dankeschön geht an unser Team. Die Zusammenarbeit war sehr angenehmen und die individuellen Erfahrungen, welche wir alle einbringen konnten, war mehr als nützlich. Der Background war sehr durchmischt, so dass wir unsere Erfahrungen aus dem IT Bereich, aus dem Verkaufsbereich und aus dem kaufmännischen Bereich geteilt haben und somit sehr vieles für unsere IT-Ausbildung mitnehmen konnten.

<b>Vielen Dank und viel Spass mit dem Programm</b>
