// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibiPreferiti = { "Pasta", "Cioccolato", "Pane", "Mandarini", "Fragole", "Peperoni", "Zucchine" };

int cibiPreferitiLength = cibiPreferiti.Length;
Console.WriteLine("La lunghezza della classifica è: " + cibiPreferitiLength);
Console.WriteLine("Classifica:");
for (int i = 0; i < cibiPreferitiLength; i++)
{
    Console.WriteLine(i + 1 + ") " + cibiPreferiti[i]);
}
Console.WriteLine("Il mio cibo preferito è: " + cibiPreferiti[0]);
Console.WriteLine("Il mio cibo meno preferito è: " + cibiPreferiti[cibiPreferitiLength - 1]);
