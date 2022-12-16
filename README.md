# ricerca-operativa

L'algoritmo Nord-Ovest è un algoritmo utilizzato per risolvere il problema del costo minimo di trasporto in una matrice di trasporto.
Il codice che hai fornito implementa l'algoritmo Nord-Ovest in C#, utilizzando una DataGridView per rappresentare la matrice di trasporto e un RichTextBox per visualizzare l'output.
L'algoritmo inizia con un ciclo while che continua finché la matrice ha più di una riga o più di una colonna. All'interno del ciclo, vengono determinati il valore più basso nell'ultima colonna della matrice (valorebasso) e il valore più alto nella prima riga (valoredestro). Se valoredestro è maggiore di valorebasso, il valore di costosingolo, che rappresenta il costo dell'elemento nella prima riga e prima colonna della matrice, viene moltiplicato per valorebasso e il risultato viene aggiunto al costototale. Il valore nella prima riga e ultima colonna della matrice viene aggiornato sottraendo valorebasso e la prima colonna della matrice viene rimossa. Se valorebasso è maggiore di valoredestro, il processo viene ripetuto sottraendo valoredestro dal valore nell'ultima colonna della matrice e rimuovendo l'ultima riga.
Il codice utilizza anche l'oggetto Color per colorare la cella del valore selezionato e l'oggetto Thread.Sleep per rallentare l'esecuzione dell'algoritmo.
Alla fine del ciclo, il costototale finale viene visualizzato nella RichTextBox.
