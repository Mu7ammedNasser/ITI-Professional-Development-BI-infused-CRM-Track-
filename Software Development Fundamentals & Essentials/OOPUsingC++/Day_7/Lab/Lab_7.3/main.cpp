#include <iostream>
using namespace std;

class ShiftQueue
{
private:
    int* arr;
    int size;
    int front;
    int rear;
    int count;

public:
    /// Constructors
    ShiftQueue()
    {
        size = 5;
        arr = new int[size];
        front = 0;
        rear = 0;
        count = 0;
        cout << "ctor called" << endl;
    }

    ShiftQueue(int _size)
    {
        size = _size;
        arr = new int[size];
        front = 0;
        rear = 0;
        count = 0;
        cout << "ctor called" << endl;
    }

    /// Destructor
    ~ShiftQueue()
    {
        delete[] arr;
        cout << "destructor called" << endl;
    }

    /// Queue Functions
    void enqueue(int value)
    {
        if (!IsFull())
        {
            arr[rear] = value;
            rear++;
            count++;
            //cout << "Front: " << front << "Count: " << count << endl;
        }
        else
        {
            cout << "Queue is FULL!" << endl;
        }
    }

    int dequeue()
    {
        if (!IsEmpty())
        {
            int value = arr[0];

            // Shift all elements to the left
            for (int i = 0; i < rear - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            rear--;
            count--;
            //cout << "Front: " << front << "Count: " << count << endl;
            return value;
        }
        else
        {
            cout << "Queue is EMPTY!" << endl;
            return -1;
        }
    }

    int IsFull() { return count == size; }
    int IsEmpty() { return count == 0; }


    friend void ViewQueueFriend(ShiftQueue param);
};

/// Friend Function
void ViewQueueFriend(ShiftQueue param)
{
    cout << "Friend view: ";
    for (int i = 0; i < param.count; i++)
    {
        cout << param.arr[i] << " ";
    }
    cout << endl;
}

/// Main test
int main()
{
    ShiftQueue q1(5);

    q1.enqueue(10);
    q1.enqueue(20);
    q1.enqueue(30);
    q1.enqueue(40);
    q1.enqueue(50);
    q1.dequeue();
    q1.enqueue(60);

    ViewQueueFriend(q1);

    cout << "Dequeued: " << q1.dequeue() << endl;
    cout << "Dequeued: " << q1.dequeue() << endl;

    return 0;
}
