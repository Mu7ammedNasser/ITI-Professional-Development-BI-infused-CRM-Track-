#include <iostream>

using namespace std;
struct Employee
{
    int id;
    char name[12];
    int age;
};

int main()
{
    Employee e1;

    Employee *empPtr;

    empPtr = &e1

    (*empPtr).id=1;
    cout<<(*empPtr).id;



    return 0;
}
