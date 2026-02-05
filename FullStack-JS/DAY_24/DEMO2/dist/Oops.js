"use strict";
//Type script supports Object Oriented Programming concepts like Classes, Inheritance, Encapsulation, and Polymorphism. Below are some examples demonstrating these concepts in TypeScript.
// typescript supports oops concepts such as classes, inheritance, interfaces, and access modifiers
// Example of a class with properties and methods
class Person {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }
    introduce() {
        console.log(`Hello, my name is ${this.name} and I am ${this.age} years old.`);
    }
}
const person1 = new Person("Alice", 30);
person1.introduce(); // Output: Hello, my name is Alice and I am 30 years old.
// Inheritance example
class Employee extends Person {
    constructor(name, age, employeeId) {
        super(name, age); // calling the constructor of the parent class
        this.employeeId = employeeId;
    }
    work() {
        // console.log(`${this.name} is working with employee ID: ${this.employeeId}`); // Error: Property 'name' is private and only accessible within class 'Person'.
    }
}
const employee1 = new Employee("Bob", 28, 101);
employee1.introduce(); // Output: Hello, my name is Bob and I am 28 years old.
class Rectangle {
    constructor(width, height) {
        this.width = width;
        this.height = height;
    }
    area() {
        return this.width * this.height;
    }
    perimeter() {
        return 2 * (this.width + this.height);
    }
}
const rectangle = new Rectangle(10, 5);
console.log(`Area: ${rectangle.area()}`);
console.log(`Perimeter: ${rectangle.perimeter()}`);
// Polymorphism example
class Circle {
    constructor(radius) {
        this.radius = radius;
    }
    area() {
        return Math.PI * this.radius * this.radius;
    }
    perimeter() {
        return 2 * Math.PI * this.radius;
    }
}
const circle = new Circle(7);
console.log(`Area: ${circle.area()}`);
console.log(`Perimeter: ${circle.perimeter()}`);
// In the above examples, we have demonstrated the core OOP concepts in TypeScript including classes, inheritance, access modifiers (public, private, protected), interfaces, and polymorphism.
// These features help in creating structured and maintainable code using Object Oriented Programming principles.
