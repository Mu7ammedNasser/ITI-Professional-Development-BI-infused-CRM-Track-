#include <iostream>

using namespace std;

int main()
{
    ///Search
    int arr[10] = {20,2,15,4,11,6,7,8,9,12};

    int num;
    cout<<"Enter number in Range btw 1 and 20: "<<endl;
    cin>>num;
    for(int i = 0 ; i < 10 ; i++)
    {
        if(num == arr[i])
        {
            cout<<"Congrats!!!!!!";
            cout<<" at index: "<<i<<endl;
            return 0;
            break;
        }

    }
    cout<<"Try Again :("<<endl;

}
