using System.Reflection;

int Scorpionhp = 100;
int Subzerohp = 100;

string Scorpionname = "SCORPION";
string Subzeroname = "SUBZERO";

while (Scorpionhp > 0 && Subzerohp > 0)
{
  Console.WriteLine("_____MORTAL_KOMBAT_____(Bad version)");
  Console.WriteLine($"{Scorpionname}: {Scorpionhp} {Subzeroname}: {Subzerohp}");


int ScorpionDamage = Random.Shared.Next(10);
Subzerohp -= ScorpionDamage;
Subzerohp = Math.Max(0, Subzerohp);
Console.WriteLine($"{Scorpionhp} {ScorpionDamage} damege {Subzerohp}");

int SubzeroDamage = Random.Shared.Next(10);
Scorpionhp -= SubzeroDamage;
Scorpionhp = Math.Max(0, Scorpionhp);
Console.WriteLine($"{Subzerohp} {SubzeroDamage} damege {Scorpionhp}");

Console.WriteLine("Press any button to START");
Console.ReadLine();


// Console.WriteLine("Hello, Bradar!");
// int damage = Random.Shared.Next(5, 11);
// Console.WriteLine(damage);

     }

     Console.WriteLine("\n GAME OVER ");

     if (Scorpionhp == 0 && Subzerohp == 0)
{
  Console.WriteLine("Friendtality!-no one wins");
}

else if (Scorpionhp == 0)
{
  Console.WriteLine($"Fatality! {Subzeroname} won");
}
else if(Subzerohp == 0)
{
  Console.WriteLine($"Fatality! {Scorpionname} won");
}

Console.WriteLine("Press any button to exit");
Console.ReadLine();