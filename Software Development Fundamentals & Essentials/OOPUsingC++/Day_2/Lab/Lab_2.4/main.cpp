#include <iostream>
using namespace std;

float add(float a, float b){
  return a + b;
}
float sub(float a, float b)
{
  return a - b;
}
float mul(float a, float b)
{
  return a * b;
}
float div(float a, float b) {
    return a / b;
}


int main() {
    float num1, num2, result;
    char operation, flag;

    do {
        cout << "plz enter #1: ";
        cin >> num1;
        cout << "plz enter operator: ";
        cin >> operation;

        cout << "plz enter #2: ";
        cin >> num2;

        switch (operation) {
            case '+':
                result = add(num1, num2);
                break;
            case '-':
                result = sub(num1, num2);
                break;
            case '*':
                result = mul(num1, num2);
                break;
            case '/':
                while(num2 == 0)
                {
                    cout<<"can not divide by zero\n";
                    cout << "plz enter #2: ";
                    cin>>num2;
                }
                result = div(num1 , num2);
                break;
            default:
                cout << "Invalid operator!\n";
                break;
        }

        cout << num1 << operation << num2 << " = " << result << endl;

        cout << "Continue ??? y or n: ";
        cin >> flag;

    } while (flag == 'y' || flag == 'Y');

    cout << "Program end\n";
    return 0;
}


