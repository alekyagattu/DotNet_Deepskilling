import React from 'react';

const UserPage = () => (
  <div style={{ padding: '20px' }}>
    <h2>Welcome User!</h2>
    <p>You can now book your tickets:</p>
    <ul>
      <li>✔ Flight A123 - $499</li>
      <li>✔ Flight B456 - $399</li>
      <li>✔ Flight C789 - $699</li>
    </ul>
    <button>Book Now</button>
  </div>
);

export default UserPage;
