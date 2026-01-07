#include <iostream>

using namespace std;

int main()
{
    int cols=3;
    int rows=4;
    int **ptrArr;
    ptrArr=new int*[rows];

    //allocate 2d array dynamic
    for(int i=0 ; i < rows ; i++)
    {
        ptrArr[i]=new int[cols];
    }

    for(int i=0 ; i<3 ; i++)
    {
        cout<<"Enter Row # "<<i+1<<endl;
        for(int j=0 ; j<4 ; j++)
        {
            //cin >>*ptrArr[j];
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



}
