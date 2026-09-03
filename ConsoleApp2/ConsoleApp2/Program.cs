using Microsoft.Win32.SafeHandles;

Console.WriteLine("(information before playing, har fåt tillstång av reyansh innan spelat var gjord) Hej, idag är du Reyansh. Du ska gå till skolan och i vägen ser du några som spelar fotbol. Ska du vara med eller gå till skolan? Om du vill spela fotbol svara ja, om du vill gå till skolan svara nej ");

//bool t = 4 != 4 || 3 < 6; 

string choice = Console.ReadLine();

choice = choice.ToLower();



if (choice == "ja")
{
    Console.WriteLine("När du spela fotbol blev du halal slaktad eftersom folk trode att det var en kosa i planen, du kan spawna tillbaka som en kosa eller myra?, skriv kosa om du vill bli en kosa eller skriv myra för att bli en myra!");
   string choice2 = Console.ReadLine();
   choice2 = choice2.ToLower();
    if (choice2 == "kosa")
    {
        Console.WriteLine("Du kom tillbaka och spawna i Turkiet, nästa dag blev du en kebab för ali baba, Game Over Son!");
        Console.ReadLine();
    }
    else if (choice2 == "myra")
    {
        Console.WriteLine("Du blev spawnad som en kung av alla myror!, du ger order till dina soldater att ta över Pakistan, allt ser bra ut för dig, sedan kommer en stor skugga... någon trampade på dig och din arme, Game Over");
        Console.ReadLine();
    }

}

else if (choice == "nej")
{
    Console.WriteLine("Du gick till skolan och ska göra ett mate prov ska du fuska eller acceptera ödet? skriv fusk för att fuska, skriv bismillah för att acceptera ödet");
    string choice3 = Console.ReadLine();
choice3 = choice3.ToLower();
    if (choice3 == "fusk")
    {
        Console.WriteLine("Du valde att fuska och allt gick bra i provet, sedan så helt plötsligt stängs Chatgpt eftersom att den orkar inte med otydliga frågor, Obada såg dig fuska och sa till läraren, du blev kastad ut ur fönstret, Game Over");
            Console.ReadLine();
    }
    else if (choice3 == "bismillah")
    {
        Console.WriteLine("Du gick ut ur provet och väntade en vecka. En vecka senare kom betygen, farsan tog datorn och kollade, farsan tittade på dig och sedan kasta dig ut ur fönstret av 20de våningen av huset. Game Over ");
        Console.ReadLine();
    }

}
else if (choice == "kanske")
{
    Console.WriteLine("Du dog av emotional damege, tyvär, Game Over");
}

     

Console.ReadLine();