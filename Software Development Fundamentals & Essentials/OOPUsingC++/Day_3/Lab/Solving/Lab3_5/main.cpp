#include <iostream>

using namespace std;

int main()
{
    ///2D Array

    int arr[3][4] = {
        {1, 2, 3, 4},
        {5, 6, 7, 8},
        {9, 10, 11, 12}
    };

    float arrOfAvg[4];
    for(int i =0 ; i<4 ; i++ )
    {
        int sumCol=0;
        for(int j=0 ; j<3 ; j++)
        {
            sumCol+=arr[j][i];
        }
        arrOfAvg[i] = sumCol;
        cout<<endl;
    }

    system("cls");
    for(int i =0 ; i < 4 ; i++)
    {
        cout<<arrOfAvg[i]/3 << "\t";
    }
}
