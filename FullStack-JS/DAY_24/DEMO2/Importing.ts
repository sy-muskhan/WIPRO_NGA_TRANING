import {Calculator} from './ClassCalculator';
const num1 = 20;
const num2 = 5;

const addition = Calculator.add(num1, num2);
console.log(`Addition: ${addition}`);

const result2 = Calculator.multiply(8, 4);
console.log(`Multiplication: ${result2}`);

const result3 = Calculator.subtract(15, 7);
console.log(`Subtraction: ${result3}`);

const result4 = Calculator.divide(20, 4);
console.log(`Division: ${result4}`);