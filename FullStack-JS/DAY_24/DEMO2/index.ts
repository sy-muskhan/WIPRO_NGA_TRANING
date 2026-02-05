// TypeScript allows explicit typing.
let message: string = "Hello, TypeScript!"; 
// In above line, we declare a variable 'message' of type 'string' and assign it a value.
console.log(message);
let age  = 30; // TypeScript infers the type as number
console.log(`I am ${age} years old.`);
let isActive: boolean = true;
if (isActive) { 
    console.log("The user is active.");
} else {
    console.log("The user is not active.");
}

//Here we can work with Arrays and Objects as well
let numbers: number[] = [1, 2, 3, 4, 5];
console.log("Numbers:", numbers);

let person: { name: string; age: number } = { name: "Alice",
 age: 25
};
console.log("Person:", person);

//Here we have interfaces and classes unlike JavaScript
interface Animal {
    name: string;
    speak(): void;
}

// User interface defines the structure of an object, ensuring that it adheres to a specific contract. In this case, any object that implements the User interface must have a name property of type string and an age property of type number.
interface User {
    name: string;
    age: number;
}

const user: User  = {name: "John",age: 28};
class Animal {
    name: string;
    constructor(name: string) {
        this.name = name;
    }
    speak(): void {
        console.log(`${this.name} makes a noise.`);
    }   
}

const dog = new Animal("Dog");
dog.speak(); // Output: Dog makes a noise.
const cat = new Animal("Cat");
cat.speak(); // Output: Cat makes a noise.

//Interface offers a way to define the structure of an object, ensuring that it adheres to a specific contract.
