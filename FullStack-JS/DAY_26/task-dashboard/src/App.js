import React, { useState, useEffect } from "react";
import io from "socket.io-client";
import "./App.css";

const socket = io("http://localhost:5000");

function App() {
  const [tasks, setTasks] = useState([]);
  const [newTask, setNewTask] = useState("");

  useEffect(() => {
    socket.on("loadTasks", (loadedTasks) => {
      setTasks(loadedTasks);
    });

    socket.on("taskUpdated", (updatedTasks) => {
      setTasks(updatedTasks);
    });

    return () => socket.disconnect();
  }, []);

  const addTask = () => {
    if (newTask.trim() === "") return;

    const task = {
      id: Date.now(),
      title: newTask,
    };

    socket.emit("addTask", task);
    setNewTask("");
  };

  const deleteTask = (id) => {
    socket.emit("deleteTask", id);
  };

  return (
    <div className="app-container">
      <h1>Real-time Task Dashboard</h1>

      <input
        className="task-input"
        type="text"
        placeholder="Enter task"
        value={newTask}
        onChange={(e) => setNewTask(e.target.value)}
      />

      <button className="add-btn" onClick={addTask}>
        Add Task
      </button>

      <ul>
        {tasks.map((task) => (
          <li key={task.id}>
            {task.title}
            <button
              className="delete-btn"
              onClick={() => deleteTask(task.id)}
            >
              X
            </button>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;