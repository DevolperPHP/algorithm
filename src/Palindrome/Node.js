console.log("Please enter some text!!")
var sys = require("sys");
var stdin = process.openStdin();
stdin.addListener("data", function(userInputedWord){
	var userString = userInputedWord.toString().substring(0,userInputedWord.length-1);
	if(userString === "exit"){
		process.kill();
	}else{
		var userStringPaladrone = userString.split('').reverse().join('');
		if(userString === userStringPaladrone){
			console.log(userStringPaladrone + " is a palindrome!")
		}else{
			console.log("Sorry!! Looks like " + userString + " is not a palindrome.")
		};
	};
});
