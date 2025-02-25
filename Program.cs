//definitions
using Microsoft.VisualBasic;

string destination;
string readying;
bool townRoute = false;
bool mountainRoute = false;
string playerName;
bool playerNameGet = false;
bool isReady = false;

//game start
Console.WriteLine("PRESS ENTER TO PROCEED");
ConsoleKey input = Console.ReadKey(true).Key;

if (input == ConsoleKey.Enter)


input = Console.ReadKey(true).Key;

//start adventure
Console.WriteLine("You awaken, in a strange, foggy landscape. The glassy floor under your feet stretches out for eternity.");
input = ConsoleKey.A;

if (input == ConsoleKey.Enter)
    Console.WriteLine("The mist, which covers this plane, rises to your ankles, then your knees.");
    input = ConsoleKey.A;
input = Console.ReadKey(true).Key;

if (input == ConsoleKey.Enter)
    Console.WriteLine("It's black out, but you can see. It's as the moonlight permeates the night.");
    input = ConsoleKey.A;
input = Console.ReadKey(true).Key;

if (input == ConsoleKey.Enter)
    Console.WriteLine("A booming voice calls out to you:");
    input = ConsoleKey.A;
input = Console.ReadKey(true).Key;

if (input == ConsoleKey.Enter)
    Console.WriteLine("\"I see you've made it here without issue.\" it says.");
input = ConsoleKey.L;
input = Console.ReadKey(true).Key;

if (input == ConsoleKey.Enter)
    Console.WriteLine("\"You've done well to make it this far. But the true struggle has yet to even begin.\"");

input = ConsoleKey.L;
input = Console.ReadKey(true).Key;

if (input == ConsoleKey.Enter)
    Console.WriteLine("\"I've brought you here to be a hero to this world. You will be it's saviour. It's last hope.\"");
input = ConsoleKey.L;
input = Console.ReadKey(true).Key;

if (input == ConsoleKey.Enter)
    Console.WriteLine("\"Your old life is behind you now. The time has come to throw it to the wind. Do you understand?\"");
input = ConsoleKey.L;
input = Console.ReadKey(true).Key;


//first choice
if (input == ConsoleKey.Enter)
    Console.WriteLine("Do you abandon it all? (Y/N)");
input = ConsoleKey.L;
input = Console.ReadKey(true).Key;
readying = Console.ReadLine();

{ if ((readying == "N") || (readying == "NO") || (readying == "n") || (readying == "no"))
    { Console.WriteLine("The voice pauses. For a very long time... \"Very well then.\" it replies, taken aback by your cowardice.");
    Console.WriteLine("\"You lack the courage of a hero.\" says the voice, it's barely-hidden vitriol oozing out as it speaks. \"Begone with you.\"");
        return;
    }

if ((readying == "Y") || (readying == "YES") || (readying == "y") || (readying == "yes"))
    {
        Console.WriteLine("I see. Then heed these words!");
        input = ConsoleKey.L;
        input = Console.ReadKey(true).Key;
        isReady = true;
    }
}
if (input == ConsoleKey.Enter)
    Console.WriteLine("Hero! The time is now! Reach out and grab the fate that lies before you! Stand proud, and call out the new name of this world's champion!");
input = ConsoleKey.L;
input = Console.ReadKey(true).Key;

playerName = Console.ReadLine();

if (input == ConsoleKey.Enter)
    Console.WriteLine($"\"{playerName}.. eh? So this world's saviour is named {playerName}! How wonderful! Ahaha!\" the being seemed endlessly amused with your silly name.");
input = ConsoleKey.L;
playerNameGet = true;
input = Console.ReadKey(true).Key;


if (input == ConsoleKey.Enter)
    Console.WriteLine("...");
input = ConsoleKey.L;
input = Console.ReadKey(true).Key;

if (input == ConsoleKey.Enter)
    Console.WriteLine("");
input = ConsoleKey.L;
input = Console.ReadKey(true).Key;



//dialogue line set 2 start
if (playerNameGet == true)
{
    if (input == ConsoleKey.Enter)
        Console.WriteLine("As you tread down the dirt path, a fork appears, splitting the road in two...");
    input = ConsoleKey.R;
    input = Console.ReadKey(true).Key;

    if (input == ConsoleKey.Enter)
        Console.WriteLine("You look ahead, and see that the path to your left leads to a small, vibrant wooded town.");
    input = ConsoleKey.L;
    input = Console.ReadKey(true).Key;

    if (input == ConsoleKey.Enter)
        Console.WriteLine("Turning around, you see that the path to your right connects to a mountain pass.");
    input = ConsoleKey.L;
    input = Console.ReadKey(true).Key;

    if (input == ConsoleKey.Enter)
        Console.WriteLine("Tell me, adventurer... which path calls to you? Where shall you go?");
    input = ConsoleKey.L;
    input = Console.ReadKey(true).Key;
    //dialogue set 1 end

    //player input 1


    if (input == ConsoleKey.Enter)
        Console.WriteLine("DO YOU GO 'LEFT', OR DO YOU GO 'RIGHT'? 'TOWN', OR 'MOUNTAIN'? INPUT YOUR CHOICE BELOW.");
    destination = Console.ReadLine();

    if ((destination == "LEFT") || (destination == "TOWN") || (destination == "town") || (destination == "left"))
    {
        townRoute = true;
        mountainRoute = false;
    }

    if ((destination == "RIGHT") || (destination == "MOUNTAIN") || (destination == "right") || (destination == "mountain"))
    {
        mountainRoute = true;
        townRoute = false;
    }



    if ((townRoute == true) && (mountainRoute == false))
    {
        Console.WriteLine("You walk into the town, and knowing you must soon face the perils of this new world, you look for somewhere warm to stay for the night.");
        input = ConsoleKey.R;
        input = Console.ReadKey(true).Key;

        if (input == ConsoleKey.Enter)
            Console.WriteLine("That's when you spot it; an old, tattered, wood-and-cobble cabin. Smoke billows outward from the chimney. Looks cozy.");
        input = ConsoleKey.L;
        input = Console.ReadKey(true).Key;

        if (input == ConsoleKey.Enter)
            Console.WriteLine("As you enter, the old innkeeper speaks up, his voice crackling like an old man's tends to do");
        input = ConsoleKey.L;
        input = Console.ReadKey(true).Key;

        if (input == ConsoleKey.Enter)
            Console.WriteLine("\"You ain't from 'round here, is ye?\" ");
        input = ConsoleKey.L;
        input = Console.ReadKey(true).Key;

        if (input == ConsoleKey.Enter)
            Console.WriteLine("\"Ye look real tattered.\" the old man muttered, almost instinctively after getting a good look at you.");
        input = ConsoleKey.L;
        input = Console.ReadKey(true).Key;
        //tell the old man your name

        if (input == ConsoleKey.Enter)
            Console.WriteLine("\"Do ye have a name, traveller?\".");
        input = ConsoleKey.L;
        input = Console.ReadKey(true).Key;

        if (input == ConsoleKey.Enter)
            Console.WriteLine("Do you tell the old innkeeper your name? (Y/N)");
        input = ConsoleKey.L;

        input = Console.ReadKey(true).Key;


        if (input == ConsoleKey.Y)
        {
            if (input == ConsoleKey.Enter)
                Console.WriteLine($"\"Heh! So they call ye {playerName}, aye? That's quite the name.");
            input = ConsoleKey.L;
            input = Console.ReadKey(true).Key;
        }
        else if (input == ConsoleKey.N)
        {
            if (input == ConsoleKey.Enter)
                Console.WriteLine("...");
            input = ConsoleKey.L;
            input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.Enter)
                Console.WriteLine("...It's alright, kid. Ye don't need to share it with me just yet.");
            input = ConsoleKey.L;
            input = Console.ReadKey(true).Key;
        }
        if ((mountainRoute == true) && (townRoute == false))
            Console.WriteLine("you in the mountain");
    }
}




