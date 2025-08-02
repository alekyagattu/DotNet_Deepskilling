import React from 'react';

class EventExamples extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      counter: 0,
      message: '',
    };

    this.handleSyntheticEvent = this.handleSyntheticEvent.bind(this);
  }

  increment = () => {
    this.setState(prev => ({ counter: prev.counter + 1 }));
  }

  decrement = () => {
    this.setState(prev => ({ counter: prev.counter - 1 }));
  }

  sayHello = () => {
    this.setState({ message: 'Hello! Hope you’re doing well.' });
  }

  increaseHandler = () => {
    this.increment();
    this.sayHello();
  }

  sayWelcome = (msg) => {
    this.setState({ message: msg });
  }

  handleSyntheticEvent(event) {
    this.setState({ message: 'I was clicked!' });
    console.log('SyntheticEvent:', event);
  }

  render() {
    return (
      <div style={{ textAlign: "center", padding: "30px" }}>
        <h1>React Event Handling Example</h1>
        <h2>Counter: {this.state.counter}</h2>

        <button onClick={this.increment}>Increment</button>{' '}
        <button onClick={this.decrement}>Decrement</button>{' '}
        <button onClick={this.increaseHandler}>Increase</button>{' '}
        <button onClick={() => this.sayWelcome("Welcome to React!")}>Say Welcome</button>{' '}
        <button onClick={this.handleSyntheticEvent}>OnPress</button>

        <p style={{ marginTop: '20px', fontWeight: 'bold' }}>{this.state.message}</p>
      </div>
    );
  }
}

export default EventExamples;
