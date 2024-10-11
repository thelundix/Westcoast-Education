# WestCoast Education Kursförvaltningssystem

## Översikt
Denna .NET Console-applikation är utformad för WestCoast Education, en utbildningsinstitution i Sverige. Den hanterar kurser, studenter, lärare och administratörer och stödjer både traditionell och onlineutbildning.

## Funktioner

### Kursförvaltning
- Lägg till, redigera och ta bort kurser.
- Visa kursdetaljer (längd, datum, typ).
- Lista kurser.

### Studentförvaltning
- Lägg till, redigera och ta bort studenter.
- Lista studenter.

### Lärarförvaltning
- Lägg till, redigera och ta bort lärare.
- Lista lärare och deras kurser.

### Administratörsförvaltning
- Hantera administratörsprofiler och systemoperationer.

## Projektstruktur
- **Models/**: Innehåller klasser som representerar kurser, studenter, lärare, utbildningsledare, administratörer samt `Storage.cs` och `Menu.cs`.
  - **Storage.cs**: Hanterar lagring och läsning av data i JSON-format, vilket gör det möjligt att spara och återanvända kursinformation mellan programkörningar.
  - **Menu.cs**: Innehåller logik för att hantera användarmenyn, vilket gör det enkelt för användare att navigera genom applikationen.
- **data/**: Innehåller `courses.json` där kursinformation lagras.
- **Program.cs**: Huvudprogrammet som startar applikationen.
