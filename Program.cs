// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Array
string[] cibiPreferiti = { "Pasta", "Cioccolato", "Pane", "Mandarini", "Fragole", "Peperoni", "Zucchine" };

//Lunghezza array
int cibiPreferitiLength = cibiPreferiti.Length;

//Stampa lunghezza array
Console.WriteLine("Lunghezza classifica: " + cibiPreferitiLength);

//Stampa array
Console.WriteLine("Classifica:");

//Stampa posizione in classifica
for (int i = 0; i < cibiPreferitiLength; i++){

    Console.WriteLine(i + 1 + ". " + cibiPreferiti[i]);

}

//Stampa cibo preferito
Console.WriteLine("Cibo preferito: " + cibiPreferiti[1]);

//Stampa cibo meno preferito
Console.WriteLine("Cibo meno preferito: " + cibiPreferiti[cibiPreferitiLength - 1]);

//Bonus
    //caso array pari
if (cibiPreferitiLength % 2 == 0){

    Console.WriteLine("Cibi di mezzo: " + cibiPreferiti[cibiPreferitiLength / 2 - 1] + " e " + cibiPreferiti[cibiPreferitiLength / 2]);

}
else{

    Console.WriteLine("Cibo di mezzo: " + cibiPreferiti[(cibiPreferitiLength - 1) / 2]);

}