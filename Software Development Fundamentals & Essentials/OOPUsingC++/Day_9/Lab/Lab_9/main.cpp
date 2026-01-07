#include <iostream>
#include"graphics.h"
using namespace std;

class Point
{
    private:
    int x{0}, y{0};
    public:
    void SetX(int _x){x=_x;}
    int GetX(){return x;}
    void SetY(int _y){y=_y;}
    int GetY(){return y;}
    Point()
    {
        x=y=0;
        cout<<"point def ctor";
    }
    Point(int _x,int _y)
    {
        x=_x;
        y=_y;
        cout<<"point 2p ctor";
    }

    ~Point(){cout<<"point dest";}
    //useless
    Point(const Point& old)
    {
        x=old.x;
        y=old.y;
        cout<<"point cctor";
    }
};

class Shape
{
protected:
    int myColor;
public:
    void SetMyColor(int _mycolor){myColor=_mycolor;}
    int GetMyColor(){return myColor;}
    Shape()
    {
        myColor=0;
    }
    Shape(int _color)
    {
        myColor=_color;
    }
    ~Shape(){}
};

class MyLine:public Shape
{
    private:
    Point start;
    Point end;
    public:
    void SetStart(Point _start)
    {
        start=_start;
    }
    Point GetStart()
    {
        return start;
    }
    void SetEnd(Point _end)
    {
        end=_end;
    }
    Point GetEnd()
    {
        return end;
    }

    MyLine(int x1,int y1,int x2,int y2,int _color)
    :start(x1,y1),end(x2,y2),Shape(_color)
    {

    }

    ~MyLine(){}
    MyLine(const MyLine& old)
    {
        start=old.start;
        end=old.end;
        myColor=old.myColor;
    }
    void Draw()
    {
        setcolor(myColor);
        line(start.GetX(),start.GetY(),end.GetX(),end.GetY());
    }

};
class Rect:public Shape
{
    private:
    Point ul;
    Point lr;
    public:
    Rect()
    {

    }
    Rect(int x1,int y1,int x2,int y2,int _color)
    :ul(x1,y1),lr(x2,y2),Shape(_color)
    {

    };
    ~Rect(){}
    Rect(Rect& old){}
    void Draw()
    {
        setcolor(myColor);
        rectangle(ul.GetX(),ul.GetY(),lr.GetX(),lr.GetY());
    }
};

class MyCircle: public Shape
{
    int radius;
    Point center;
    public:
    MyCircle(int cx, int cy, int r, int _color)
    : radius(r), center(cx, cy), Shape(_color) {}
    int GetRadius() const { return radius; }
    const Point& GetCenter() const { return center; }
   void Draw()  {
        setcolor(myColor);
        circle(center.GetX(), center.GetY(), radius);
    }
};
class MyTri:public Shape
{
private:
    Point p1,p2,p3;
public:
MyTri(int x1, int y1, int x2, int y2, int x3, int y3, int _color)
        : p1(x1, y1), p2(x2, y2), p3(x3, y3), Shape(_color)
    {

    }


    void Draw()  {
        setcolor(myColor);
        line(p1.GetX(), p1.GetY(), p2.GetX(), p2.GetY());
        line(p2.GetX(), p2.GetY(), p3.GetX(), p3.GetY());
        line(p3.GetX(), p3.GetY(), p1.GetX(), p1.GetY());
    }
};

class Picture
{
private:
    MyLine *lPtr;
    int lSize;
    Rect *rPtr;
    int rSize;
    MyCircle *Cptr;
    int cSize;
    MyTri *tPtr;
    int tSize;

public:
    Picture()
    {
        lPtr = NULL;
        lSize = 0;
        rPtr = NULL;
        rSize = 0;
        Cptr = NULL;
        cSize = 0;
        tPtr = NULL;
        tSize = 0;
    }

    // set relationship
    void SetLines(MyLine* _lPtr, int _lSize)
    {
        lPtr = _lPtr;
        lSize = _lSize;
    }

    void SetRects(Rect* _rPtr, int _rSize)
    {
        rPtr = _rPtr;
        rSize = _rSize;
    }

    void SetCircles(MyCircle* _cPtr, int _cSize)
    {
        Cptr = _cPtr;
        cSize = _cSize;
    }

    void SetTris(MyTri* _tPtr, int _tSize)
    {
        tPtr = _tPtr;
        tSize = _tSize;
    }

    // Process
    void Execute()
    {
        for (int i = 0; i < lSize; i++)
        {
            lPtr[i].Draw();
        }
        for (int i = 0; i < rSize; i++)
        {
            rPtr[i].Draw();
        }
        for (int i = 0; i < cSize; i++)
        {
            Cptr[i].Draw();
        }
        for (int i = 0; i < tSize; i++)
        {
            tPtr[i].Draw();
        }
    }
};



int main()
{
    initgraph();
/*
    MyLine l1(425,225,425,400,5);
    l1.Draw();

    MyLine l2(575,225,575,400,5);
    l2.Draw();

    MyCircle cr1(500,225,150,5);
    cr1.Draw();

    Rect r2(350,400,650,500,888);

    r2.Draw();
    MyTri tri(600,450,620,430,580,430,5);
    tri.Draw();
*/


    MyLine larr[2]={MyLine(425,225,425,400,1),MyLine(575,225,575,400,5)};
    Rect rarr[1]={Rect(350,400,650,500,888)};
    MyCircle carr[1]={MyCircle(500,225,150,5)};
    MyTri tarr[1] = {MyTri(600,450,620,430,580,430,5)};
    Picture p1;


    ///set relationship
    p1.SetLines(larr,2);
    p1.SetRects(rarr,1);
    p1.SetCircles(carr , 1);
    p1.SetTris(tarr , 1);
    //process
    p1.Execute();

    ///Remove relationship
    p1.SetLines(NULL,0);
    p1.SetRects(NULL,0);
    return 0;
}


