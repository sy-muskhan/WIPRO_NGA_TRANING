//Below are some scenarios of type safety in TypeScript.
// 1. Type Inference
let message = "Hello, TypeScript!"; // TypeScript infers the type as string
//message = 42; // Error: Type 'number' is not assignable to type 'string'
// 2.Explicit Type Annotations
let count: number = 10; 
// count = "ten"; // Error: Type 'string' is not assignable to type 'number'
// 3. Function Parameter Types
function greet(name: string): string {
    return `Hello, ${name}!`;
}
// console.log(greet(123)); // Error: Argument of type 'number' is not assignable to parameter of type 'string'
// 4. Interface and Type Aliases
interface User {
    name: string;
    age: number;
}
const user: User = {
    name: "Alice",
    age: 30
};
// user.age = "thirty"; // Error: Type 'string' is not assignable to type 'number'
// 5. Union Types
function printId(id: number | string) {
    console.log(`ID: ${id}`);
}
printId(123); // Valid
printId("abc"); // Valid
// printId(true); // Error: Argument of type 'boolean' is not assignable to parameter of type 'number | string'
// 6. Type Assertions
let someValue: any = "This is a string";
let strLength: number = (someValue as string).length;
