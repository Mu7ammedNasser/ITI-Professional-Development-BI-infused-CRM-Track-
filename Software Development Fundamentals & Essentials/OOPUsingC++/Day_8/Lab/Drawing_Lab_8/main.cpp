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
};

class MyLine
{
    private:
    Point start;
    Point end;
    int myColor;
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
    void SetMyColor(int _mycolor){myColor=_mycolor;}
    int GetMyColor(){return myColor;}

    MyLine(int x1,int y1,int x2,int y2,int _color)
    {
        //-> l2 start x|0| y|0| end x|0| y|0|
        start.SetX(x1);
        start.SetY(y1);
        end.SetX(x2);
        end.SetY(y2);
        myColor=_color;
        //->
        cout<<"Line 5p ctor";
    }

    void Draw()
    {
        setcolor(myColor);
        line(start.GetX(),start.GetY(),end.GetX(),end.GetY());
    }

};
class Rect
{
    private:
    Point ul;
    Point lr;
    int myColor;
    public:
    //setters & getters
    Rect()
    {
        myColor=0;
        cout<<"Rect def ctor";
    }
    Rect(int x1,int y1,int x2,int y2,int _color)
    :ul(x1,y1),lr(x2,y2)
    {
        myColor=_color;
        cout<<"Rect 5p ctor";
    }

    void Draw()
    {
        setcolor(myColor);
        rectangle(ul.GetX(),ul.GetY(),lr.GetX(),lr.GetY());
    }
};

class MyCircle
{
    int radius;
    Point center;
    int myColor;
    public:
    MyCircle(int cx, int cy, int r, int color)
    : radius(r), center(cx, cy), myColor(color) {}
    int GetRadius() const { return radius; }
    const Point& GetCenter() const { return center; }
    int GetMyColor() const { return myColor; }
   void Draw()  {
        setcolor(myColor);
        circle(center.GetX(), center.GetY(), radius);
    }
};
class MyTri{
private:
    Point p1,p2,p3;
    int myColor;
public:
MyTri(int x1, int y1, int x2, int y2, int x3, int y3, int color)
        : p1(x1, y1), p2(x2, y2), p3(x3, y3), myColor(color)
    {
        cout << "MyTri ctor\n";
    }


    void Draw()  {
        setcolor(myColor);
        line(p1.GetX(), p1.GetY(), p2.GetX(), p2.GetY());
        line(p2.GetX(), p2.GetY(), p3.GetX(), p3.GetY());
        line(p3.GetX(), p3.GetY(), p1.GetX(), p1.GetY());
    }
};
int main()
{
    initgraph();

    MyLine l1(425,225,425,400,5);
    l1.Draw();

    MyLine l2(575,225,575,400,5);
    l2.Draw();

    MyCircle cr1(500,225,150,5);
    cr1.Draw();

//    Rect r2(350,400,650,400,888);
      Rect r2(350,400,650,500,888);

    r2.Draw();
    MyTri tri(600,450,620,430,580,430,5);
    tri.Draw();

    return 0;
}


