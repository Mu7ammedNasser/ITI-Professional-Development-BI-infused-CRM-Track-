#include <iostream>

using namespace std;

int main()
{
    ///6-multiply 2 matrix
    //3*2    *  2*1  =  3*1


    int arr1[3][2] ;

    int arr2[2][1];

    int result[3][1];

    cout << "Enter First Matrix: " << endl;
    for (int i = 0; i < 3; i++)
    {
        cout << "Enter values of Row Number " << i + 1 << ":" << endl;
        for (int j = 0; j < 2; j++)
        {
            cout << "Enter Value of Col Number " << j + 1 << " : ";
            cin >> arr1[i][j];
        }
    }

    cout << "\nEnter Second Matrix: " << endl;
    for (int i = 0; i < 2; i++)
    {
        cout << "Enter values of Row Number " << i + 1 << ":" << endl;
        for (int j = 0; j < 1; j++)
        {
            cout << "Enter Value of Col Number " << j + 1 << " : ";
            cin >> arr2[i][j];
        }
    }



    for(int i=0 ; i < 3 ; i++)
    {
        result[i][0] = arr1[i][0] * arr2[i][0] + arr1[i][1] * arr2[i+1][0];
    }

    system("cls");
    cout<<"------------------Result<------------------";

    for(int i=0 ; i < 3 ;i++  )
    {
        cout<<result[i][0]<<endl;
    }

}
