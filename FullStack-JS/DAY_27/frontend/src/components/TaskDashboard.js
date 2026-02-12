import React, { useContext, useEffect, useState } from "react";
import styled, { ThemeProvider } from "styled-components";
import { TaskContext } from "../context/TaskContext";
import TaskManager from "./TaskManager";
import UserPanel from "./UserPanel";
import { io } from "socket.io-client";

const socket = io("http://localhost:5000");

const light = { bg: "#ffffff", color: "#000000" };
const dark = { bg: "#111111", color: "#ffffff" };

const Container = styled.div`
  background: ${p => p.theme.bg};
  color: ${p => p.theme.color};
  min-height: 100vh;
  padding: 20px;
`;

const Notification = styled.div`
  background: #4caf50;
  color: white;
  padding: 10px;
  margin: 10px 0;
  border-radius: 6px;
`;

export default function Dashboard() {
  const { currentUser, register, logout } = useContext(TaskContext);

  const [theme, setTheme] = useState(light);
  const [name, setName] = useState("");
  const [role, setRole] = useState("member");
  const [notification, setNotification] = useState("");

  // ===============================
  // Real-time Notification Listener
  // ===============================
  useEffect(() => {
    socket.on("userNotified", (data) => {
      setNotification(data.message);

      // Auto hide after 4 seconds
      setTimeout(() => {
        setNotification("");
      }, 4000);
    });

    return () => {
      socket.off("userNotified");
    };
  }, []);

  // ===============================
  // LOGIN SCREEN
  // ===============================
  if (!currentUser) {
    return (
      <div style={{ padding: "40px" }}>
        <h2>Login</h2>

        <input
          value={name}
          onChange={e => setName(e.target.value)}
          placeholder="Enter your name"
        />

        <select
          value={role}
          onChange={e => setRole(e.target.value)}
        >
          <option value="member">Member</option>
          <option value="admin">Admin</option>
        </select>

        <button
          onClick={() => {
            if (!name.trim()) {
              alert("Name is required");
              return;
            }
            register(name, role);
          }}
        >
          Enter
        </button>
      </div>
    );
  }

  // ===============================
  // MAIN DASHBOARD
  // ===============================
  return (
    <ThemeProvider theme={theme}>
      <Container>

        {/* Theme Toggle */}
        <button
          onClick={() => setTheme(theme === light ? dark : light)}
        >
          Toggle Theme
        </button>

        {/* Logout */}
        <button
          style={{ marginLeft: "10px" }}
          onClick={logout}
        >
          Logout
        </button>

        {/* Welcome */}
        <h1>
          Welcome {currentUser.name} 
          {currentUser.role === "admin" && " 👑 (Admin)"}
        </h1>

        {/* Notification */}
        {notification && (
          <Notification>
            {notification}
          </Notification>
        )}

        {/* Admin Panel */}
        {currentUser.role === "admin" && <UserPanel />}

        {/* Task Manager */}
        <TaskManager />

      </Container>
    </ThemeProvider>
  );
}
