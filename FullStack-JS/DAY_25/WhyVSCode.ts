// Why VS Code for Typescript ?
// 1. Built-in support for TypeScript: VS Code has built-in support for TypeScript, which means you can start writing TypeScript code without needing to install any additional extensions. It provides features like syntax highlighting, code completion, and error checking out of the box.  
// 2. IntelliSense: VS Code's IntelliSense provides intelligent code completion, parameter info, and quick info for TypeScript. It helps you write code faster and with fewer errors by suggesting relevant code snippets and providing documentation on the fly.
// 3. Debugging: VS Code has a powerful built-in debugger that supports TypeScript. You can set breakpoints, step through code, and inspect variables directly within the editor, making it easier to identify and fix issues in your TypeScript code.
// 4. Integrated Terminal: VS Code includes an integrated terminal that allows you to run TypeScript commands, such as compiling your code or running tests, without leaving the editor. This streamlines your workflow and keeps everything in one place.
// 5. Extensions: VS Code has a rich ecosystem of extensions that enhance the TypeScript development experience. You can find extensions for linting, formatting, testing, and more, which can help you maintain code quality and improve productivity.
// 6. Version Control Integration: VS Code has built-in support for Git and other version control systems. This allows you to manage your TypeScript projects with ease, track changes, and collaborate with other developers seamlessly.
// Overall, VS Code provides a comprehensive and efficient environment for TypeScript development, making it a popular choice among developers for building TypeScript applications. Its features and extensions help improve productivity, code quality, and debugging capabilities, making it an excellent tool for working with TypeScript.

// Below are some examples of union types in TypeScript that demonstrate how they can be used to handle different scenarios in a type-safe manner.
// 1. API Response Handling
// example: A function that handles API responses that can either be a success response with data or an error response with a message.
interface ApiResponses {
    status: "success" | "error";
    data?: string; // Optional property for success response
    message?: string; // Optional property for error response
}
function handleApiResponses(response: ApiResponses) {
    if (response.status === "success") {
        console.log("Data:", response.data);
    }
    else {
        console.log("Error Message:", response.message);
    }
}
// Example usage:
const successResponses: ApiResponses = {
    status: "success",
    data: "Here is your data!"
};
const errorResponses: ApiResponses = {
    status: "error",
    message: "Something went wrong."
};
handleApiResponses(successResponses);
handleApiResponses(errorResponses);

//VS Code Support below Built-in commands in CLI :
// 1. tsc: The TypeScript compiler command, used to compile TypeScript files into JavaScript.
// 2. ts-node: A command that allows you to run TypeScript files directly without needing to compile them first.
// 3. tslint: A command for linting TypeScript code, helping to enforce coding standards and catch potential errors.
// 4. jest: A testing framework command that can be used to run tests written in TypeScript.
// 5. npm: The Node Package Manager command, which is commonly used to manage dependencies in TypeScript projects.
// 6. git: The version control system command, which can be used to manage source code and collaborate with other developers on TypeScript projects.
// Example usage of tsc command in CLI:
// To compile a TypeScript file named "app.ts" into JavaScript, you can run the following command in the terminal:
// tsc app.ts
// This will generate a corresponding "app.js" file that contains the compiled JavaScript code. You can then run the JavaScript file using Node.js or include it in a web application as needed.

// Intellisense in VS Code provides intelligent code completion, parameter info, and quick info for TypeScript. 
// It helps you write code faster and with fewer errors by suggesting relevant code snippets and providing documentation on the fly. 
// With IntelliSense, you can easily navigate through your TypeScript code, access type information, and get real-time feedback on potential issues, making it an invaluable tool for TypeScript development in VS Code. 
//Real time Error Checking in VS Code for TypeScript allows developers to identify and fix errors in their code as they write it. 
// This feature provides immediate feedback on syntax errors, type mismatches, and other issues, helping to improve code quality and reduce the likelihood of runtime errors. 
// With real-time error checking, developers can quickly address problems and ensure that their TypeScript code is correct and efficient before running it.