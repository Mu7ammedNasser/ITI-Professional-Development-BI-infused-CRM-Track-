#include <iostream>

using namespace std;
void SwapV(int num1 , int num2)
{
    int temp;
    temp = num1;
    num1 = num2;
    num2=temp;
}

void SwapR(int *num1 , int *num2)
{
    int temp;
    temp = *num1;
    *num1 = *num2;
    *num2=temp;
}
int main()
{
    //4- pass by value swap
    cout<<"Using pass by value:"<<endl;
    int x=3;
    int y=5;
    cout<<"Before Swap\n";
    cout<<"x="<<x<<endl; //3
    cout<<"y="<<y<<endl; //5

    SwapV(x,y);

    cout<<"After Swap\n";
    cout<<"x="<<x<<endl; //3
    cout<<"y="<<y<<endl; //5


    cout<<"Using pass by REF:"<<endl;
    int k=3;
    int z=5;
    cout<<"Before Swap\n";
    cout<<"x="<<k<<endl; //3
    cout<<"y="<<z<<endl; //5

    SwapR(&k,&z);

    cout<<"After Swap\n";
    cout<<"x="<<k<<endl; //3
    cout<<"y="<<z<<endl; //5

}
