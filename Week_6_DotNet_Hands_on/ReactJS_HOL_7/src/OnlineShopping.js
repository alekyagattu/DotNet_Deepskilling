import React from 'react';
import Cart from './Cart';

class OnlineShopping extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      items: [
        { Itemname: "Laptop", Price: "999.99" },
        { Itemname: "Smartphone", Price: "599.99" },
        { Itemname: "Headphones", Price: "199.99" },
        { Itemname: "Monitor", Price: "299.99" },
        { Itemname: "Keyboard", Price: "49.99" }
      ]
    };
  }

  render() {
    return (
      <div>
        <h1>Welcome to Online Shopping</h1>
        {this.state.items.map((item, index) => (
          <Cart key={index} Itemname={item.Itemname} Price={item.Price} />
        ))}
      </div>
    );
  }
}

export default OnlineShopping;
