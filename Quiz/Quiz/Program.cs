﻿using Microsoft.Win32.SafeHandles;
int points = 0;

Console.WriteLine("Land quiz (instruktioner svara bara svaren som b eller a det betyder att du ska bara ge bokstävan som står för de svaret du cill svara med)");

Console.WriteLine(",Vad är det största landet i världen?");

Console.WriteLine("a: Sverige    b: Kina   c: Ryssland");

string anwser1 = Console.ReadLine();

if (anwser1 == "c")
{
    points++;
    Console.Write("Ja rätt svar, + 1 poäng");

}
else
{
    Console.WriteLine("Fel svar, 0 poäng");   
 }
Console.WriteLine(",Vilket land är känt för pyramider");
Console.WriteLine("a: Albanien   b: Sudan   c: Egypten");
string anwser2 = Console.ReadLine();

if (anwser2 == "c")
{
    points++;
    Console.Write("Ja rätt svar, + 1 poäng");

}
else
{
    Console.WriteLine("Fel svar, 0 poäng");   
 }


 Console.WriteLine(",Vad är det minsta landet?");
Console.WriteLine("a: Vatikan   b: Danmark   c: San marino");
string answer3 = Console.ReadLine();
if (answer3 == "a")
{
  points++;
  Console.WriteLine("Ja + 1 poäng");
}
else
{
  Console.WriteLine("Fel 0 poäng");
}


Console.WriteLine($"Du fick {points} poäng.");
if (points == 0)
{
  Console.WriteLine("Gör om quizet tycker jag");
}
else if (points < 3)
{
  Console.WriteLine("Bra svar men kan ha gjort bättre");
}
else 
{
  Console.WriteLine("Alla rätt!");
}

Console.WriteLine("Tryck på vilken knapp du vill för att börja om");
Console.ReadKey();
