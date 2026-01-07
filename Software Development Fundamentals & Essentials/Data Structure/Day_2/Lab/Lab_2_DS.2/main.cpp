#include <iostream>

using namespace std;

int binarySearch(int* arr, int key, int start, int end)
{

    if(start>end)
        return -1;

    int mid = (start + end)/2;
    if(arr[mid] == key)
        return mid;

    else if(arr[mid]>key)
    {
         return binarySearch( arr ,  key , start , mid-1 );
    }

    else if(arr[mid]<key)
    {
         return binarySearch( arr ,  key , mid+1 , end);
    }
}

int main()
{
    int arr[] = {1,2,3,5,6,40};
    cout<<binarySearch(arr,878,0,sizeof(arr) / sizeof(arr[0]))<<endl;
    return 0;
}
