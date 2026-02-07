//Below are some industry use cases with union are declared and implemented in TypeScript.

//Handling Multiple Types in Function Parameters
function formatInput(input: string | number): string {
    if (typeof input === "string") {
        return `You entered the string: ${input}`;
    } else {
        return `You entered the number: ${input}`;
    }
}

console.log(formatInput("Hello"));
console.log(formatInput(42));

// 2. API Response Handling
//Example: An API response that can return either a success object or an error object
interface SuccessResponse {
    status: "success";
    data: string;
}
interface ErrorResponse{
    status: "error";
    message: string;
}
type ApiResponse = SuccessResponse | ErrorResponse;
function handleApiResponse(response: ApiResponse) {
    if (response.status === "success") {
        console.log("Data:", response.data);
    }
    else {
        console.log("Error Message:", response.message);
    }
}
// Example usage:
const successResponse: ApiResponse = {
    status: "success",
    data: "Here is your data!"
};
const errorResponse: ApiResponse = {    
    status: "error",
    message: "Something went wrong."
};
handleApiResponse(successResponse);
handleApiResponse(errorResponse);


// 3. Event Handling
// example: An event handler that can accept either a mouse event or a keyboard event.

function handleEvent(event: MouseEvent | KeyboardEvent) {
    if (event instanceof MouseEvent) {    
        console.log("Mouse event at coordinates:", event.clientX, event.clientY);
    }
    else {
        console.log("Keyboard event with key:", event.key);
    }
}
// Note: In a real application, you would typically attach this handler to actual events, but for demonstration purposes, we can create mock events.
const mockMouseEvent = new MouseEvent("click", { clientX: 100, clientY: 200 });
const mockKeyboardEvent = new KeyboardEvent("keydown", { key: "Enter" }); {
    handleEvent(mockMouseEvent);
    handleEvent(mockKeyboardEvent);
}


// Compile time error chaecking in typescript is very useful to avoid runtime errors and ensure that the code behaves as expected. Union types allow us to handle multiple types in a flexible way while still maintaining type safety.
// below are a few more examples of union types in TypeScript: that handles different scenarios in a type-safe manner.
// 5. Optional Properties in Interfaces
// example: An interface that defines an optional property that can be either a string or undefined.
interface UserProfile {
    username: string;
    email: string;
    phoneNumber?: string | undefined; // Optional property that can be a string or undefined
}
const userProfile1: UserProfile = {
    username: "john_doe",    
    email: "john@example.com",
    phoneNumber: "123-456-7890"
};
const userProfile2: UserProfile = {
    username: "jane_doe",    
    email: "jane@example.com"
};
console.log("User Profile 1:", userProfile1);
console.log("User Profile 2:", userProfile2);
// In this example, the phoneNumber property is optional and can either be a string or undefined. This allows us to create user profiles with or without a phone number while still maintaining type safety.