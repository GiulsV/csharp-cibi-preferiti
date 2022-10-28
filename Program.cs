//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");

////Esercizio mattino
//Console.WriteLine("Esercizio mattino");
////Array
//string[] cibiPreferiti = { "Cioccolato", "Pasta", "Pane", "Mandarini", "Fragole", "Peperoni", "Zucchine" };
////Salva e stampa lunghezza array
//int cibiPreferitiLength = cibiPreferiti.Length;
//Console.WriteLine("Lunghezza classifica: " + cibiPreferitiLength);
////Stampa array con posizione in classifica 
//Console.WriteLine("Classifica:");
//for (int i = 0; i < cibiPreferitiLength; i++)
//{
//Console.WriteLine(i + 1 + ". " + cibiPreferiti[i]);
//}
////Stampa cibo preferito/meno preferito
//Console.WriteLine("Cibo preferito: " + cibiPreferiti[0]);
//Console.WriteLine("Cibo meno preferito: " + cibiPreferiti[cibiPreferitiLength - 1]);
////Bonus
////caso array pari
//if (cibiPreferitiLength % 2 == 0)
//{
//int medianaSuperiore = cibiPreferitiLength / 2;
//int medianaInferiore = medianaSuperiore - 1;
//Console.WriteLine("Cibi di mezzo: " + cibiPreferiti[medianaSuperiore] + " e " + cibiPreferiti[medianaInferiore]);
//}
//else
//{
//int mediana = cibiPreferitiLength / 2;
//Console.WriteLine("Cibo di mezzo: " + cibiPreferiti[mediana]);
//}


////Esercizi pomeriggio
////Snack1. L’utente inserisce due numeri in successione. Il software stampa il maggiore.
//Console.WriteLine("Snack1");
//Console.WriteLine("Inserisci primo numero");
//int firstNumber = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Inserisci secondo numero");
//int secondNumber = Convert.ToInt32(Console.ReadLine());

//if (firstNumber > secondNumber)
//{
//Console.WriteLine("Il maggiore è: " + firstNumber);
//}
//else
//{
//Console.WriteLine("Il maggiore è: " + secondNumber);
//}

//////Snack2.L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.
//Console.WriteLine("Snack2");
//Console.WriteLine("Inserisci prima parola");
//string firstWord = Console.ReadLine();

//Console.WriteLine("Inserisci seconda parola");
//string secondWord = Console.ReadLine();

//if (firstWord.Length < secondWord.Length)
//{
//    Console.WriteLine("Parola più corta " + firstWord + ", più lunga " + secondWord);
//}
//else
//{
//    Console.WriteLine("Parola più corta " + secondWord + ", più lunga " + firstWord);
//}


////Snack3.Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.

//Console.WriteLine("Snack3");
//int[] number = new int[10];
//int sum = 0;
//for (int i = 0; i < number.Length; i++)
//{
//    Console.WriteLine("Inserisci un numero:");
//    number[i] = Convert.ToInt32(Console.ReadLine());
//    sum = sum + number[i];
//}
//Console.WriteLine("La somma è: " + sum);


//////Snack4. Calcola la somma e la media dei numeri da 2 a 10.
//Console.WriteLine("Snack4");
//int[] numeri = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int somma = 0;
//double media;
//for (int i = 0; i < numeri.Length; i++)
//{
//    somma = somma + numeri[i];
//}
//media = somma / numeri.Length;
//Console.WriteLine("Somma: " + somma);
//Console.WriteLine("Media: " + media);

////Snack5.Il software chiede all’utente di inserire un numero. Se il numero inserito è pari,stampa il numero, se è dispari, stampa il numero successivo.
//Console.WriteLine("Snack5");
//Console.WriteLine("Inserisci un numero");
//int numeroUtente = Convert.ToInt32(Console.ReadLine());
//if (numeroUtente % 2 == 0)
//{
//    Console.WriteLine("Il numero inserito è pari: " + numeroUtente);
//}
//else
//{
//    Console.WriteLine("Il numero inserito è dispari, " + (numeroUtente + 1) + " è il numero successivo");
//}

////Snack6.In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
//Console.WriteLine("Snack6");
//string[] nameList = { "Jay Gatsby", "Nick Carraway", "Tom Buchanan", "Daisy Buchanan" };
//Console.WriteLine("Inserisci il tuo nome");
//string nome = Console.ReadLine();
//bool invitato = false;
//for (int i = 0; i < nameList.Length; i++)
//{
//    if (nome == nameList[i])
//    {
//        invitato = true;
//    }
//}
//if (invitato)
//{
//    Console.WriteLine("Puoi partecipare alla festa");
//}
//else
//{
//    Console.WriteLine("Non puoi partecipare alla festa");
//}

////Snack7.Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
//Console.WriteLine("Snack7");
//int[] numberArray = new int[6];
//Console.WriteLine("inserisci 6 numeri");
//for (int i = 0; i < numberArray.Length; i++)
//{
//int userNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"elemento dell'array prima della modifica: {i} - {numberArray[i]}");

//    if (userNumber % 2 != 0)
//    {
//        numberArray[i] = userNumber;
//        Console.WriteLine($"elemento dell'array dopo la modifica: {i} - {numberArray[i]}");
//    }
//}


////Snack8. Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
//Console.WriteLine("Snack8");

//int[] numeriDispari = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int sommaDispari = 0;
//for (int i = 0; i < numeriDispari.Length; i++)
//{
//    if (i  % 2 != 0)
//    {
//        sommaDispari += numeriDispari[i];
//    }
//}
//Console.WriteLine("La somma è: " + sommaDispari);

////Snack9.Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array,
////fino a quando la somma degli elementi è minore di 50.
//Console.WriteLine("Snack9");
//int sommaMinore = 0;
//while (sommaMinore < 50)
//{
//    Console.WriteLine("Inserisci un numero");
//    sommaMinore += Convert.ToInt32(Console.ReadLine());
//}


////Snack10.Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
////Ogni volta che ne crei uno, stampalo a schermo.
//Console.WriteLine("Snack10");
//Console.WriteLine("Inserisci un numero");
//int N = Convert.ToInt32(Console.ReadLine());
//var rand = new Random();
//for (int i = 0; i < N; i++)
//{
//    int[] array = new int[10];
//    Console.WriteLine("L'array numero " + (i + 1) + " è: ");
//    for (int a = 0; a < 10; a++)
//    {
//        array[a] = rand.Next(1, 100);
//        Console.Write(array[a] + " , ");
//    }
//    Console.WriteLine();
//}


//Snack 11
//Dare la possibilità di inserire due parole. Verificare tramite una funzione che le due parole abbiano la stessa lunghezza. Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.
Console.WriteLine("Snack11");

Console.WriteLine("Inserisci prima parola");
string primaParola = Console.ReadLine();

Console.WriteLine("Inserisci seconda parola");
string secondaParola = Console.ReadLine();

string parolaPiuLunga = " ";

string ControlloLunghezzaParole(string parola1, string parola2)
{
    if (parola1.Length == parola2.Length)
    {
        parolaPiuLunga ="Parole di uguale lunghezza: " + parola1 + ", " + parola2;
        return parolaPiuLunga;
    }
    else if (parola1.Length > parola2.Length)
    {
        return "Prima parola inserita è più lunga: " + parola1;
    }
    else {
        return "Seconda parola inserita è più lunga: " + parola2;    
    }
}
Console.WriteLine(ControlloLunghezzaParole(primaParola, secondaParola));

//Snack 12
//Scrivere una funzione per verificare se un numero è pari o dispari. Quindi chiedere un numero all’utente e comunicargli se è pari o dispari.
Console.WriteLine("Snack12");

Console.WriteLine("Inserisci un numero");
int numeroScelto = Convert.ToInt32(Console.ReadLine());
string PariDispari(int numero) 
{
    if (numero % 2 == 0) 
    {
        return "Il numero è pari";
    }
    else
    {
        return "Il numero è dispari";
    }
}

Console.WriteLine(PariDispari(numeroScelto));