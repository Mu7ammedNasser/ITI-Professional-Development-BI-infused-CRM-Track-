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
    int getReal()const
    {
       return real;
    }
    void setImg(int _img)
    {
        img=_img;
    }
    int getImg()const
    {
        return img;
    }

    void Print()
    {
        //cout<<this->real <<"+"<<img <<"i"<<endl;


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




/*
        switch(real)
        {
            case 0:
                switch(img)
                {
                    case 0:
                        cout<<0<<endl;
                        break;
                    case 1:
                        cout<<"i"<<endl;
                        break;
                    case 2:
                        cout<<"-i"<<endl;
                        break;
                    case 3:
                        cout<<


                }
                    case 1:
                        switch(real)
                        {
                        case 0:


                        }

        }
        */
    }

    //add member Function
    //Complex Add(Complex left ,Complex right)
    Complex Add(Complex right)
    {
        Complex result;
        result.real= this->real +right.real;
        result.img=img+right.img;
        return result;
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



    //c3 = c1.Add(c1,c2);
    c3 = c1.Add(c2);

   // c3 = AddComplex(c1,c2);

    c3.Print();
    return 0;
}
