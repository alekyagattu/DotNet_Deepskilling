import React from 'react';
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';
import Home from './Home';
import TrainerList from './TrainerList';
import TrainerDetails from './TrainerDetails';
import TrainersMock from './TrainersMock';

function App() {
  return (
    <Router>
      <div>
        <nav style={{ marginBottom: '20px' }}>
          <Link to="/" style={{ marginRight: '15px' }}>Home</Link>
          <Link to="/trainers">Trainers</Link>
        </nav>

        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/trainers" element={<TrainerList trainers={TrainersMock} />} />
          <Route path="/trainer/:id" element={<TrainerDetails />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
