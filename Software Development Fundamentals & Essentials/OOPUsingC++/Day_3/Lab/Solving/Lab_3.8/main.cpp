#include <iostream>
#include <string.h>
#include <conio.h>
using namespace std;

int main()
{
    //8- read string from user
    //and then print it reversly


    cout << "Enter Your Name: " << endl;
    char name[100];
    char ch;
    int i =0;
    while((ch =getche()) != 13)
          {
              name[i]=ch;
              i++;
          }
          name[i]='\0';

          cout<<endl;
          cout<<endl;
          cout<<endl;
    i--;
    while(name[i]!='\0')
    {
        cout<<name[i];
        i--;
    }
    return 0;
}
