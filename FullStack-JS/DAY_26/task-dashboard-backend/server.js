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

// WebSocket connection
io.on("connection", (socket) => {
  console.log("User connected:", socket.id);

  // Send existing tasks to new user
  socket.emit("loadTasks", tasks);

  // Add task
  socket.on("addTask", (task) => {
    tasks.push(task);
    io.emit("taskUpdated", tasks);
  });

  // Delete task
  socket.on("deleteTask", (taskId) => {
    tasks = tasks.filter(task => task.id !== taskId);
    io.emit("taskUpdated", tasks);
  });

  socket.on("disconnect", () => {
    console.log("User disconnected:", socket.id);
  });
});

server.listen(5000, () => {
  console.log("Server running on port 5000");
});
