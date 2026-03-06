using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Clear();
       Menu menu = new Menu();
       bool done = false;
       int userChoice;

        do{

            userChoice = menu.ProcessMenu();

            switch (userChoice)
            {
                case 1:

                    menu.WriteEntry(); 
                    
                    break;

                case 2:

                    menu.DefineEmotion();

                    break;
                
                case 3:

                    menu.DisplayJournal();

                    break;

                case 4:

                    menu.ReadFile();

                    break;

                case 5:

                    menu.WriteFile();

                    break;

                case 6:

                    done = true;

                    break;
                
            }

        } while (done != true);

    }
}