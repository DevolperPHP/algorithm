def isPalindrome(s): 

	rev = ''.join(reversed(s)) 
  
	if (s == rev): 
		return True
	return False

# main function 
s = "malayalam"
ans = isPalindrome(s) 

if (ans): 
	print("Yes") 
else: 
	print("No") 
