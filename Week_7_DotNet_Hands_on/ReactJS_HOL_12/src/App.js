import React from 'react';
import GuestPage from './GuestPage';
import UserPage from './UserPage';

class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      isLoggedIn: false
    };
  }

  handleLogin = () => {
    this.setState({ isLoggedIn: true });
  }

  handleLogout = () => {
    this.setState({ isLoggedIn: false });
  }

  render() {
    let page;
    if (this.state.isLoggedIn) {
      page = <UserPage />;
    } else {
      page = <GuestPage />;
    }

    return (
      <div style={{ textAlign: 'center', fontFamily: 'Arial' }}>
        <h1>Ticket Booking App</h1>
        <div style={{ marginBottom: '20px' }}>
          {this.state.isLoggedIn ? (
            <button onClick={this.handleLogout}>Logout</button>
          ) : (
            <button onClick={this.handleLogin}>Login</button>
          )}
        </div>
        {page}
      </div>
    );
  }
}

export default App;
