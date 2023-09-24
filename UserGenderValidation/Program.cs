// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal küsida tema suga (M/F)
//rakendus küsib kasutajalt sisestada tema perekonnanime
//lähtudes kasutaja vastusest, rakendus tervitab kasutajat järgmiselt:
//"Welkome, Mr. [kasutaja perekonnanimi] / "Welkome, Ms. [kasutaja perekonnanimi]"

using System.ComponentModel.Design;

Console.WriteLine("Please, select your gender (m/f):");

char userGender = char.Parse(Console.ReadLine()); //leob konsoolist maha andmeid string(sõne) formaadis

Console.WriteLine("Please, enter your name:");
string userLastName = Console.ReadLine();


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}

else
{
    Console.WriteLine($"Welcome,  {userLastName}!");
}

