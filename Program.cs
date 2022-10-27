// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Esercizio mattino
////Array
//string[] cibiPreferiti = { "Cioccolato", "Pasta", "Pane", "Mandarini", "Fragole", "Peperoni", "Zucchine" };
////Salva e stampa lunghezza array
//int cibiPreferitiLength = cibiPreferiti.Length;
//Console.WriteLine("Lunghezza classifica: " + cibiPreferitiLength);
////Stampa array con posizione in classifica 
//Console.WriteLine("Classifica:");
//for (int i = 0; i < cibiPreferitiLength; i++){
//    Console.WriteLine(i + 1 + ". " + cibiPreferiti[i]);
//}
////Stampa cibo preferito/meno preferito
//Console.WriteLine("Cibo preferito: " + cibiPreferiti[0]);
//Console.WriteLine("Cibo meno preferito: " + cibiPreferiti[cibiPreferitiLength - 1]);
////Bonus
//    //caso array pari
//if (cibiPreferitiLength % 2 == 0){
//    int medianaSuperiore = cibiPreferitiLength / 2;
//    int medianaInferiore = medianaSuperiore - 1;
//    Console.WriteLine("Cibi di mezzo: " + cibiPreferiti[medianaSuperiore] + " e " + cibiPreferiti[medianaInferiore]);
//}else{
//    int mediana = cibiPreferitiLength / 2;
//    Console.WriteLine("Cibo di mezzo: " + cibiPreferiti[mediana]);
//}

//Esercizio pomeriggio
//Snack1. L’utente inserisce due numeri in successione. Il software stampa il maggiore.
Console.WriteLine("Snack1");
Console.WriteLine("Inserisci primo numero");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserisci secondo numero");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber){
    Console.WriteLine("Il maggiore è: " + firstNumber);
}else{
    Console.WriteLine("Il maggiore è: " + secondNumber);
}

//Snack2.L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.
Console.WriteLine("Snack2");
Console.WriteLine("Inserisci prima parola");
string firstWord = Console.ReadLine();

Console.WriteLine("Inserisci seconda parola");
string secondWord = Console.ReadLine();

if (firstWord.Length < secondWord.Length){
    Console.WriteLine("Parola più corta " + firstWord + ", più lunga " + secondWord);
}else{
    Console.WriteLine("Parola più corta " + secondWord + ", più lunga " + firstWord);
}