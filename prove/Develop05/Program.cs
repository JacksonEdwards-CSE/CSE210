using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("WELCOME TO ETERNAL QUEST!\n\nComplete quests to gain points and level up;\nEvery time you level up the point requirement increases by 50 points.\n\nGood Luck, Have Fun!\nPRESS ENTER TO PLAY");
        Console.ReadLine();

        Menu menu = new Menu();
        bool done = false;

        do
        {  
        menu.ProcessMenu();
        done = menu.RunProgram();

        }while (!done);
    }
}