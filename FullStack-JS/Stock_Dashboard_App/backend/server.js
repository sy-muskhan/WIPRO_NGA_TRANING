const express = require("express");
const http = require("http");
const { Server } = require("socket.io");
const cors = require("cors");

const app = express();
app.use(cors());

const server = http.createServer(app);
const io = new Server(server, {
  cors: {
    origin: "*",
  },
});

// Dummy stock price
let price = 100;

io.on("connection", (socket) => {
  console.log("Client connected");

  const interval = setInterval(() => {
    price = price + (Math.random() * 10 - 5);
    io.emit("stockPrice", price.toFixed(2));
  }, 3000);

  socket.on("disconnect", () => {
    clearInterval(interval);
    console.log("Client disconnected");
  });
});

server.listen(5001, () => {
  console.log("Backend running on http://localhost:5001");
});
