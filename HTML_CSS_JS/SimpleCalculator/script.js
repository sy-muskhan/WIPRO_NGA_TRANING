// Core logic for the following operations: addition, subtraction, multiplication, and division.
// Step 1: Append Values 
// Step 2: Clear Screen
// Step 3: Perform Calculation

function appendValue(value) {
    // Reading the current value from the display
    // Using DOM we can read the value of the input field with id "display"
    document.getElementById("result").value += value;
}

function clearResult() {
    document.getElementById("result").value = "";
}
function calculate() {
    // Variables to hold expression and output
    let expression = document.getElementById("result").value;
    let output = eval(expression);
    document.getElementById("result").value = output;
}