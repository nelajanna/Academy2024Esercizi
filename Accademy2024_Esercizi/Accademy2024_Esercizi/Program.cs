//Console.WriteLine("Calcolatore del perimetro e dell'area di un rettangolo");

//Console.Write("Inserisci la base del rettangolo: ");
//string baseSideInput= Console.ReadLine();
//double baseSide = double.Parse(baseSideInput);

//Console.Write("Inserisci l'altezza del rettangolo: ");
//string heightSideInput = Console.ReadLine();
//double heightSide = double.Parse(heightSideInput);

//double p = (baseSide + heightSide) * 2;
//double a = baseSide * heightSide;

//Console.Write("Perimetro: ");
//Console.WriteLine(p);
//Console.Write("Area: ");
//Console.WriteLine(a);


//ESERCIZIO 1:
/* 
   Creare un programma che prenda in input dall'utente i due lati di un triangolo rettangolo e 
   che vada a calcolare l'ipotenusa del triangolo tramite il teorema di pitagora:
   ipotenusa = sqrt( c1*c1 + c2*c2)
   Stampare il risultato all'utente.
 */

//Console.WriteLine("Calcolatore dell'ipotenusa di un triangolo rettangolo");

//Console.Write("Inserire la lunghezza in cm dell'Catete1: ");
//string c1Input= Console.ReadLine();
//double c1 = double.Parse(c1Input);

//Console.Write("Inserire la lunghezza in cm del Catete2: ");
//string c2Input = Console.ReadLine();
//double c2 = double.Parse(c2Input);

//double i = Math.Sqrt(c1 * c1 + c2 * c2);

//Console.Write("L'ipotenusa del triangolo é: ");
//Console.Write(i);



//ESERCIZIO 2
/*
  creare un programma nel quale vengono presi in input due numeri dall'utente,
  dopodichè dire all'utente quale tra i due è il maggiore o se sono uguali.
*/


Console.WriteLine("Calcolatore di maggioranza");

Console.Write("Inserisci il primo numeoro: ");
string n1Input = Console.ReadLine();
double n1 = double.Parse(n1Input);

Console.Write("Inserisci il secondo numero: ");
string n2Input = Console.ReadLine();
double n2 = double.Parse(n2Input);

if (n1 > n2)
{
    Console.WriteLine($"Il numero {n1} è il maggiore");
}
else if (n2 > n1) 
{
    Console.WriteLine($"Il numero {n2} è il maggiore");
}
else
{
    Console.WriteLine($"I numeri sono uguali");
}
    
    

    





