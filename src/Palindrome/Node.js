console.log("Please enter some text!!") // نظهر للمستخدم رسالة ادخال القيمة
var sys = require("sys"); // نستدعي هذي المكتبة
var stdin = process.openStdin();
stdin.addListener("data", function(userInputedWord){
	var userString = userInputedWord.toString().substring(0,userInputedWord.length-1); // ناخذ القيمة المدخلة
	if(userString === "exit"){
		process.kill();
	}else{
	 var userStringPaladrone = userString.split('').reverse().join(''); // ما نحتاج فور لوب بالنود لان هذا الكود يعكس الكلام
if(userString === userStringPaladrone){ // نحط شرط اذا تتطابق القيمة المعكوسة مع القيمة المدخلة من المستخدم يرسله بان القيمة متشابهة
		console.log(userStringPaladrone + " is a palindrome!") 
		}else{
			console.log("Sorry!! Looks like " + userString + " is not a palindrome.")
		};
	};
});
