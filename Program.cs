//Mauricio Acosta
//10-18-22
//GitHubChallange MadLib

Console.Clear();

string playAgain = "yes";
while (playAgain == "yes")
{




string name;
string name1;
string animal;
string color;
string place;
string toy;
string toy1;
string TVShow;
string food;
string food1;
string name2;


Console.WriteLine("Provide a name: ");
name = Console.ReadLine();
Console.WriteLine("Provide another name: ");
name1 = Console.ReadLine();
Console.WriteLine("Provide a animal: ");
animal = Console.ReadLine();
Console.WriteLine("Provide a color: ");
color = Console.ReadLine();
Console.WriteLine("Provide a place: ");
place = Console.ReadLine();
Console.WriteLine("Provide toy: ");
toy = Console.ReadLine();
Console.WriteLine("Provide another toy: ");
toy1 = Console.ReadLine();
Console.WriteLine("Provide a Tv Show: ");
TVShow = Console.ReadLine();
Console.WriteLine("Provide a food: ");
food = Console.ReadLine();
Console.WriteLine("Provide another food: ");
food1 = Console.ReadLine();
Console.WriteLine("Provide another name: ");
name2 = Console.ReadLine();






string story = " Hello im " + name + " and this is " + name1 + " He is a " + animal
+ " and his favorite color is " + color +" " + name1 + " and i love to play "
+ " at the " + place + " we usually bring a " + toy + " and a " + toy1 
+ " in case we get bored, we also like to watch " + TVShow 
+ " our favorite foods are " + food + " and " + food1 + " and usually at the end "
+ " of the day i let " + name1 + " go out and play with our neighbors dog " + name2;

Console.WriteLine("Story Loading...");
Console.WriteLine(story);

Console.WriteLine("Type yes to play again");
playAgain = Console.ReadLine();
}