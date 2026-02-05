import React, { Component } from "react";
import { io } from "socket.io-client";
import "./StockDashboard.css";

class StockDashboard extends Component {
  constructor(props) {
    super(props);

    this.state = {
      symbol: "AAPL",
      price: "--",
      history: [],
    };

    this.searchRef = React.createRef();
    this.socket = null;
  }

  componentDidMount() {
    this.socket = io("http://localhost:5001");

    this.socket.on("connect", () => {
      console.log("Socket connected");
    });

    this.socket.on("stockPrice", (price) => {
      console.log("Received price:", price);
      this.setState({ price });
    });
  }

  componentWillUnmount() {
    if (this.socket) {
      this.socket.disconnect();
    }
  }

  handleSymbolChange = (e) => {
    this.setState({ symbol: e.target.value });
  };

  handleSearch = () => {
    const value = this.searchRef.current.value;
    if (!value) return;

    this.setState((prev) => ({
      history: [...prev.history, prev.symbol],
      symbol: value,
    }));

    this.searchRef.current.value = "";
  };

  render() {
    return (
      <div className="container mt-5">
        <div className="card p-4">
          <h3 className="text-center mb-3">Stock Dashboard</h3>

          {/* Controlled component */}
          <input
            className="form-control mb-2"
            value={this.state.symbol}
            onChange={this.handleSymbolChange}
          />

          {/* Uncontrolled component */}
          <input
            className="form-control mb-2"
            placeholder="Search new stock"
            ref={this.searchRef}
          />

          <button className="btn btn-primary mb-3" onClick={this.handleSearch}>
            Update Symbol
          </button>

          <h5>Live Price: {this.state.price}</h5>

          <h6 className="mt-3">Previous Searches:</h6>
          <ul>
            {this.state.history.map((s, i) => (
              <li key={i}>{s}</li>
            ))}
          </ul>
        </div>
      </div>
    );
  }
}

export default StockDashboard;