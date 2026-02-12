const express = require("express");
const http = require("http");
const { Server } = require("socket.io");
const cors = require("cors");

const app = express();
const server = http.createServer(app);

const io = new Server(server, {
  cors: {
    origin: "*",
  },
});

app.use(cors());
app.use(express.json());

// In-memory task storage
let tasks = [];

io.on("connection", (socket) => {
  console.log("User connected:", socket.id);

  // Send existing tasks
  socket.emit("loadTasks", tasks);

  // Add new task
  socket.on("addTask", (task) => {
    tasks.push(task);
    io.emit("taskAdded", task);
  });

  // Update task
  socket.on("updateTask", (updatedTask) => {
    tasks = tasks.map((task) =>
      task.id === updatedTask.id ? updatedTask : task
    );
    io.emit("taskUpdated", updatedTask);
  });

  // Delete task
  socket.on("deleteTask", (taskId) => {
    tasks = tasks.filter((task) => task.id !== taskId);
    io.emit("taskDeleted", taskId);
  });

  socket.on("disconnect", () => {
    console.log("User disconnected:", socket.id);
  });
});

server.listen(5000, () => {
  console.log("Server running on port 5000");
});

