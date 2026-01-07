#include <iostream>
#include <algorithm>

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

    Stack( const Stack& oldObject)
    {

        tos=oldObject.tos;
        size=oldObject.size;
        arr=new int [size];
        for(int i=0 ; i <size ; i++)
        {
            this->arr[i]=oldObject.arr[i];
        }
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
            return result;
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

    ///operrator overloading
    int operator == ( const Stack& right)const
    {
        sort(arr, arr + tos);

        sort(right.arr, right.arr + tos);

        if(right.tos != tos)
        {
            return 0;
        }
        else
        {
            for(int i =0 ; i<tos ; i++)
            {
                if(arr[i] != right.arr[i])
                    return 0;
            }
            return 1;
        }

    }
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
    s1.push(1);
    s1.push(3);

    Stack s2(10);
    s2.push(1);
    s2.push(1);
    s2.push(2);
    s2.push(3);

    ViewStack(s1);
    ViewStack(s1);

    int x = (s1==s2);
    if(x)
        cout<<"equlas"<<endl;
    else
        cout<<"not equals"<<endl;


    return 0;
}
