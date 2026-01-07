#include <iostream>

using namespace std;

int main()
{
    //7-  3*3     *    3*2   =  3*2

    int A[3][3];
    int B[3][2];
    int result[3][2]={0};

    cout << "Enter First Matrix: " << endl;
    for (int i = 0; i < 3; i++)
    {
        cout << "Enter values of Row Number " << i + 1 << ":" << endl;
        for (int j = 0; j < 3; j++)
        {
            cout << "Enter Value of Col Number " << j + 1 << " : ";
            cin >> A[i][j];
        }
    }

    cout << "\nEnter Second Matrix: " << endl;
    for (int i = 0; i < 3; i++)
    {
        cout << "Enter values of Row Number " << i + 1 << ":" << endl;
        for (int j = 0; j < 2; j++)
        {
            cout << "Enter Value of Col Number " << j + 1 << " : ";
            cin >> B[i][j];
        }
    }

    for(int i = 0 ; i < 3 ; i++)
    {
        for(int j=0 ; j<2 ; j++)
        {
            for(int k =0 ; k<3 ; k++)
            {
                result[i][j] +=A[i][k] * B[k][j];
            }
            /*result[i][j] = A[i][j] * B[i][j] +
                           A[i][j+1] * B[i+1][j]+
                           A[i][j+1] * B[i+2][j];*/
        }
    }



    cout<<"------------------Result<------------------"<<endl;


    for(int i=0 ; i<3 ;i++)
    {
        for(int j=0 ; j<2 ; j++)
        {
            cout<<result[i][j]<<"\t";
        }
        cout<<endl;
    }

    return 0;
}
