function palindrome($str){
  if(strtolower($str) === strtolower(strrev($str))){
    return true;
  }else{
    return false;
  }
}

if(palindrome("Malayalam")){
  echo "its Plaindrome\n";
}else {
  echo "its not Plaindrome\n";
}


function palindrome2($str){
  $strrev = "";
  
  for($i = 1; $i <= strlen($str); $i++){
    $strrev .= substr($str, strlen($str) - $i, 1);
  }
  
  if(strtolower($str) === strtolower($strrev)){
    return true;
  }else{
    return false;
  }
}

if(palindrome("huh")){
  echo "its Plaindrome\n";
}else {
  echo "its not Plaindrome\n";
}
