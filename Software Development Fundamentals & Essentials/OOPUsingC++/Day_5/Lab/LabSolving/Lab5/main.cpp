#include <iostream>

using namespace std;

int main()
{
    ///1- try dynamic allocation
    // for pointer to integer read and write  2ways

        int *ptr = new int;

        cout << "Enter a number: ";
        cin >> *ptr;

        cout << "way 1: " << *ptr << endl;
        cout << "way 2: " << ptr[0] << endl;

        delete ptr;


    return 0;
}
