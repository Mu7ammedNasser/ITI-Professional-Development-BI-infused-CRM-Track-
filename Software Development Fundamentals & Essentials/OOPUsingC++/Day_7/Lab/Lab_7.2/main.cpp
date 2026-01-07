#include <iostream>

using namespace std;
class Stack
{
private:
    int *arr;
    int tos;
    int size;
public:
    ///constructors
    Stack()
    {
        tos = 0;
        size=5;
        arr = new int [size];
        cout<<"ctor called"<<endl;
    }
    Stack(int _size)
    {
        tos=0;
        size=_size;
        arr=new int[size];
        cout<<"ctor called"<<endl;
    }
    ///destructor
    ~Stack()
    {
        /*for(int i =0 ; i<size ; i++)
        {
            delete arr[i];
        }*/
        delete []arr;
        cout<<"destructor called"<<endl;
    }

    /// Stack Funs
    void push(int value)
    {
        if(!this->IsFull())
        {
            arr[tos] = value;
            tos++;
        }
        else
        {
            cout<<"Full"<<endl;
        }
    }

    int pop()
    {
        if(!IsEmpty())
        {
            tos--;
            int result=arr[tos];
        }
        else
        {
            cout<<"EMPTY!!!\n";
            return -126549812;

        }
    }

    int IsFull(){return tos==size;}
    int IsEmpty(){return tos==0;}

    friend void ViewStack(Stack param);
};
void ViewStack(Stack param)
{
    if(param.IsEmpty()){
        cout<<"Stack is empty"<<endl;
    }
    cout << "Stack elements: "<<endl;
    for (int i = 0; i < param.tos;  i++)
    {
        cout<<param.arr[i]<<endl;
    }
    cout<<endl;
}

int main()
{
    Stack s1(10);

    s1.push(1);
    s1.push(2);
    s1.push(3);
    s1.push(4);

    ViewStack(s1);
    ViewStack(s1);

    return 0;
}
