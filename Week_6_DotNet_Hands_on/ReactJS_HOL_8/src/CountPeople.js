import React from 'react';
import './CountPeople.css';

class CountPeople extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      entryCount: 0,
      exitCount: 0
    };
  }

  UpdateEntry = () => {
    this.setState(prevState => ({
      entryCount: prevState.entryCount + 1
    }));
  }

  UpdateExit = () => {
    this.setState(prevState => ({
      exitCount: prevState.exitCount + 1
    }));
  }

  render() {
    return (
      <div className="counter-container">
        <h1>Mall People Counter</h1>
        <div className="counts">
          <p><strong>People Entered:</strong> {this.state.entryCount}</p>
          <p><strong>People Exited:</strong> {this.state.exitCount}</p>
        </div>
        <div className="buttons">
          <button onClick={this.UpdateEntry}>Login</button>
          <button onClick={this.UpdateExit}>Exit</button>
        </div>
      </div>
    );
  }
}

export default CountPeople;
