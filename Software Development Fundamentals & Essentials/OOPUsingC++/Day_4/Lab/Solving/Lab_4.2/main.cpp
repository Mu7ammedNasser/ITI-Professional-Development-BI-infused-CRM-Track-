#include <iostream>

using namespace std;

int main()
{

    ///2- pointer to array  read and write   3 ways
    int arr[5];
    int *ptr;
    ptr = arr;


    for(int i =0 ; i<5 ; i++)
    {
        cout<<"Enter Element Number: "<<i+1<<endl;
        cin>>ptr[i];
    }
    system("cls");
    for(int i =0 ; i < 5 ; i++)
    {
        cout<<ptr[i]<<endl;
    }




    /*
    *(ptr+0) = 10;
    *(ptr+1) = 20;
    *(ptr+2) = 30;
    *(ptr+3) = 40;
    *(ptr+4) = 50;

    cout<<*(ptr+0);
    cout<<*(ptr+1);
    cout<<*(ptr+2);
    cout<<*(ptr+3);
    cout<<*(ptr+4);
    */


    /*
     *ptr=10;
     ptr++;

     *ptr=20;
     ptr++;

     *ptr=30;
     ptr++;

     *ptr=40;
     ptr++;

     *ptr=50;
     ptr++;

    ptr=arr;


    cout<<*ptr;
    ptr++;
    cout<<*ptr;
    ptr++;
    cout<<*ptr;
    ptr++;
    cout<<*ptr;
    ptr++;
    cout<<*ptr;
    ptr++;

    ptr=arr;

    */










    return 0;
}
