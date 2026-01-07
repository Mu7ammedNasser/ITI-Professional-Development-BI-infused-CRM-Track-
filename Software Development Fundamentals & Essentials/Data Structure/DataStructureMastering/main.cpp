#include <iostream>

using namespace std;
class Stack
{
private:
    int top;
    int size;
    int* arr;
public:
    Stack ()
    {
        int top=0;
        size = 5 ;
        arr = new int[size];
    }
    Stack(int Size)
    {
        top = 0;
        size = Size;
        arr = new int[Size];
    }
    ~Stack()
    {
        delete []arr;
    }

    void Push(int value)
    {
        if(isFull())
            cout << "Stack Overflow!" << endl;
        else
            arr[top++] = value;
    }

    int Pop()
    {
        if(isEmpty())
        {
            cout << "Stack Underflow!" << endl;
            return -1;
        }
        else
            return arr[--top];
    }

    ///Helper Functions
    bool isEmpty()
    {
        return top == 0;
    }

    bool isFull()
    {
        return top == size-1;
    }

    void displayArr()
    {
        for(int i=0 ; i <top ; i++)
        {
            cout<<arr[i]<<endl;
        }


    }
};


 class Queue
 {
 private:
     int head;
     int tail;
     int size;
     int* arr;
 public:
     Queue()
     {
         head = tail = -1;
         size = 5;
         arr = new int[5];
     }

     Queue(int Size)
     {
         head = tail = -1;
         this->size = Size;
         arr = new int[Size];
     }

     void Enqueue(int value)
     {
         if(isFull())
         {
            cout <<"Queue is Full"<<endl;
            return;
         }

          if (isEmpty())
            {
                head = tail = 0;
                arr[tail] = value;
                return;
            }

         arr[++tail] = value;
     }

     int Dequeue()
     {
         if(isEmpty())
         {
             cout<<"Queue is Empty"<<endl;
             return -1;
         }
         int value = arr[head++];


         if(head>0 && tail == size -1)
         {
             for(int i=head ; i<=tail ; i++)
             {
                 arr[i - head] = arr[i];
             }
             tail = tail - head;
             head = 0;
         }

         if (head > tail)
            head = tail = -1;

         return value;
     }


     bool isEmpty()
     {
         return head == -1;
     }

     bool isFull()
     {
         return tail == size - 1;
     }

     void display()
     {
         for(int i =head; i<=tail ; i++)
            cout<<arr[i]<<endl;
     }

 };


class cirQueue
{
private:
    int head;
    int tail;
    int size;
    int* arr;
public:
    int counter;
    cirQueue()
    {
        head = tail = -1;
        size = 5 ;
        arr = new int[5];
        counter = 0;
    }
    cirQueue(int Size)
    {
        head = tail = -1;
        size = Size;
        arr = new int[Size];
        counter = 0;
    }

    void Enqueue(int value)
    {
        if(isFull())
        {
            cout<<"Queue is Full!!!"<<endl;
            return;
        }
        tail = (tail+1)%size;
        arr[tail] = value;
        counter++;
    }

    int Dequeue()
    {
        if(isEmpty())
        {
            cout<<"Queue is Empty!!!"<<endl;
            return -1;
        }
        head = (head +1 )%size;
        counter--;
        return arr[head];
    }


    bool isEmpty() { return counter == 0; }
    bool isFull()  { return counter == size; }

    void display()
    {
        int i = head+1;
        int j=0;
        while(j<counter)
        {
            cout<<arr[i]<<endl;
            i= (i+1)%size;
            j++;
        }

    }
};

class Node
{
public:
    Node* next;
    int data;

    Node(int new_data)
    {
        data = new_data;
        next = nullptr;
    }
};

class SLinkedList
{
private:
    Node* start = nullptr;
    Node* end = nullptr;
public:
    void InsertInBeganning(int new_data)
    {
        Node* newNode = new Node(new_data);
        if(start == nullptr)
        {
            start = end = newNode;
        }
        else
        {
            newNode->next = start;
            start = newNode;
        }
    }

    void InsertAtTheEnd(int new_data)
    {
        Node* newNode = new Node(new_data);

        if(start == nullptr)
        {
            start = end = newNode;
        }
        else
        {
            newNode->next = nullptr;
            end->next = newNode;
            end = newNode;

        }
    }

    void InsertAfterSpecificdata(int new_data , int Existdata)
    {
        Node* newData = new Node(new_data);
        Node* Item = start;
        while(Item->data != Existdata)
        {
            Item = Item->next;
            if(Item == nullptr)
                return;

        }

        newData->next = Item->next;
        Item->next = newData;

    }

    void display()
    {
        Node* temp = start;
        while(temp)
        {
            cout<<temp->data<<endl;
            temp = temp->next;
        }
    }


};

class NodeD
{
public:
    NodeD* next;
    NodeD* prev;
    int data;
    NodeD(int newdata)
    {
        data = newdata;
        next = prev = nullptr;
    }

};

class DLinkedList
{
private:
    NodeD* Start = nullptr;
    NodeD* End = nullptr;

public:
    void insertAtBeganning(int new_data)
    {
        NodeD* newNode = new NodeD(new_data);
        if(Start == nullptr)
        {
            Start = End = newNode;
        }
        else
        {
            newNode->next = Start;
            Start->prev = newNode;
            newNode->prev = nullptr;
            Start = newNode;
            Start->prev=End;
        }
    }

    void insertAtEnd(int new_data)
    {
        NodeD* newNode = new NodeD(new_data);
        if(Start == nullptr)
        {
            Start = End = newNode;
        }
        else
        {
            newNode->next = nullptr;
            newNode->prev = End;
            End->next = newNode;
            End = newNode;
            End->next=Start;
        }
    }


    void display()
    {
        NodeD* Item = Start;
        while(Item->next != Start)
        {
            cout<<Item->data<<endl;
            Item = Item->next;
        }
        cout << Item->data << endl;

    }
};


void Swap(int &num1 , int &num2)
{
    int temp;
    temp = num2;
    num2 = num1;
    num1 = temp;
}

int sequentailSearch(int arr[] , int key , int n)
{
    for(int i=0 ; i<n ; i++)
    {
        if(arr[i] == key)
            return i;
    }
    return -1;
}

int BinarySearch(int arr[] , int key , int n)
{
    int low=0;
    int high = n-1;
    while(low<=high)
    {
        int mid = low+high/2;
        if(arr[mid] == key)
            return mid;
        else if(arr[mid]>key)
            high = mid -1;
        else
            low = mid +1;
    }
    return-1;
}


int main()
{


    int arr [] = {5, 6, 45, -6, 3, 8};
    int n = sizeof(arr)/sizeof(int);
    {

    /*
    for(int i = 1 ; i < n ; i++)
    {
        int key = arr[i];
        int j = i-1;
        while(j>=0 && arr[j]> key)
        {
            arr[j+1] = arr[j];
            j--;
        }
        arr[j+1] = key;

    }
        */
    /*
    for(int i=0 ; i<n-1 ; i ++)
    {
       int min = i;
        for(int j= i+1 ; j < n ; j++ )
            if(arr[min] > arr[j])
                min = j;
        Swap(arr[i] , arr[min]);
    }
    */

    /*
    for(int i=0 ; i< n-1 ; i++)
    {
        bool swapped = 0;
        for(int j = 0 ; j<n-i-1 ; j++)
            if(arr[j]>arr[j+1])
            {
                Swap(arr[j] , arr[j+1]);
                swapped = 1;
            }
            if(!swapped) break;

    }
    */
    }
    {

    //int sortedArr [] = {1,2,3,4,5,6};

    //cout<< BinarySearch(sortedArr,1 ,6)<<endl;
    }






    return 0;
}



