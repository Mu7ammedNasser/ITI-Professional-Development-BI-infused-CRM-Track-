#include <iostream>

using namespace std;
class Employee
{
private:
    int id;
public:
    Employee *pNext;
    Employee()
    {
        id=0;
        pNext = nullptr;

    }
    Employee(int _id)
    {
        id=_id;
        pNext = nullptr;
    }

    int GetId()
        {
            return id;
        }


    void printEmployee()
    {
        cout<<"id = "<<id<<endl;
    }

};


class LinkedList{
 protected:
     Employee *pTop;

 public:
      LinkedList() {pTop = nullptr;}

      void InsertAtEnd(int _id);
      int retreiveLast();

      void displayAll();
 };


void LinkedList::InsertAtEnd(int _id)
{
    Employee* pItem = new Employee(_id);

    pItem->pNext = pTop;
    pTop = pItem;
}

int LinkedList::retreiveLast()
{
        Employee* pItem = new Employee();
        pItem = pTop;
        pTop = pItem->pNext;
        return pItem->GetId();

}


void LinkedList::displayAll()
 {
     Employee * pItem = pTop;
     while(pItem)
  {
     pItem->printEmployee();
     pItem = pItem ->pNext;
  }
 }


 class Stack: private LinkedList
 {
 public:
     void Push(int _id)
     {
         InsertAtEnd(_id);
     }

     int Pop()
     {
         if(!pTop)
         {
             cout<<"Empty"<<endl;
             return -1;
         }
         return retreiveLast();
     }


     void display()
     {
         displayAll();
     }



 };
int main()
{
    Stack* S = new Stack();

    S->Push(12);
    S->Push(12);
    S->Push(12);
    S->Push(12);
    S->Pop();
    S->Pop();
    S->display();

    return 0;
}
