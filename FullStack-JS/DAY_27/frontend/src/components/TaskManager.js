import React, { useContext, useState } from "react";
import { TaskContext } from "../context/TaskContext";

export default function TaskManager() {
  const { socket, tasks, users, currentUser } = useContext(TaskContext);

  const [form, setForm] = useState({
    title: "",
    description: "",
    deadline: "",
    assignee: ""
  });

  const [editingId, setEditingId] = useState(null);

  // =============================
  // Handle Input Change
  // =============================
  const handleChange = (e) => {
    setForm({
      ...form,
      [e.target.name]: e.target.value
    });
  };

  // =============================
  // Add / Update Task
  // =============================
  const saveTask = () => {
    if (!form.title || !form.description || !form.deadline || !form.assignee) {
      alert("All fields are required!");
      return;
    }

    if (editingId) {
      socket.emit("updateTask", {
        ...form,
        id: editingId
      });
      setEditingId(null);
    } else {
      socket.emit("addTask", form);
    }

    setForm({
      title: "",
      description: "",
      deadline: "",
      assignee: ""
    });
  };

  // =============================
  // Start Editing
  // =============================
  const startEdit = (task) => {
    if (
      currentUser.role === "admin" ||
      task.assignee === currentUser.name
    ) {
      setForm({
        title: task.title,
        description: task.description,
        deadline: task.deadline,
        assignee: task.assignee
      });
      setEditingId(task.id);
    } else {
      alert("You can only edit your own tasks!");
    }
  };

  // =============================
  // Cancel Editing
  // =============================
  const cancelEdit = () => {
    setEditingId(null);
    setForm({
      title: "",
      description: "",
      deadline: "",
      assignee: ""
    });
  };

  return (
    <div>
      <h2>Tasks</h2>

      {/* ================= FORM ================= */}
      <input
        name="title"
        value={form.title}
        onChange={handleChange}
        placeholder="Title"
      />

      <input
        name="description"
        value={form.description}
        onChange={handleChange}
        placeholder="Description"
      />

      <input
        type="date"
        name="deadline"
        value={form.deadline}
        onChange={handleChange}
      />

      <select
        name="assignee"
        value={form.assignee}
        onChange={handleChange}
        disabled={currentUser.role !== "admin" && editingId !== null}
      >
        <option value="">Assign To</option>
        {users.map((u) => (
          <option key={u.id} value={u.name}>
            {u.name}
          </option>
        ))}
      </select>

      <button onClick={saveTask}>
        {editingId ? "Update Task" : "Add Task"}
      </button>

      {editingId && (
        <button onClick={cancelEdit} style={{ marginLeft: "10px" }}>
          Cancel
        </button>
      )}

      {/* ================= TASK LIST ================= */}
      {tasks.map((t) => (
        <div
          key={t.id}
          style={{
            border: "1px solid gray",
            margin: "10px",
            padding: "10px"
          }}
        >
          <h3>{t.title}</h3>
          <p>{t.description}</p>
          <p>Deadline: {t.deadline}</p>
          <p>Assigned: {t.assignee}</p>

          {/* Edit Permission */}
          {(currentUser.role === "admin" ||
            t.assignee === currentUser.name) && (
            <button onClick={() => startEdit(t)}>Edit</button>
          )}

          {/* Delete Permission */}
          {(currentUser.role === "admin" ||
            t.assignee === currentUser.name) && (
            <button
              onClick={() => socket.emit("deleteTask", t.id)}
              style={{ marginLeft: "10px" }}
            >
              Delete
            </button>
          )}
        </div>
      ))}
    </div>
  );
}
