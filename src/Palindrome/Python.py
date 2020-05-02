def isPalindrome(s):    نسوي الفنكشن نعرف بيه المطلوب

	rev = ''.join(reversed(s)) 
  
	if (s == rev): نعطي الشرط اذا تطابقة القيمة مع معاكسها
		return True
	return False

# main function 
s = "malayalam" هذي هي القيمة
ans = isPalindrome(s)  نقله نجرب القيمة اذا توافقت او لا

if (ans): 
	print("Yes") اذا توافقت نقله نعم
else: 
	print("No") واذا ما توافقت نحط لا
