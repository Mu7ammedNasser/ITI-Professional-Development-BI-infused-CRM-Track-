#include <iostream>

using namespace std;
bool isLeapYear(int year) {
    if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        return true;
    return false;
}

bool isThirtyMon(int mon)
{
    if(mon == 4 || mon == 6 || mon == 9 || mon == 11)
        return true;
    return false;

}


int main()
{
    /////1- Birthdate
    int currentday=20;
    int currentmonth=10;
    int currentyear=2025;

    int year,month,day;

    do
    {
    cout<<"plz enter your year from 1980->2025: ";
    cin>>year;
    }while(year<1980 || year>2025);

    do
    {
    cout<<"\nplz enter your month 1-12: ";
    cin>>month;
    }while(month<1 || month>12);

    do
    {
    cout<<"\nplz enter your day: ";
    cin>>day;
    }while( (day > 28 && month == 2 && !isLeapYear(year)) || (day > 29 && month == 2 && isLeapYear(year)) || day<1 || day>31);

    int UserY = currentyear - year;
    int UserM = currentmonth - month;
    int UserD = currentday - day;



    if(UserD<0 && isThirtyMon(UserM)){
        UserD +=30;
        UserM--;
    }

    if(UserD<0 && !isThirtyMon(UserM)){
        UserD +=31;
        UserM--;
    }
    if(UserD<0 && UserM==2 && !isLeapYear(year)){
        UserD +=28;
        UserM--;
    }
    if(UserD<0 && UserM==2 && isLeapYear(year)){
        UserD +=29;
        UserM--;
    }

    if(UserM<0)
    {
    UserM += 12;
    UserY --;
    }

    cout<<"you're "<<UserY<<"y "<<UserM<<" months and "<<UserD <<" days"<<endl;

    return 0;



}
