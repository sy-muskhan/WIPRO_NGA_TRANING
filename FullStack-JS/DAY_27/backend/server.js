const express = require("express");
const http = require("http");
const { Server } = require("socket.io");
const cors = require("cors");
const { v4: uuidv4 } = require("uuid");

const app = express();
const server = http.createServer(app);
const io = new Server(server, { cors: { origin: "*" } });

app.use(cors());
app.use(express.json());

let tasks = [];
let users = [];

io.on("connection", (socket) => {
  console.log("User connected:", socket.id);

  // =============================
  // REGISTER USER
  // =============================
  socket.on("registerUser", ({ name, role }) => {
    const newUser = { id: socket.id, name, role };
    users.push(newUser);

    io.emit("usersUpdated", users);
    socket.emit("loadTasks", tasks);
  });

  // =============================
  // ADD TASK
  // =============================
  socket.on("addTask", (taskData) => {
    const newTask = {
      id: uuidv4(),
      title: taskData.title,
      description: taskData.description,
      deadline: taskData.deadline,
      assignee: taskData.assignee,
      createdAt: new Date()
    };

    tasks.push(newTask);

    // Emit proper event
    io.emit("taskAdded", newTask);

    // Send full updated list
    io.emit("taskUpdated", tasks);

    // Notify assigned user
    io.emit("userNotified", {
      message: `New task assigned to ${newTask.assignee}`
    });
  });

  // =============================
  // UPDATE TASK
  // =============================
  socket.on("updateTask", (updatedTask) => {
    tasks = tasks.map(task =>
      task.id === updatedTask.id ? updatedTask : task
    );

    io.emit("taskUpdated", tasks);
  });

  // =============================
  // DELETE TASK
  // =============================
  socket.on("deleteTask", (taskId) => {
    tasks = tasks.filter(task => task.id !== taskId);

    io.emit("taskDeleted", taskId);
    io.emit("taskUpdated", tasks);
  });

  // =============================
  // REMOVE USER (ADMIN)
  // =============================
  socket.on("removeUser", (userId) => {
    users = users.filter(user => user.id !== userId);
    io.emit("usersUpdated", users);
  });

  // =============================
  // DISCONNECT
  // =============================
  socket.on("disconnect", () => {
    users = users.filter(user => user.id !== socket.id);
    io.emit("usersUpdated", users);
    console.log("User disconnected:", socket.id);
  });
});

server.listen(5000, () => {
  console.log("Server running on port 5000");
});

