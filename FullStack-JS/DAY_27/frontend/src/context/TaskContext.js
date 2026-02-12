import React, { createContext, useState, useEffect } from "react";
import io from "socket.io-client";

export const TaskContext = createContext();

// Single socket instance
const socket = io("http://localhost:5000");

export const TaskProvider = ({ children }) => {
  const [tasks, setTasks] = useState([]);
  const [users, setUsers] = useState([]);
  const [notifications, setNotifications] = useState([]);
  const [currentUser, setCurrentUser] = useState(null);

  // ===============================
  // SOCKET LISTENERS
  // ===============================
  useEffect(() => {

    // Load initial tasks
    socket.on("loadTasks", (initialTasks) => {
      setTasks(initialTasks);
    });

    // Task events
    socket.on("taskAdded", (newTask) => {
      setTasks(prev => [...prev, newTask]);
    });

    socket.on("taskUpdated", (updatedTasks) => {
      setTasks(updatedTasks);
    });

    socket.on("taskDeleted", (deletedId) => {
      setTasks(prev => prev.filter(task => task.id !== deletedId));
    });

    // Users update
    socket.on("usersUpdated", (updatedUsers) => {
      setUsers(updatedUsers);
    });

    // Notification event
    socket.on("userNotified", (data) => {
      if (currentUser) {
        setNotifications(prev => [...prev, data.message]);
      }
    });

    return () => {
      socket.off("loadTasks");
      socket.off("taskAdded");
      socket.off("taskUpdated");
      socket.off("taskDeleted");
      socket.off("usersUpdated");
      socket.off("userNotified");
    };

  }, [currentUser]);

  // ===============================
  // REGISTER USER
  // ===============================
  const register = (name, role) => {
    const user = { name, role };
    setCurrentUser(user);
    socket.emit("registerUser", user);
  };

  // ===============================
  // LOGOUT
  // ===============================
  const logout = () => {
    setCurrentUser(null);
    setTasks([]);
    setUsers([]);
    setNotifications([]);
  };

  return (
    <TaskContext.Provider
      value={{
        socket,
        tasks,
        users,
        notifications,
        currentUser,
        register,
        logout
      }}
    >
      {children}
    </TaskContext.Provider>
  );
};
