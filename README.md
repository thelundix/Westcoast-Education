# WestCoast Education Kursförvaltningssystem

## Översikt
Denna .NET Console-applikation är utformad för WestCoast Education, en utbildningsinstitution i Sverige. Den hanterar kurser, studenter, lärare, utbildningsledare och administratörer och stödjer både traditionell och onlineutbildning.

## Funktioner

### Kursförvaltning
- Lägg till, redigera och ta bort kurser.
- Lägg till nya kurser.
- Visa kursdetaljer (längd, datum, typ).
- Lista kurser.

### Studentförvaltning
- Lägg till, redigera och ta bort studenter.
- Lägg till nya studerande.
- Lista studenter.

### Lärarförvaltning
- Lägg till, redigera och ta bort lärare.
- Lägg till nya lärare.
- Lista lärare och deras kurser.

### Utbildningsledare
- Lägg till, redigera och ta bort utbildningsledare.
- Hantera utbildningsledares information.
  
### Administratörsförvaltning
- Hantera administratörsprofiler och systemoperationer.
- Lägg till nya administratörer.

## Projektstruktur
- **Models/**: Innehåller klasser som representerar:
  
  ### Kurser
  Behöver hantera data som t.ex.:
  - **Kursnummer**
  - **Titel**
  - **Längd** (antal veckor eller dagar)
  - **Start- och slutdatum**

  ### Studerande
  Behöver hantera data som t.ex.:
  - **Förnamn**
  - **Efternamn**
  - **Telefon**
  - **Personnummer**
  - **Adress**
  - **Postnummer**
  - **Ort**

  ### Lärare
  Behöver hantera samma data som studerande, och dessutom:
  - **Kunskapsområde**
  - **Vilka kurser som läraren är ansvarig för**

  ### Utbildningsledare
  Behöver hantera samma information som lärare, och dessutom:
  - **Anställningsdatum**

  ### Administratörer
  Behöver hantera samma information som utbildningsledare.

- **Storage.cs**: Hanterar lagring och läsning av data i JSON-format.
- **Menu.cs**: Hanterar användarmenyn.
- **data/**: Innehåller `courses.json` där kursinformation lagras.
- **Program.cs**: Huvudprogrammet som startar applikationen.

