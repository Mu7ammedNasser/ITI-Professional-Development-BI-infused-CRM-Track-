#include <iostream>

using namespace std;



class Employee
{
private:
    int id;
    int salary;
    int Age;
public:
    Employee()
    {
        salary = Age = 0;
    }
    Employee(int _id , int _salary ,int _Age)
    {
         salary = _salary;
         Age = _Age;
         id= _id;
    }

    int operator >(const Employee& right)const
    {
        return salary > right.salary;
    }

    void setData()
    {
        cout<<"enter id: "<<endl;
        cin>>id;

        cout<<"enter salary: "<<endl;
        cin>>salary;

        cout<<"enter Age: "<<endl;
        cin>>Age;
    }

    void showData()
    {
        cout<<"ID: "<<id<<" Age: "<<Age<<" Salary: "<<salary<<endl;
    }
};
void SWAP(Employee  &num1,Employee &num2)
{
    Employee temp =num1;
    num1=num2;
    num2=temp;
}
int main()
{
    cout<<"Enter Number of Employee: "<<endl;
    int n;
    cin>>n;
    Employee E[n];

    for(int i =0 ; i<n;i++)
    {
        E[i].setData();
        cout<<endl;

    }



    for(int i =0 ; i<n;i++)
    {
        for(int j =i; j>0 ; j--)
        {
            if(E[i-j]> E[i])
            {
                SWAP(E[i],E[i-j]);
            }
        }
    }


    for(int i =0 ; i<n;i++)
        E[i].showData();





    return 0;
}

