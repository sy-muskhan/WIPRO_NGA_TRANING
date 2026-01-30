// Accept student name
let studentName = prompt("Enter student name:");

// Store subjects in array
let subjects = ["English", "Hindi", "Telugu", "Maths", "Science", "Social"];

// Array to store marks
let marks = [];

// Variables
let totalMarks = 0;
let isFailed = false;
let resultHTML = "";

// Accept marks for each subject
for (let i = 0; i < subjects.length; i++) {
    let mark = Number(prompt("Enter marks for " + subjects[i] + ":"));
    marks.push(mark);
    totalMarks += mark;

    // Check pass/fail per subject
    if (mark < 35) {
        isFailed = true;
        resultHTML += `
            <div class="subject">
                ${subjects[i].toUpperCase()}: 
                <span class="fail">${mark} (FAIL)</span>
            </div>`;
    } else {
        resultHTML += `
            <div class="subject">
                ${subjects[i].toUpperCase()}: 
                <span class="pass">${mark} (PASS)</span>
            </div>`;
    }
}

// Overall result
let overallResult = isFailed ? "FAIL" : "PASS";
let resultClass = isFailed ? "fail" : "pass";

// Display output using string methods
document.getElementById("output").innerHTML = `
    <div>
        <strong>Name:</strong> ${studentName.toUpperCase()}
    </div>
    <hr>
    ${resultHTML}
    <div class="total">
        TOTAL MARKS: ${totalMarks}
    </div>
    <div class="overall ${resultClass}">
        OVERALL RESULT: ${overallResult}
    </div>
`;