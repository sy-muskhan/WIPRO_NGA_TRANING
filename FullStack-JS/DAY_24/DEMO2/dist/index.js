"use strict";
// TypeScript allows explicit typing.
let message = "Hello, TypeScript!";
// In above line, we declare a variable 'message' of type 'string' and assign it a value.
console.log(message);
let age = 30; // TypeScript infers the type as number
console.log(`I am ${age} years old.`);
let isActive = true;
if (isActive) {
    console.log("The user is active.");
}
else {
    console.log("The user is not active.");
}
//Here we can work with Arrays and Objects as well
let numbers = [1, 2, 3, 4, 5];
console.log("Numbers:", numbers);
let person = { name: "Alice",
    age: 25
};
console.log("Person:", person);
const user = { name: "John", age: 28 };
class Animal {
    constructor(name) {
        this.name = name;
    }
    speak() {
        console.log(`${this.name} makes a noise.`);
    }
}
const dog = new Animal("Dog");
dog.speak(); // Output: Dog makes a noise.
const cat = new Animal("Cat");
cat.speak(); // Output: Cat makes a noise.
//Interface offers a way to define the structure of an object, ensuring that it adheres to a specific contract.
