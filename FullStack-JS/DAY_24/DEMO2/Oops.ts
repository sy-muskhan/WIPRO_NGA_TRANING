//Type script supports Object Oriented Programming concepts like Classes, Inheritance, Encapsulation, and Polymorphism. Below are some examples demonstrating these concepts in TypeScript.
// typescript supports oops concepts such as classes, inheritance, interfaces, and access modifiers
// Example of a class with properties and methods
class Person {
    private name: string; // private access modifier
    protected age: number; // protected access modifier
    constructor(name: string, age: number) {
        this.name = name;
        this.age = age;
    }   
    public introduce(): void { // public access modifier
        console.log(`Hello, my name is ${this.name} and I am ${this.age} years old.`);
    }
}
const person1 = new Person("Alice", 30);
person1.introduce(); // Output: Hello, my name is Alice and I am 30 years old.

// Inheritance example
class Employee extends Person {
    private employeeId: number;
    constructor(name: string, age: number, employeeId: number) {
        super(name, age); // calling the constructor of the parent class
        this.employeeId = employeeId;
    }
    public work(): void {
       // console.log(`${this.name} is working with employee ID: ${this.employeeId}`); // Error: Property 'name' is private and only accessible within class 'Person'.
    }       

}
const employee1 = new Employee("Bob", 28, 101);
employee1.introduce(); // Output: Hello, my name is Bob and I am 28 years old.
// employee1.work(); // This will cause an error because 'name' is private in Person class

// Interface example
interface Shape {
    area(): number;
    perimeter(): number;
}
class Rectangle implements Shape {
    private width: number;
    private height: number;
    constructor(width: number, height: number) {
        this.width = width;
        this.height = height;
    }
    public area(): number {
        return this.width * this.height;
    }
    public perimeter(): number {
        return 2 * (this.width + this.height);
    }  
}
const rectangle = new Rectangle(10, 5);
console.log(`Area: ${rectangle.area()}`);
console.log(`Perimeter: ${rectangle.perimeter()}`);

// Polymorphism example
class Circle implements Shape {
    private radius: number;
    constructor(radius: number) {
        this.radius = radius;
    }   
    public area(): number {
        return Math.PI * this.radius * this.radius;
    }
    public perimeter(): number {
        return 2 * Math.PI * this.radius;
    }
}
const circle = new Circle(7);
console.log(`Area: ${circle.area()}`);
console.log(`Perimeter: ${circle.perimeter()}`);
// In the above examples, we have demonstrated the core OOP concepts in TypeScript including classes, inheritance, access modifiers (public, private, protected), interfaces, and polymorphism.
// These features help in creating structured and maintainable code using Object Oriented Programming principles.