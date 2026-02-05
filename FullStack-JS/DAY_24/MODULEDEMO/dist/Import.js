"use strict";
//Here we will create a class calculator which will have 4 methods add, sub, mul, div
// and we will export this class and then we will import this class in another file and use it
Object.defineProperty(exports, "__esModule", { value: true });
const ClassCalculator_1 = require("./ClassCalculator");
const calc = new ClassCalculator_1.Calculator();
console.log(`Addition: ${calc.add(10, 5)}`);
console.log(`Subtraction: ${calc.sub(10, 5)}`);
console.log(`Multiplication: ${calc.mul(10, 5)}`);
console.log(`Division: ${calc.div(10, 5)}`);
