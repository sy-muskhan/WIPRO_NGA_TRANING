import { useEffect, useState } from "react";
import "./App.css";
import UserList from "./UserList";

function App() {
  const [users, setUsers] = useState([]);
  const [name, setName] = useState("");

  useEffect(() => {
    fetch("http://localhost:5000/users")
      .then((res) => res.json())
      .then((data) => setUsers(data));
  }, []);

  const addUser = () => {
    if (!name) return;

    fetch("http://localhost:5000/users", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({ name }),
    })
      .then((res) => res.json())
      .then((newUser) => {
        setUsers([...users, newUser]);
        setName("");
      });
  };

  return (
  <div className="container">
    <h2>User Management</h2>

    <input
      type="text"
      placeholder="Enter name"
      value={name}
      onChange={(e) => setName(e.target.value)}
    />

    <button onClick={addUser}>Add User</button>

    <UserList users={users} />
  </div>
);

}

export default App;
