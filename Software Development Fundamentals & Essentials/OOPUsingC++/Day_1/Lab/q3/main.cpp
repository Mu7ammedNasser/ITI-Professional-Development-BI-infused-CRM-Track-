#include <iostream>

using namespace std;

int main()
{
    //3- read Age and print value and address
    int age;
    cout<<"Enter Your Age: ";
    cin>>age;
    cout<<"Your Age is: "<<age<<endl;
    cout<<"Address: "<<&age;
}
