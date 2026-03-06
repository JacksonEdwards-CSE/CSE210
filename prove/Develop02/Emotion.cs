
class Emotion
{
    public string _dateTime;

    public int _category;
    public string _categoryName;

    public string _specificName;

    public string _explanation;

    public void GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _dateTime = theCurrentTime.ToShortDateString();
    }

    public void GetCategory()
    {
        do{

          Console.WriteLine("What category does your overall emotion fall into for today?\n1. Happy\n2. Sad\n3. Angry\n4. Scared\n5.Unmotivated\n");

          _category = int.Parse(Console.ReadLine());

          Console.WriteLine();

        }while(_category < 1 || _category > 5);
        
    }

    public void GetSpecific()
    {
        int specific;

        Console.WriteLine("Now how are you specifically feeling?");

        switch (_category)
        {
            case 1:

                _categoryName = "Happy";

                do
                {
                    
                Console.WriteLine("1. Content\n2. Joyful\n3. Proud\n4. Grateful\n5. Excited\n");
                specific = int.Parse(Console.ReadLine());

                Console.WriteLine();

                }while(specific < 1 || specific > 5);

                switch (specific)
                {
                    case 1:

                        _specificName = "Content";

                        break;
                    
                    case 2:

                        _specificName = "Joyful";

                        break;
                    
                    case 3:
                    
                        _specificName = "Proud";

                        break;
                    
                    case 4:
                    
                        _specificName = "Grateful";

                        break;
                    
                    case 5:
                    
                        _specificName = "Excited";

                        break;
                    
                }

            break;

            case 2:

                _categoryName = "Sad";

                do
                {
                    
                Console.WriteLine("1. Disappointed\n2. Lonely\n3. Heartbroken\n4. Hopeless\n5. Gloomy\n");
                specific = int.Parse(Console.ReadLine());

                Console.WriteLine();

                }while(specific < 1 || specific > 5);

                switch (specific)
                {
                    case 1:

                        _specificName = "Disappointed";

                        break;
                    
                    case 2:

                        _specificName = "Lonely";

                        break;
                    
                    case 3:
                    
                        _specificName = "Heartbroken";

                        break;
                    
                    case 4:
                    
                        _specificName = "Hopeless";

                        break;
                    
                    case 5:
                    
                        _specificName = "Gloomy";

                        break;

                }
                    
                break;

            case 3:

                _categoryName = "Angry";

                do
                {

                Console.WriteLine("1. Frustrated\n2. Irritated\n3. Resentful\n4. Furious\n5. Offended\n");
                specific = int.Parse(Console.ReadLine());

                Console.WriteLine();
                    
                } while(specific < 1 || specific > 5);

                switch (specific)
                {
                    case 1:

                        _specificName = "Frustrated";

                        break;
                    
                    case 2:

                        _specificName = "Irritated";

                        break;
                    
                    case 3:
                    
                        _specificName = "Resentful";

                        break;
                    
                    case 4:
                    
                        _specificName = "Furious";

                        break;
                    
                    case 5:
                    
                        _specificName = "Offended";

                        break;
                    
                }

                break;

            case 4:

                _categoryName = "Scared";

                do
                {

                Console.WriteLine("1. Nervous\n2. Anxious\n3. Panicked\n4. Intimidated\n5. Paranoid\n");
                specific = int.Parse(Console.ReadLine());

                Console.WriteLine();

                } while(specific < 1 || specific > 5);
                
                switch (specific)
                {
                    case 1:

                        _specificName = "Nervous";

                        break;
                    
                    case 2:

                        _specificName = "Anxious";

                        break;
                    
                    case 3:
                    
                        _specificName = "Panicked";

                        break;
                    
                    case 4:
                    
                        _specificName = "Intimidated";

                        break;
                    
                    case 5:
                    
                        _specificName = "Paranoid";

                        break;
                    
                }

                break;

            case 5:

                _categoryName = "Unmotivated";

                do
                {
                    
                Console.WriteLine("1. Apathetic\n2. Burned out\n3. Overwhelmed\n4. Discouraged\n5. Lethargic\n");
                specific = int.Parse(Console.ReadLine());

                Console.WriteLine();

                } while(specific < 1 || specific > 5);
                
                switch (specific)
                {
                    case 1:

                        _specificName = "Apathetic";

                        break;
                    
                    case 2:

                        _specificName = "Burned out";

                        break;
                    
                    case 3:
                    
                        _specificName = "Overwhelmed";

                        break;
                    
                    case 4:
                    
                        _specificName = "Discouraged";

                        break;
                    
                    case 5:
                    
                        _specificName = "Lethargic";

                        break;
                    
                }

                break;
        } 
    }

    public void GetExplanation()
    {
        Console.WriteLine("Why do you think you are feeling that way?");
        _explanation = Console.ReadLine();
    }
}