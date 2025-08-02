import React from 'react';

class CurrencyConvertor extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      rupees: '',
      euro: null,
    };
  }

  handleChange = (e) => {
    this.setState({ rupees: e.target.value });
  }

  handleSubmit = (e) => {
    e.preventDefault();
    const euro = (this.state.rupees / 90).toFixed(2); // Assume €1 = ₹90
    this.setState({ euro });
  }

  render() {
    return (
      <div style={{ textAlign: "center", padding: "20px" }}>
        <h2>Currency Convertor (INR to EURO)</h2>
        <form onSubmit={this.handleSubmit}>
          <input
            type="number"
            value={this.state.rupees}
            onChange={this.handleChange}
            placeholder="Enter amount in INR"
          />
          <button type="submit" style={{ marginLeft: "10px" }}>Convert</button>
        </form>
        {this.state.euro && (
          <p><strong>Converted Amount:</strong> €{this.state.euro}</p>
        )}
      </div>
    );
  }
}

export default CurrencyConvertor;
