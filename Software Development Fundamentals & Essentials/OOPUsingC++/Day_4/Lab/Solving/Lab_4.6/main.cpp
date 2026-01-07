#include <iostream>

using namespace std;
int *getArray() {
    static int arr[5] = {1, 2, 3, 4, 5};
    return arr;
}

/*int[] getArray() {
    static int arr[5] = {1, 2, 3, 4, 5};
    return arr;
}
*/
int main()
{
    int *ptr = getArray();
    for(int i ; i<5 ; i++)
        cout<<ptr[i];
    return 0;
}
