# PSSC-2018
Modelul arhitectural MVC (Model – View - Controller)
MVC este un model architectural folosit pentru a implementa interfete utilizator, fiind foarte popular printre dezvoltatorii de aplicatii web. MVC separa logica unei aplicatii in 3 parti, promovand modularitatea, colaborarea mai usoara si reutilizarea codului.
Modelul defineste ce date trebuie sa contina aplicatia. Daca starea acestor date se schimba, atunci modelul va notifica view-ul – asa incat acesta datele afisate sa fie cele schimbate si controller-ul – daca este nevoie de o schimbare a logicii care sa actualizeze view-ul. Obiectele de tipul modelului regasesc si stocheaza starea modelului intr-o baza de date.
View-ul defineste felul in care datele  aplicatiei vor fi afisate. Este interfata utilizator in case se afiseaza datele utilizand datele din model si permitand utilizatorului sa modifice date. Este practic singurul lucru pe care il vede utilizatorul.
Controller-ul contine logica ce va prelucra modelul si va actualiza view-ul ca raspuns la datele introduse de utilizatorii aplicatiei. El prelucreaza cerintele venite de la utilizator.
In general, utilizatorul face un request prin intermediul View-ului, care va fi procesat de controller. Controller-ul  prelucreaza request-ul folosind datele din model. 
  
 O analogie:
Daca un american ar incerca sa pregateasca cina de Ziua Recunostintei folosind framework-ul MVC, ar proceda in felul urmator:
Ar folosi drept Model frigiderul, cu ingredientele necesare prepararii fiecarei retete.
Reteta este Controller-ul, ea dictand ce ingrediente (date din Model) din frigider ar trebui folosite, ordinea in care se adauga si cat este necesar sa fie gatite.
Apoi am avea masa si felul in care tacamurile sunt asezate drept View. Masa permite invitatilor la cina sa interactioneze cu Modelul si Controller-ul.


