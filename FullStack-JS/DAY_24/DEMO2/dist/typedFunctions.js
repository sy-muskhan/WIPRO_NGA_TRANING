"use strict";
//TypedFunctions in TypeScript
function add(a, b) {
    return a + b;
}
const sum = add(5, 10);
console.log(`Sum: ${sum}`);
//Another example with string parameters
function concatenate(str1, str2) {
    return str1 + str2;
}
function greet(name) {
    return `Hello, ${name}!`;
}
//Usiing Arrow function syntax with types
const multiply = (x, y) => {
    return x * y;
};
const greetArrow = (name) => `Hi, ${name}!`;
console.log(concatenate("Type", "Script"));
// Optinal Parameter just like in JavaScript we can have optional parameters in TypeScript functions as well
function introduce(name, age) {
    if (age) {
        return `My name is ${name} and I am ${age} years old.`;
    }
    else {
        return `My name is ${name}.`;
    }
}
//Use Case od Optional Parameter is while calling a funtion we may or may not have all the information available, so we can make some parameters optional to provide flexibility in how the function is called. In above example, age is an optional parameter, so we can call introduce function with just name or with both name and age.
console.log(introduce("Alice", 30));
console.log(introduce("Bob"));
console.log(multiply(4, 5));
console.log(greet("Charlie"));
console.log(greetArrow("David"));
