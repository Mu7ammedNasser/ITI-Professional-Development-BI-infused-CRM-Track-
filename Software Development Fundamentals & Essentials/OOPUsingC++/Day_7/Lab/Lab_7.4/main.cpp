#include <iostream>
using namespace std;

class CircularQueue {
private:
    int *arr;
    int capacity;
    int front;
    int rear;
    int count;

public:
    // Constructors
    CircularQueue() {
        capacity = 5;
        arr = new int[capacity];
        front = 0;
        rear = 0;
        count = 0;
        cout << "ctor called" << endl;
    }

    CircularQueue(int _capacity) {
        if (_capacity <= 0) _capacity = 5;
        capacity = _capacity;
        arr = new int[capacity];
        front = 0;
        rear = 0;
        count = 0;
        cout << "ctor called" << endl;
    }

    // Destructor
    ~CircularQueue() {
        delete[] arr;
        cout << "destructor called" << endl;
    }

    void enqueue(int value) {
        if (!IsFull()) {
            arr[rear] = value;
            rear = (rear + 1) % capacity;
            count++;
        } else {
            cout << "Queue is FULL!" << endl;
        }
    }

    int dequeue() {
        if (!IsEmpty()) {
            int value = arr[front];
            front = (front + 1) % capacity;
            count--;
            return value;
        } else {
            cout << "Queue is EMPTY!" << endl;
            return -126549812;
        }
    }


    int IsFull() { return count == capacity; }
    int IsEmpty() { return count == 0; }

    // Friend view (copies queue by value like your ViewStack)
    friend void ViewQueueFriend(CircularQueue param);
};

void ViewQueueFriend(CircularQueue param) {
    if (param.IsEmpty()) {
        cout << "queue is empty" << endl;
        return;
    }
    cout << "Friend view: ";
    for (int i = 0; i < param.count; ++i) {
        int idx = (param.front + i) % param.capacity;
        cout << param.arr[idx] << " ";
    }
    cout << endl;
}

int main() {
    CircularQueue q(5);

    q.enqueue(10);
    q.enqueue(20);
    q.enqueue(30);
    q.enqueue(40);
    q.enqueue(50);
    q.dequeue();
    q.enqueue(60);
    ViewQueueFriend(q);


    return 0;
}
