# WestCoast Education Kursförvaltningssystem

## Översikt
En .NET Console-applikation för WestCoast Education som hanterar kurser, studenter, lärare, utbildningsledare och administratörer. Stöder både traditionell och onlineutbildning.

## Funktioner

### Kursförvaltning
- Lägg till, redigera, ta bort och lista kurser.
- Visa kursdetaljer.

### Studentförvaltning
- Lägg till, redigera, ta bort och lista studenter.

### Lärarförvaltning
- Lägg till, redigera, ta bort och lista lärare och deras kurser.

### Utbildningsledare
- Hantera utbildningsledares information.

### Administratörsförvaltning
- Hantera administratörsprofiler och systemoperationer.

## Projektstruktur
- **Models/**: Klasser för kurser, studenter, lärare, utbildningsledare och administratörer samt `Storage.cs` och `Menu.cs`.
- **Storage.cs**: Hanterar JSON-lagring.
- **Menu.cs**: Användarmenyn.
- **data/**: Innehåller `courses.json`.
- **Program.cs**: Huvudprogrammet.

