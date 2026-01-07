#include <iostream>

using namespace std;

int main()
{
    ///1- pointer to integer  read & write

    int num;
    int *ptr;
    ptr = &num;
    cout<<"Enter a number: "<<endl;
    cin>>*ptr;
    cout<<"entered value = ";
    cout<<num;
    return 0;
}
