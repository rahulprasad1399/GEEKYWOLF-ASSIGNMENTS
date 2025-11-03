// QUESTION - 1

var num = 10;
function test() {
    var num = 20;
    if (true) {
        let num = 30;
        console.log("Inside if : ", num);   // num = 30
    }
    console.log("Inside function : ", num);   // num = 20
}
test();
console.log("Outside", num);   // num = 10


// QUESTION - 2

console.log(name);  // undefined 
var name = "rahul"

console.log(mark, movie)   // it will show an error saying cannot access it befor initialization
const movie = "inception"
let mark = 50

// Show accessing each variable before declaration, observe output/errors, and explain the difference.

console.log(a);
console.log(b);
console.log(c);
var a = 5;
let b = 10;
const c = 15;
// Both var, let, and const are hoisted in JavaScript. However, only variables declared with var are initialized with undefined during hoisting.
// Variables declared with let and const are also hoisted, but they are not initialized, they stay in the Temporal Dead Zone (TDZ) until their declaration line is executed.


// QUESTION - 3 
var firstName = "rahul"
let lastName = "prasad"
const grade = 'S'

firstName = "prasad"
lastName = "rahul"
grade = 'A'

console.log(firstName);
console.log(lastName);
console.log(grade);   // Assignment to a const variable 

var firstName = "Harry"
console.log(firstName)
let lastName = "Ron"    // it will throw an error saying last name is already declared
console.log(lastName)

grade = "P" // Assignment to a const variable 
console.log(grade)


// QUESTION - 4
const multiply = (a, b) => a*b;
const greet = name => "Hello" + name;

const numbers = [2, 5, 8, 11, 14];

// Return a new array where each number is doubled (map)
let doubledNumbers = numbers.map((num)=>num*2);
console.log(doubledNumbers)

// Return only even numbers (filter)
let evenNumbers = numbers.filter((num)=>num%2 == 0)
console.log(evenNumbers)

// Return total sum (reduce)
let sum = numbers.reduce((acc, num)=> acc + num,0)
console.log(sum)