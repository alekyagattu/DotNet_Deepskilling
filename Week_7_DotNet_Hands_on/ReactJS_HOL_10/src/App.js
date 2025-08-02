import React from 'react';
import './App.css';

function App() {
  // JSX heading
  const heading = <h1>Office Space Rental Listings</h1>;

  // Office image
  const image = (
    <img
      src="https://images.unsplash.com/photo-1570129477492-45c003edd2be"
      alt="Office Space"
      width="600"
      style={{ borderRadius: "10px", marginBottom: "20px" }}
    />
  );

  // Office object
  const office = {
    name: "Regus Workspace",
    rent: 55000,
    address: "Banjara Hills, Hyderabad"
  };

  // Office list
  const offices = [
    { name: "WeWork", rent: 75000, address: "Koramangala, Bangalore" },
    { name: "91SpringBoard", rent: 45000, address: "Indiranagar, Bangalore" },
    { name: "SmartWorks", rent: 68000, address: "Cybercity, Gurgaon" },
    { name: "Innov8", rent: 58000, address: "Connaught Place, Delhi" }
  ];

  // Function to determine rent color
  const getRentStyle = (rent) => {
    return {
      color: rent < 60000 ? 'red' : 'green',
      fontWeight: 'bold'
    };
  };

  return (
    <div className="App" style={{ textAlign: "center", padding: "30px" }}>
      {heading}
      {image}

      <div style={{ marginBottom: "30px" }}>
        <h2>Featured Office</h2>
        <p><strong>Name:</strong> {office.name}</p>
        <p><strong>Rent:</strong> <span style={getRentStyle(office.rent)}>{office.rent}</span></p>
        <p><strong>Address:</strong> {office.address}</p>
      </div>

      <div>
        <h2>Other Listings</h2>
        {offices.map((o, index) => (
          <div key={index} style={{
            border: '1px solid #ccc',
            borderRadius: '10px',
            margin: '10px auto',
            padding: '15px',
            width: '60%',
            textAlign: 'left'
          }}>
            <p><strong>Name:</strong> {o.name}</p>
            <p><strong>Rent:</strong> <span style={getRentStyle(o.rent)}>{o.rent}</span></p>
            <p><strong>Address:</strong> {o.address}</p>
          </div>
        ))}
      </div>
    </div>
  );
}

export default App;

