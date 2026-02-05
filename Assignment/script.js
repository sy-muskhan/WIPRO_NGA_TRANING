document.getElementById("userForm").addEventListener("submit", function (event) {
    event.preventDefault();

    let name = document.getElementById("name").value.trim();
    let email = document.getElementById("email").value.trim();
    let result = document.getElementById("result");

    if (name === "" || email === "") {
        result.style.color = "red";
        result.textContent = "Please fill all fields.";
        return;
    }

    result.style.color = "green";
    result.textContent = "Form submitted successfully!";
});
