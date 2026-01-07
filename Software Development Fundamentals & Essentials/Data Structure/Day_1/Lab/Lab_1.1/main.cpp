#include <iostream>

using namespace std;

void insertionSort(int arr[], int n)
{
    for(int i = 1; i < n; i++)
    {
        int key = arr[i];
        int j = i - 1;

        while(j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
        }

        arr[j + 1] = key;
    }
}

int main()
{
    cout<<"Enter Number of Element:"<<endl;
    int n;
    cin >>n;
    int arr[n];
    for(int i=0;i<n;i++)
    {
        cout<<"Enter Element Number: "<<i+1<<endl;
        cin>>arr[i];
    }
    insertionSort(arr , n);
    for(int i=0;i<n;i++)
        cout<<arr[i]<<endl;
    return 0;
}
