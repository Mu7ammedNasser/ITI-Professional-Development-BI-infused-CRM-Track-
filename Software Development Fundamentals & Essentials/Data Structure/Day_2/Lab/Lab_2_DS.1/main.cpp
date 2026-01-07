#include <iostream>

using namespace std;
class Employee
{
private:
    int id;
public:
    Employee *pNext;
    Employee *pPervious;
    Employee()
    {
        id=0;
        pNext = nullptr;
        pPervious = nullptr;

    }
    Employee(int _id)
    {
        id=_id;
        pNext = nullptr;
        pPervious = nullptr;
    }
    int GetId()
    {
        return id;
    }
    void SetId(int _id)
    {
        id = _id;
    }

    void printEmployee()
    {
        cout<<"id = "<<id<<endl;
    }

};


class LinkedList{
 protected:
    Employee *pStart; Employee *pEnd;

 public:
      LinkedList() {pStart=pEnd=nullptr;}

      Employee* searchList(int Code);

      void InsertAtBeginnning(int _id);

      void InsertAtEnd(int _id);

      int InsertBeforeCode(int _id , int newId);

      int InsertAfterCode(int _id , int newId);

      void displayAll();
 };

 Employee* LinkedList::searchList(int _id)
 {
     Employee * pItem= nullptr;
     pItem = pStart;
     while(pItem && pItem->GetId() != _id) {
        pItem = pItem->pNext;
      }
   return pItem;
 }

void LinkedList::InsertAtBeginnning(int _id)
{
    Employee* pItem = new Employee(_id);
    if(pEnd == nullptr)
        pStart = pEnd=pItem;
        else
            {
                pItem->pNext = pStart;
                pStart = pItem;
            }

}
void LinkedList::InsertAtEnd(int _id)
{
    Employee* pItem = new Employee(_id);
    if (pEnd == nullptr)
    {
        pStart = pEnd = pItem;
    }
    else
    {
        pItem->pPervious = pEnd;
        pEnd->pNext = pItem;
        pItem->pNext = nullptr;
        pEnd = pItem;
    }
}

int LinkedList::InsertBeforeCode(int _id , int newId)
{
    Employee *pItem;
    Employee* Inserted = new Employee(newId);
    int flag = 0;
    pItem = searchList(_id);
    if(!pItem)
    {
        flag = 0;
    }
    else
    {
        Inserted->pNext = pItem;
        pItem->pPervious->pNext = Inserted;
        Inserted->pPervious = pItem->pPervious;
        pItem->pPervious = Inserted;

        flag = 1;
    }

    return flag;

}


int LinkedList::InsertAfterCode(int _id , int newId)
{
    Employee *pItem;
    Employee* Inserted = new Employee(newId);
    int flag = 0;
    pItem = searchList(_id);
    if(!pItem)
    {
        flag = 0;
    }
    else
    {
        Inserted->pNext = pItem->pNext;
        pItem->pNext->pPervious = Inserted;
        Inserted->pPervious = pItem;
        pItem->pNext = Inserted;
        flag = 1;
    }

    return flag;
}

void LinkedList::displayAll()
 {
     Employee * pItem;
     pItem = pStart;
     while(pItem)
  {
     pItem->printEmployee();
     pItem = pItem ->pNext;
  }
 }

int main()
{
    LinkedList* L = new LinkedList();

    L->InsertAtBeginnning(40);
    L->InsertAtBeginnning(30);
    L->InsertAtBeginnning(50);
    L->InsertAtEnd(9);
    L->InsertAtEnd(9);
    L->InsertAtEnd(9);
    L->InsertAfterCode(50,600);
    L->InsertBeforeCode(30,656);
    L->InsertBeforeCode(656,656);
    L->InsertBeforeCode(30,10);
    L->InsertBeforeCode(30,656);
    L->InsertBeforeCode(30,656);

    L->displayAll();

    return 0;
}
