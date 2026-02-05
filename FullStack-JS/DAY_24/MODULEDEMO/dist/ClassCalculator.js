"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Calculator = void 0;
// here we will create a class calculator which will have 4 methods add, sub, mul, div
// and we will export this class and then we will import this class in another file and use it  
class Calculator {
    add(a, b) {
        return a + b;
    }
    sub(a, b) {
        3;
        return a - b;
    }
    mul(a, b) {
        return a * b;
    }
    div(a, b) {
        if (b === 0) {
            throw new Error("Division by zero is not allowed");
        }
        return a / b;
    }
}
exports.Calculator = Calculator;
