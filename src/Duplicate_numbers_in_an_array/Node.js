var arr = [1,1,1,1,2,2,3,3,4];

for(i=0; i<8; i++){
  if(arr[i]==arr[i+1] && arr[i]!==arr[i-1]){
    console.log(arr[i]);
  }
}
