// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Array
string[] cibiPreferiti = { "Cioccolato", "Pasta", "Pane", "Mandarini", "Fragole", "Peperoni", "Zucchine" };

//Salva e stampa lunghezza array
int cibiPreferitiLength = cibiPreferiti.Length;
Console.WriteLine("Lunghezza classifica: " + cibiPreferitiLength);

//Stampa array con posizione in classifica 
Console.WriteLine("Classifica:");
for (int i = 0; i < cibiPreferitiLength; i++){
    Console.WriteLine(i + 1 + ". " + cibiPreferiti[i]);
}

//Stampa cibo preferito/meno preferito
Console.WriteLine("Cibo preferito: " + cibiPreferiti[0]);
Console.WriteLine("Cibo meno preferito: " + cibiPreferiti[cibiPreferitiLength - 1]);

//Bonus
    //caso array pari
if (cibiPreferitiLength % 2 == 0){
    int medianaSuperiore = cibiPreferitiLength / 2;
    int medianaInferiore = medianaSuperiore - 1;
    Console.WriteLine("Cibi di mezzo: " + cibiPreferiti[medianaSuperiore] + " e " + cibiPreferiti[medianaInferiore]);
}else{
    int mediana = cibiPreferitiLength / 2;
    Console.WriteLine("Cibo di mezzo: " + cibiPreferiti[mediana]);
}