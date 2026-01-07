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


    ///1-Array min  and max value

    //min
    int minValue = arr[0];
    int maxValue = arr[0];
    for(int i = 0 ; i < 10 ; i++)
    {
        if(minValue>arr[i])
            minValue = arr[i];
        if(maxValue<arr[i])
            maxValue = arr[i];
    }

    cout<<"minimum value = "<<minValue<<endl;
    cout<<"maxmum value = "<<maxValue<<endl;


    return 0;
}
