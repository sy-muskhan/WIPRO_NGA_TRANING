import React, { useContext } from "react";
import styled from "styled-components";
import { TaskContext } from "../context/TaskContext";

const Panel = styled.div`
  border: 1px solid #ccc;
  padding: 15px;
  margin: 20px 0;
  border-radius: 8px;
`;

const UserCard = styled.div`
  display: flex;
  justify-content: space-between;
  align-items: center;
  border: 1px solid #ddd;
  padding: 8px;
  margin-bottom: 8px;
  border-radius: 6px;
`;

export default function UserPanel() {
  const { users, currentUser, socket } = useContext(TaskContext);

  // Only admin can see this
  if (!currentUser || currentUser.role !== "admin") return null;

  const removeUser = (userId, userName) => {
    const confirmRemove = window.confirm(
      `Are you sure you want to remove ${userName}?`
    );

    if (confirmRemove) {
      socket.emit("removeUser", userId);
    }
  };

  return (
    <Panel>
      <h2>Users Management</h2>

      {users.length === 0 && <p>No users connected.</p>}

      {users.map((u) => (
        <UserCard key={u.id}>
          <span>
            {u.name} ({u.role})
          </span>

          {/* Prevent Admin Removing Self */}
          {u.id !== currentUser.id && u.role !== "admin" && (
            <button
              onClick={() => removeUser(u.id, u.name)}
            >
              Remove
            </button>
          )}
        </UserCard>
      ))}
    </Panel>
  );
}
