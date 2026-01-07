#include <iostream>

using namespace std;
using namespace std;
class Base
{
    protected:
    int x;
    public:
    void SetX(int _x){x=_x;}
    int GetX(){return x;}
    Base(){x=0;}
    Base(int _x){x=_x;}
    ~Base(){}
    virtual void Show()
    {
        cout<<"I'm BASE ...";
    }
};

class Derived:public Base
{
    protected:
    int y;
    public:
    void SetY(int _y){y=_y;}
    int GetY(){return y;}
    Derived(){x=y=0;}
    Derived(int _x,int _y):Base(_x)
    {
        y=_y;
    }
    ~Derived(){}
    void Show()
    {
        cout<<"I'm Derived ...";
    }
};

class Derived2:public Derived
{
    protected:
    int z;
    public:
    void SetZ(int _z){z=_z;}
    int GetZ(){return z;}
    Derived2(){z=0;}
    Derived2(int _x,int _y,int _z)
    :Derived(_x,_y)
    {
        z=_z;
    }
    ~Derived2(){}
    void Show() override
    {
        cout<<"I'm Derived2";
    }
};
int main()
{

{


    //Base b1(10);
    //b1.Show();//I'm Base
    //cout<<b1.GetX()<<endl;

    //Derived d1(3,4);
    //d1.show();//I'm derived

    Base *bptr = new Base(3);
    //cout<<bptr<<endl;
    //cout<<&bptr<<endl;
    //(*bptr).Show();
    //bptr->Show();

    //Derived *dptr = new Derived(3,4);
    //(*dptr).Show();
}

{
    //Base *bptr = new Derived(3,4);
    //bptr->Show();//I'm Base ...
    /// Compiler will call the show fun related to pointer data type
    //cout<< (*bptr).GetY();//inValid
    //cout<< (*bptr).GetX();//Valid
}

{
    Base *bptr = new Derived2(3,4,5);
    bptr->Show();//I'm
    cout<<endl;
    cout<<bptr->GetX();//Valid//3
    //cout<<bptr->GetY();//Invalid
    //cout<<bptr->GetZ();//Invalid


}



    return 0;
}
