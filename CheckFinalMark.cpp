//Abraham García - checkFinalMark

#include <iostream>

using namespace std;

int main()
    {
        int number = 0;
        int increment = 0, decrement = 0;
        int lastNumber;
        
        for (int count = 1; count <= 10; count++)
        {
            lastNumber = number;
            do
            {
                if (number < 0)
                    cout << "Please, enter a positive number" << endl;
                    
                cout << "Enter the number " << count << ": ";
                    
                cin >> number;
                
            } while (number < 0);
                
            if (count != 1)
            {
                if (number > lastNumber)
                    increment++;
                else if (number < lastNumber)
                    decrement++;
            }
        }
        
        cout << "Number of increments: " << increment << endl;
        cout << "Number of decrements: " << decrement;
    
    return 0;
}
