#include <iostream>

using namespace std;
void printByValue(int arr[])
{
    for(int i =0 ; i <5 ; i++)
    cout<<arr[i];
}
void printByReference(int *arr)
{
    for(int i =0 ; i <5 ; i++)
        cout<<*(arr+i);
}

int main()
{
    int arr[5] = {1, 2, 3, 4, 5};


    printByValue(arr);

    cout<<endl;
    cout<<endl;
    cout<<endl;

    printByReference(arr);
    return 0;
}
