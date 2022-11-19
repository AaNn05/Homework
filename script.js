//1

let a = +prompt("Enter a number");
let b = +prompt("Enter a number");

if(a > b) {
    alert(a+b);
    alert(a-b);
    alert(a*b);
    alert(a/b);
    alert(a%b); 
} else {
	alert("False");
}



//2

let name = "Nare";
let age = 17;
let hello = `My name is ${name}, I am ${age} years old.`
console.log(hello);


//3

let number = +prompt("Enter a number");
if(number < 0) {
 alert("Yes")
 
} else {
alert("No");
}


//4

let number = +prompt("Enter a number");

if(number % 2 === 0) {
	alert("even")

} else {
	alert("odd");
}

//5

let number1 = +prompt("Enter a number");
let number2 = +prompt("Enter a number");
if (number1 % number2 === 0 || number2 % number1 === 0) {
  console.log(1)
} else {
  console.log(0)
}
