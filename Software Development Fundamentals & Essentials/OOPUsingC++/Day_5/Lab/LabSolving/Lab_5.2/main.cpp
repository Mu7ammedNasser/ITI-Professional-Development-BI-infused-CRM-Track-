#include <iostream>
using namespace std;

int main() {


    ///try dynamic allocation for Array
    ///of pointers to integers read and write
    int* ptrArr[3];
    for(int i =0 ; i<3 ; i++)
    {
        ptrArr[i] = new int[4];
    }

    for(int i=0 ; i<3 ; i++)
    {
        cout<<"Enter Row # "<<i+1<<endl;
        for(int j=0 ; j<4 ; j++)
        {
            cin >>ptrArr[i][j];
        }
    }

    for(int i=0 ; i<3 ; i++)
    {
        for(int j=0 ; j<4 ; j++)
        {
            cout<<ptrArr[i][j]<<"\t";
        }
        cout<<endl;
    }

    cout<<endl;
    cout<<endl;




    for(int i=0 ; i<3 ; i++)
    {
        for(int j=0 ; j<4 ; j++)
        {
            cout<<**(ptrArr+i)<<"\t";
        }
        cout<<endl;
    }

    return 0;
}
