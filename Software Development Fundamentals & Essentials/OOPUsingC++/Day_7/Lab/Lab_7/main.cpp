#include <iostream>
using namespace std;

class Complex
{
private:
    int real;
    int img;
public:
    void setReal(int _real)
    {
        real = _real;
    }
    int getReal()
    {
        return real;
    }
    void setImg(int _img)
    {
        img = _img;
    }
    int getImg()
    {
        return img;
    }

    void Print()
    {
         if(real> 0 && img >0)
                cout<<this->real <<"+"<<this->img <<"i"<<endl;
        else if(real== 0 && img >0)
                cout<<this->img <<"i"<<endl;
        else if(real== 0 && img <0)
                cout<<"-"<<this->img <<"i"<<endl;
        else if(this->real== 0 && this->img ==0)
                cout<<0<<endl;
        else if(this->real>0 && this->img ==0)
                cout<<this->real<<endl;
        else if(this->real<0 && this->img ==0)
               cout<<this->real<<endl;
           else if(this->real<0 && this->img<0)
               cout<<this->real <<img <<"i"<<endl;

    }

    ///Constructors
    Complex()
    {
        this->real=0;
        img=0;
        cout<<"complex ctor called"<<endl;
    }
    Complex(int _real,int _img)
    {
        this->real=_real;
        img=_img;
        cout<<"complex ctor called"<<endl;
    }
    Complex(int _num)
    {
        this->real=img=_num;
        cout<<"complex ctor called"<<endl;
    }

    ///destructor
    ~Complex()
    {
        cout<<"destructor called"<<endl;
    }

};

Complex AddComplex(Complex left ,Complex right)
{
    Complex result;
    int r=left.getReal()+right.getReal();
    int i=left.getImg()+right.getImg();

    result.setReal(r);
    result.setImg(i);
    return result;
}
int main()
{
    Complex c1,c2,c3;

    int real1,img1;
    cout<<"Enter real_1\n";
    cin>>real1;
    c1.setReal(real1);

    cout<<"Enter img_1\n";
    cin>>img1;
    c1.setImg(img1);

    int real2,img2;
    cout<<"Enter real_2\n";
    cin>>real2;
    c2.setReal(real2);

    cout<<"Enter img_2\n";
    cin>>img2;
    c2.setImg(img2);

    cout<<"\nIn Function\n"<<endl;

    c3=AddComplex(c1,c2);
    cout<<"\nFunction Ended\n"<<endl;
    c3.Print();


    return 0;
}
