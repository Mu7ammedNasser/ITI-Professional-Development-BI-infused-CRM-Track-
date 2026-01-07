#include <iostream>
#include <cstring>
using namespace std;

int main()
{
    //8- fname, lname -> fullname

    char fName[15] ;
    char lName [15] ;
    cout << "Enter ur first name: " << endl;
    cin>>fName;
    cout << "Enter ur Second name: " << endl;
    cin>>lName;
    char fullName[31];
    strcpy(fullName, fName);
    strcat(fullName, " ");
    strcat(fullName, lName);
    cout<<"FullNaMe: "<<fullName;
    return 0;
}
