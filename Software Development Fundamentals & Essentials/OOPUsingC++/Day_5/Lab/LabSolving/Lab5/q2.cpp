/*
#include <iostream>
using namespace std;

int main() {
    int rows, cols;
    cout << "Enter rows and cols: ";
    cin >> rows >> cols;

    int *ptrArr = new int[rows];
    for (int i = 0; i < rows; i++) {
        ptrArr[i] = new int[cols];
    }

    cout << "Enter elements:\n";
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            cin >> ptrArr[i][j];
        }
    }

    cout << "\nMatrix:\n";
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            cout << ptrArr[i][j] << " ";
        }
        cout << endl;
    }

}
*/
