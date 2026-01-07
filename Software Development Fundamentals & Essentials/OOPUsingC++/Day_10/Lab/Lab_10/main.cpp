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


class Geoshape
{
    protected:
    double dim1;
    double dim2;
    public:
    void SetDim1(double _dim1){dim1=_dim1;}
    double GetDim1(){return dim1;}
    void SetDim2(double _dim2){dim2=_dim2;}
    double GetDim2(){return dim2;}
    Geoshape()
    {
        dim1=dim2=0;
        //cout<<"geo def ctor";
    }
    Geoshape(double _dim1,double _dim2)
    {
        dim1=_dim1;
        dim2=_dim2;
        //cout<<"geo 2p ctor";
    }
    Geoshape(double _dim)
    {
        dim1=dim2=_dim;
        //cout<<"geo 1p ctor";
    }
    ~Geoshape(){}

     virtual double Area()=0;

};
/////
class Rect:public Geoshape
{
    public:
    Rect()
    {
    }
    Rect(double _d1,double _d2):Geoshape(_d1,_d2)
    {
    }
    ~Rect(){}
    double Area()
    {
        return dim1*dim2;
    }

};
/////
class Square:public Geoshape
{
    public:
    Square(){}
    Square(double _d):Geoshape(_d)//Geoshape(_d,_d)
    {

    }
    ~Square(){}
    double Area()
    {
        return dim1*dim2;
    }
};
/////
class Circle:public Geoshape
{
    public:
    Circle(){}
    Circle(double _radius)
    {
        dim1=dim2=_radius;
    }
    ~Circle(){}
    double Area()
    {
        3.14 * dim1 * dim2;
    }
};
/////
class Tri:public Geoshape
{
    public:
    Tri(){}
    Tri(double _base,double _height)
    :Geoshape(_height,_base)
    {}
    ~Tri(){}
    double Area()
    {
        return 0.5 * dim1 * dim2;
    }

};




//fail open close principle
double SumOfAreasV1(Rect *_rptr,int _rSize,Square* _sPtr,int _sSize,Tri *_tPtr,int _tSize)
{
    double sum=0;
    for (int i = 0; i < _rSize; i++)
    {
        sum+=_rptr[i].Area();
    }
    for (int i = 0; i < _sSize; i++)
    {
        sum+=_sPtr[i].Area();
    }
    for (int i = 0; i < _tSize; i++)
    {
        sum+=_tPtr[i].Area();
    }
    return sum;
}

//v2 open close principle
//double SumOfAreasV2(Geoshape* _gPtrArr[] , int _gSize)//not standard
double SumOfAreasV2(Geoshape** _gPtrArr , int _gSize)
{
    double sum=0;
    for(int i=0 ; i<_gSize ; i++)
    {
        sum += _gPtrArr[i]->Area();
    }
    return sum;
}
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
    //Base *bptr = new Derived2(3,4,5);
    //bptr->Show();//I'm
    //cout<<endl;
   // cout<<bptr->GetX();//Valid//3
    //cout<<bptr->GetY();//Invalid
    //cout<<bptr->GetZ();//Invalid


}

{
    Rect rarr[3]={Rect(3,4),Rect(2,5),Rect(2,5)};
    Square sarr[2]={Square(10),Square(10)};
    Tri tarr[2]={Tri(2,10),Tri(2,10)};

    cout<<SumOfAreasV1(rarr,3,sarr,2,tarr,2);

    Geoshape* gPtrArr[7] = {rarr,&rarr[1],&rarr[2],sarr,&sarr[1], tarr ,&tarr[1]};
    cout<<SumOfAreasV2(gPtrArr , 7);

}


    return 0;
}
