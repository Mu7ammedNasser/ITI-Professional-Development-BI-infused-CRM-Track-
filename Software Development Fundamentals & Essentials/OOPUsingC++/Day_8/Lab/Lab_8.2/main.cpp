#include <iostream>

using namespace std;
class Stack
{
private:
    int *arr;
    int top;
    int size;
public:
    /// COnstructor
    Stack()
    {
        top=0;
        size=5;
        arr = new int[size];
        cout<<"Stack Default ctor"<<endl;
    }

    Stack(int _size)
    {
        top=0;
        size=_size;
        arr = new int[size];
        cout<<"Stack 1_parameter ctor";
    }
    ///cpy constructor

    Stack( const Stack& oldObject)
    {
        // oldObject.tos=-123;
        top=oldObject.top;
        size=oldObject.size;
        arr=new int [size];
        for(int i=0 ; i <size ; i++)
        {
            this->arr[i]=oldObject.arr[i];
        }
    }

    /// Destructor

    ~Stack()
    {
        delete[] arr;
        cout<<"Stack destroied"<<endl;
    }

    ///Stack Functions
    void push(int value)
    {
        if(!isFull())
        {
            arr[top] = value;
            top++;
        }
        else
        {
            cout<<"Stack is Full!!!";
        }
    }

    int pop()
    {
        if(!isEmpty())
        {
            top--;
            return arr[top];
        }
        else
        {
            cout<<"array is Empty";
            return -12364654;
        }
    }

    ///Reverse
    Stack reverseStack()
    {
            Stack result;
            Stack tmp = (*this);
        for(int i=0; i< this->top; i++)
        {
            result.push(tmp.pop());
        }
            return result;
    }

    /// Helper Functions
    int isFull(){return top == size;}
    int isEmpty(){return top == 0;}

    /// friend Function
    void friend ViewStack(Stack param);
};

void ViewStack(Stack param)
{
    cout<<"Array values"<<endl;
    cout<<param.top<<endl;

    for(int i =0 ; i<param.top ; i++)
    {
        cout<<param.arr[i]<<endl;
    }
}



int main()
{
    Stack s1(10);
    s1.push(10);
    s1.push(20);
    s1.push(30);
    s1.push(40);
    s1.push(50);
    ViewStack(s1);
    Stack s2 = s1.reverseStack();
    ViewStack(s2);

    return 0;
}
