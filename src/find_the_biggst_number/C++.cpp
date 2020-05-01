#include <iostream>
using namespace std;
int main() {
  int num1 = 23;
  int num2 = 235;
  int num3 = 2677;

  if(num1 >= num2 && num1 >= num3){
    cout<<num1<<" is the biggest number";
  } else if(num2 >= num1 && num2 >= num3){
    cout<<num2<<" is the biggest number";
  } else if(num3 >= num1 && num3 >= num2){
    cout<<num3<<" is the Minimum number";
  }
}
