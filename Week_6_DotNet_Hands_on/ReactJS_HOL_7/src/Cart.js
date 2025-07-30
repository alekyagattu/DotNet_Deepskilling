import React from 'react';
import './Cart.css';

class Cart extends React.Component {
  static defaultProps = {
    Itemname: "Default Item",
    Price: "0.00"
  };

  render() {
    return (
      <div className="cart-item">
        <h3>{this.props.Itemname}</h3>
        <p>Price: ${this.props.Price}</p>
      </div>
    );
  }
}

export default Cart;

