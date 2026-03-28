using System;

class Program
{
    static void Main(string[] args)
    {

        Menu menu = new Menu();
        bool done = false;

        do
        {  
        menu.ProcessMenu();
        done = menu.RunProgram();

        }while (!done);
    }
}