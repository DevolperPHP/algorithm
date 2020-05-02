#include<iostream>
#include<string.h>
// هذي المكتبات الي نحتاجها 
using namespace std;
int main()
{
        // احنا راح تعكس الاحرف فا لازم ناخذ نوع البيانات بصيغة احرف
        char str[100];
        int i, length;
        int flag = 0;    

        // هنا بتطلب من  المستخدم يدخل القيمة
        cout<<"\n Enter String : ";
        cin>>str;    //نسجل القيمة الي دخلها 

        length = strlen(str);    // نستدعي عدد الاحرف للكلمة الي تم ادخالها

        //اصغر من عدد الاحرفiنسوي فور لوب و يكون ال 
        for(i=0;i < length ;i++)
        {
                if(str[i] != str[length-i-1]) // flag هنا نحط الشزط اذا انعكس نظيف قيمة لل 
                {
                        flag = 1;
                        break;
                }
        }    
        if(flag) // اذا زادة قيمته يعني الكلمةتنقري من الجهتينflagنحط شرط للقيمة ال 
        {
                cout<<" "<<str<<" is not a palindrome"<<endl;
        }    
        else
        {
                cout<<" "<<str<< " is a palindrome"<<endl;
        }
        return 0;
}
