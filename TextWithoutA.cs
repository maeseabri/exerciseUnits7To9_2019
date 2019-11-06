//Abraham García - TextWithoutA

using System;

class textWithoutA
{
    static void Main()
    {
        string text;
        bool check = true;
        
        do
        {
            check = true;
            Console.Write("Please, write a text: ");
            text = Console.ReadLine();
            
            foreach (char letter in text)
            {
                if (letter == 'a' || letter == 'A')
                    check = false;
            }
            
        } while (check == false);
    }
}

