//Abraham García - TextWithoutA - Added clean code

/*In this program, we can type any word or phrase, and the program
won't stop until we type a word/phrase without the lleter 'a'/'A'*/

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

