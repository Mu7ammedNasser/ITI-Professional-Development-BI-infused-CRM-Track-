#include <iostream>

using namespace std;

int main()
{
   ///1D Array

    int arr[10] ;
    for(int i =0 ; i<10 ; i++)
    {
        cout<<"plz Enter Number "<<i+1<<":"<<endl;
        cin>>arr[i];
    }

    int arr2[10];
    for(int i =0 ; i<10 ; i++ )
    {
        arr2[i] = arr[i];
    }

    //2-Array sort in the same array
    //Bubble Sort (Ascending)
    for(int i=0 ; i<10 ; i++ )
    {
        for(int j=0 ; j<10 - i - 1 ; j++)
        {
            if(arr[j]>arr[j+1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j+1] = temp;
            }
        }
    }

    //Bubble Sort (Dscending)
    for(int i=0 ; i<10 ; i++ )
    {
        for(int j=0 ; j<10 - i - 1 ; j++)
        {
            if(arr2[j]<arr2[j+1])
            {
                int temp = arr2[j];
                arr2[j] = arr2[j + 1];
                arr2[j+1] = temp;
            }
        }
    }

    cout<<"Bubble Sort (Ascending)"<<endl;
    for(int i =0 ; i<10 ; i++)
    {
        cout<<arr[i]<<endl;
    }

    cout<<"Bubble Sort (Dscending)"<<endl;
    for(int i =0 ; i<10 ; i++)
    {
        cout<<arr2[i]<<endl;
    }


    return 0;



}
