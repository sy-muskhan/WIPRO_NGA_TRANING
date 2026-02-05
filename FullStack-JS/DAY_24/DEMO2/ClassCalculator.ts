// //Here We can use modules for better code organization and reusability. Modules allow us to encapsulate code and export only what is necessary, making it easier to manage dependencies and maintain a clean codebase.
// //Importing functions and classes from other files
// import { add, concatenate, greet, multiply, greetArrow, introduce } from "./typedFunctions";
// import { Employee, Rectangle, Circle } from "./Oops";       
// //Using imported functions
// const sum = add(15, 25);
// console.log(`Sum from module: ${sum}`); 
// console.log(concatenate("Module", "Example"));
// console.log(greet("Module User"));
// console.log(multiply(6, 7));


export class Calculator {

  static add(x: number, y: number): number {
    return x + y;
  }

  static subtract(x: number, y: number): number {
    return x - y;
  }

  static multiply(x: number, y: number): number {
    return x * y;
  }

  static divide(x: number, y: number): number {
    if (y === 0) {
      throw new Error("Division by zero is not allowed");
    }
    return x / y;
  }
}