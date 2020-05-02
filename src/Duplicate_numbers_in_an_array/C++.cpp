#include <iostream>
#include <stdio.h>
int main()
{
    int n,i;
    int a[10]={2,2,2,4,6,6,9,10,10,11};
    printf("%d\n",a[10]);
    for(i=0;i<10;++i)
    {
        if(a[i]==a[i+1] && a[i]!=a[i-1])
            printf("%d ",a[i]);
        else
            continue;
    }
    return 0;
}
