// See https://aka.ms/new-console-template for more inform
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
//var - player enemy, enemy hp player hp, player attack / block, enemy always attackhp - damage

bool continu = true;
Console.WriteLine("What is your name adventurer");
string player = Console.ReadLine();
Console.WriteLine($"Welcome {player} today you will fight a troll\ntrolls have 50 hp and wield a club (2d6)\nyou have 25 hp and wield a dagger(xdy)");

int block = dmg("2d4");
int playerhp = 25;
int monsterhp = 50;

while (continu)
{
    int monsterdmg = dmg("2d6");
    Console.WriteLine("would you like to\n1. attack\n2. heal 2d4 hp (monster can still attack)");
    string userchoice = Console.ReadLine();

    if (userchoice == "1")
    {
        Console.WriteLine("how many dice of how many sides will you throw (xdy)\nx = number of dice\ny= number of sides");
        int playerdmg = dmg(Console.ReadLine());
        playerhp -= monsterdmg;
        monsterhp -= playerdmg;
    }
    else if(userchoice == "2")
    {
        playerhp -= monsterdmg - block;
    }
    else { playerhp -= monsterdmg; }

    if (playerhp > 0 && monsterhp <= 0) { continu = false; Console.WriteLine($"you bet the monster, looks like you will be a great warrior {player}"); }
    else if (monsterhp > 0 && playerhp <= 0) { continu = false; Console.WriteLine($"you lost to the monster better luck next time"); }
    else if (monsterhp <=0 && playerhp <= 0) { continu = false; Console.WriteLine($"you have both died, try not to do that next time"); }
    else
    {
        Console.WriteLine($"{player} you have {playerhp} hp left, the monster has {monsterhp}");
    }
}
static int dmg(string input)
{
    Random rnd = new Random();
    string[] diceval = input.Split('d','+');
    int numofdice = int.Parse(diceval[0]);
    int dicesides = int.Parse(diceval[1]);
    //int extra = int.Parse(diceval[2]);
    int damage = 0;
    for (int i = 0; i < numofdice; i++)
    {
        int dice = rnd.Next(1, dicesides + 1);
       // Console.WriteLine($"you have thrown {dice} on your {i + 1} dice");
        damage += dice;
    }
    //amage =+ extra;
    return damage;
}