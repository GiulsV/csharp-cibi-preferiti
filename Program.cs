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
//Console.WriteLine("Snack1");
//Console.WriteLine("Inserisci primo numero");
//int firstNumber = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Inserisci secondo numero");
//int secondNumber = Convert.ToInt32(Console.ReadLine());

//if (firstNumber > secondNumber){
//    Console.WriteLine("Il maggiore è: " + firstNumber);
//}else{
//    Console.WriteLine("Il maggiore è: " + secondNumber);
//}

////Snack2.L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.
//Console.WriteLine("Snack2");
//Console.WriteLine("Inserisci prima parola");
//string firstWord = Console.ReadLine();

//Console.WriteLine("Inserisci seconda parola");
//string secondWord = Console.ReadLine();

//if (firstWord.Length < secondWord.Length){
//    Console.WriteLine("Parola più corta " + firstWord + ", più lunga " + secondWord);
//}else{
//    Console.WriteLine("Parola più corta " + secondWord + ", più lunga " + firstWord);
//}


//Snack3.Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.

//Console.WriteLine("Snack3");
//int[] number = new int[10];
//int sum = 0;
//for (int i = 0; i < number.Length; i++){
//    Console.WriteLine("Inserisci un numero:");
//    number[i] = Convert.ToInt32(Console.ReadLine());
//    sum = sum + number[i];
//}
//Console.WriteLine("La somma è: " + sum);


////Snack4. Calcola la somma e la media dei numeri da 2 a 10.
//Console.WriteLine("Snack4");
//int[] numeri = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int somma = 0;
//double media;
//for (int i = 0; i < numeri.Length; i++){
//    somma = somma + numeri[i];
//}
//media = somma / numeri.Length;
//Console.WriteLine("Somma: " + somma);
//Console.WriteLine("Media: " + media);

//Snack5.Il software chiede all’utente di inserire un numero. Se il numero inserito è pari,stampa il numero, se è dispari, stampa il numero successivo.

Console.WriteLine("Inserisci un numero");
int numeroUtente = Convert.ToInt32(Console.ReadLine());
if (numeroUtente % 2 == 0){
    Console.WriteLine("Il numero inserito è pari: " + numeroUtente);
}else{
    Console.WriteLine("Il numero inserito è dispari, " + (numeroUtente + 1) + " è il numero successivo");
}
