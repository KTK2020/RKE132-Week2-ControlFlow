// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanus
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul 
//konsoolis kuvatakse "Welkom to Instagram

Console.WriteLine("enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else //if (usarAge < 13)
{
    Console.WriteLine("You are too young to use Instagram.");
}