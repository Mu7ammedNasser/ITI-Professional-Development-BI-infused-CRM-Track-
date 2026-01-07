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
        this->real = _real;
    }

    void setImg(int _img)
    {
        (*this).img = _img;
    }

    int getReal()
    {
        return real;
    }

    int getImg()
    {
        return img;
    }

    ///constructors
    Complex()
    {
        this->real=0;
        (*this).img=0;
        cout<<"default ctor"<<endl;
    }

    Complex(int _real,int _img)
    {
        cout<<"2p ctor"<<endl;
        this->real=_real;
        img=_img;
    }

    Complex(int _num)
    {
        cout<<"1p ctor"<<endl;
        this->real=img=_num;
    }


 void Print()
    {
        if (real == 0 && img == 0) {
            cout << 0 << '\n';
            return;
        }

        if (real != 0) cout << real;

        if (img > 0) {
            if (real != 0) cout << '+';
            cout << img << 'i';
        }
        else if (img < 0) {
            cout << img << 'i';
        }

        cout << '\n';
    }

    ///Operator overloading
    //c1+c2
    Complex operator+(const Complex& right)
    {
        Complex result;
        result.real = real + right.real;
        result.img = img + right.img;
        return result;
    }

    //c1+10
    Complex operator+(int _num)
    {
        //Complex result;
        //result.real = real +_num;
        //result.img = right.img
        Complex result(this->real+_num , this->img);
        return result;
    }
    //c1+=c2: c1 = c1(caller/this)+c2

    Complex operator +(const Complex& right)const
    {
        Complex result;
        result.real = real + right.real;
        result.img = img + right.img;
        return result;
    }

    //c1++
    Complex operator++(int)
    {
        Complex result(real,img);
        this->real++;
        this->img++;
        return result;
    }

    //++c1
    Complex operator++()
    {
        this->real++;
        this->img++;
        Complex result(real,img);
        //Complex result(*this);
        return result;
    }

    //c1>c2
    int operator>(const Complex& right)
    {
        return real>right.real&& img>right.img;
    }

};


Complex AddComplex(Complex left,Complex right)
{
    Complex result;
    int r=left.getReal()+right.getReal();
    int i=left.getImg()+right.getImg();
    result.setReal(r);
    result.setImg(i);
    return result;
}
//10+c1
Complex operator + (int _num , Complex right)
{
    return right+ _num;
}

int main()
{
    Complex c1,c2,c3,c4;
    c1.setReal(3);
    c1.setImg(4);
    c2.setReal(-5);
    c2.setImg(12);
    cout<<"c1=";
    c1.Print();
    cout<<"c2=";
    c2.Print();
    cout<<endl;

    cout<<"c1+c2"<<endl;
    c3 = c1 + c2;
    c3.Print();
    cout<<endl;

    cout<<"c1+=c2"<<endl;
    c1 = c1 + c2;
    c1.Print();
    cout<<endl;

    cout<<"c1++"<<endl;
    c4=c1++;
    c4.Print();
    cout<<endl;

    cout<<"++c1"<<endl;
    c4=++c1;
    c4.Print();
    cout<<endl;

    cout<<"c1>c2"<<endl;
    c1.Print();
    c2.Print();

    if(c1>c2)
        cout<<"c1>c2";
    else
        cout<<"c1<c2";

    cout<<endl;











    return 0;
}
